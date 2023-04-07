using SalesSystem_AP1_Levid.Data;
public class SaleBLL
{
    private ApplicationDbContext _context;
    public SaleBLL(ApplicationDbContext context)
    {
        _context = context;
    }
    public bool Exist(int SaleId)
    {
        return _context.Sales.Any(sale => sale.SaleId == SaleId);
    }
    public bool Insert(Sale sale)
    {
        bool changed = false;
        try{
            Product? product;
            Seller? seller;
            foreach(var detail in sale.SalesDetails)
            {
                product = _context.Products.SingleOrDefault(p => p.ProductId == detail.ProductId);
                if(product != null)
                {
                    product.Existence -= detail.Quantity;
                    sale.Quantity += detail.Quantity;
                    detail.AmountPaid += product.Price * detail.Quantity;
                    seller = _context.Sellers.SingleOrDefault(s => s.SellerId == sale.SellerId);
                    if(seller != null)
                    {
                        seller.TotalProductsSold += detail.Quantity;
                        _context.Entry(seller).State = EntityState.Modified;
                    }
                    _context.Entry(product).State = EntityState.Modified;
                    _context.Entry(detail).State = EntityState.Added;
                }
            }
            _context.Entry(sale).State = EntityState.Added;
            changed = _context.SaveChanges() > 0;
            _context.Entry(sale).State = EntityState.Detached;
        } 
        catch(Exception)
        {
            return false;
        }
        return changed;
    }
    public bool Modify(Sale sale)
    {
        bool changed = false;
        try{
            var saleFound = Search(sale.SaleId);
            Seller? seller = new Seller();
            Product? product;
            if(saleFound != null)
            {
                seller = _context.Sellers.SingleOrDefault(s => s.SellerId == saleFound.SellerId);
                if(seller != null)
                {
                    seller.TotalProductsSold += saleFound.Quantity;
                    _context.Sellers.Entry(seller).State = EntityState.Modified;
                }
            }
            _context.Database.ExecuteSqlRaw($"DELETE FROM SaleDetail WHERE SaleId = {sale.SaleId}");
            foreach(var detail in sale.SalesDetails)
            {
                product = _context.Products.Find(detail.ProductId);
                if (product != null)
                {
                    product.Existence -= detail.Quantity;
                    if(saleFound != null)
                    {
                        saleFound.Quantity += detail.Quantity;
                        _context.Sales.Entry(sale).State = EntityState.Modified;
                    }
                    detail.AmountPaid += product.Price * detail.Quantity;
                }
                _context.Entry(detail).State = EntityState.Added;
            }
            _context.Entry(sale).State = EntityState.Modified;
            changed= _context.SaveChanges() > 0;
            _context.Entry(sale).State = EntityState.Detached;
        }
        catch(Exception)
        {
            return false;
        }
        return changed;
    }
    public bool Save(Sale Sale)
    {
        try{
            if(!Exist(Sale.SaleId))
                return Insert(Sale);
            else
                return Modify(Sale);
        }
        catch(Exception)
        {
            return false;
        }
        
    }
    public bool Delete(Sale sale)
    {
        bool changed = false;
        try{
            Product? product;
            foreach (var detail in sale.SalesDetails)
            {
                product = _context.Products.SingleOrDefault(p => p.ProductId == detail.ProductId);
                if(product != null)
                {
                    product.Existence += detail.Quantity;
                    _context.Entry(product).State = EntityState.Modified;
                }
                Seller? seller;
                seller = _context.Sellers.SingleOrDefault(s => s.SellerId == sale.SellerId);
                if(seller != null)
                {
                    seller.TotalProductsSold -= detail.Quantity;
                    _context.Entry(seller).State = EntityState.Modified;
                }
            }
            _context.Entry(sale).State = EntityState.Deleted;
            changed = _context.SaveChanges() > 0;
            _context.Entry(sale).State = EntityState.Detached;
        }
        catch(Exception)
        {
            return false;
        }
        return changed;
    }
    public Sale? Search(int SaleId)
    {
        return _context.Sales.Include(det => det.SalesDetails).Where(Sale => Sale.SaleId == SaleId).AsNoTracking().SingleOrDefault();
    }
    public List<Sale> GetList(Expression<Func<Sale,bool>> criterion)
    {
        return _context.Sales.Include(det => det.SalesDetails).AsNoTracking().Where(criterion).ToList();
    }
}