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
                    sale.Total += detail.AmountPaid;
                    _context.Entry(product).State = EntityState.Modified;
                    _context.Entry(detail).State = EntityState.Added;
                }
            }
            seller = _context.Sellers.SingleOrDefault(s => s.SellerId == sale.SellerId);
            if(seller != null)
            {
                seller.TotalSold += sale.Total;
                _context.Entry(seller).State = EntityState.Modified;
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
    private bool Modify(Sale sale)
    {
        var oldDetail = _context.Sales.AsNoTracking().Where(o => o.SaleId== sale.SaleId)
                .Include(o =>  o.SalesDetails)
                .AsNoTracking()
                .SingleOrDefault();
        foreach (var detail in oldDetail!.SalesDetails)
        {
            var product = _context.Products.Find(detail.ProductId);
            if(product!=null){
                product.Existence += detail.Quantity;
                sale.Total -= detail.AmountPaid;
                var seller = _context.Sellers.Find(sale.SellerId);
                if(seller != null)
                {
                    seller.TotalSold -= detail.AmountPaid;
                    _context.Entry(seller).State = EntityState.Modified;
                }
                _context.Entry(product).State = EntityState.Modified;
            }
        }
        _context.Entry(oldDetail).State = EntityState.Detached;
        foreach (var detail in sale.SalesDetails)
        {
            var product = _context.Products.Find(detail.ProductId);
            if(product!=null){
                product.Existence -= detail.Quantity;
                sale.Total += detail.AmountPaid;
                var seller = _context.Sellers.Find(sale.SellerId);
                if(seller != null)
                {
                    seller.TotalSold += detail.AmountPaid;
                }
                _context.Entry(product).State = EntityState.Modified;
            }
        }
        _context.Entry(oldDetail).State = EntityState.Detached;

        var DetalleEliminar = _context.Set<SaleDetail>().Where(o => o.SaleId == sale.SaleId);
        _context.Set<SaleDetail>().RemoveRange(DetalleEliminar);
        _context.Set<SaleDetail>().AddRange(sale.SalesDetails);
        _context.Entry(sale).State = EntityState.Modified;

        bool paso = _context.SaveChanges() >0;
        _context.Entry(sale).State = EntityState.Detached;
        return paso; 
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
            }
            Seller? seller;
            seller = _context.Sellers.SingleOrDefault(s => s.SellerId == sale.SellerId);
            if(seller != null)
            {
                seller.TotalSold -= sale.Total;
                _context.Entry(seller).State = EntityState.Modified;
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