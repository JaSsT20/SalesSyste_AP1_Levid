using SalesSystem_AP1_Levid.Data;
public class SellerBLL
{
    private ApplicationDbContext _context;
    public SellerBLL(ApplicationDbContext context)
    {	
        _context = context;
    }
    public bool Exist(int SellerId)
    {
        return _context.Sellers.Any(seller => seller.SellerId == SellerId);
    }
    public bool Insert(Seller seller)
    {
        bool changes = false;
        _context.Sellers.Add(seller);
        changes = _context.SaveChanges() > 0;
        _context.Sellers.Entry(seller).State = EntityState.Detached;
        return changes;
    }
    public bool Modify(Seller seller)
    {
        bool changes = false;
        _context.Entry(seller).State = EntityState.Modified;
        changes =  _context.SaveChanges() > 0;
        _context.Sellers.Entry(seller).State = EntityState.Detached;
        return changes;
    }
    public bool Save(Seller seller)
    {
        try{
            if(!Exist(seller.SellerId))
                return Insert(seller);
            else
                return Modify(seller);
        }
        catch(Exception e)
        {
            System.Console.WriteLine($"Error {e}");
            return false;
        }   
    }
    public bool Delete(Seller seller)
    {
        bool changes = false;
        try{
            _context.Entry(seller).State = EntityState.Deleted;
            changes = _context.SaveChanges() > 0;
            _context.Sellers.Entry(seller).State = EntityState.Detached;
            return changes;
        }
        catch(Exception){
            return false;
        }
    }
    public Seller? Search(int sellerId)
    {
        return _context.Sellers.Where(slr => slr.SellerId == sellerId).AsNoTracking().SingleOrDefault();
    }
    public List<Seller> GetList(Expression<Func<Seller,bool>> criterion)
    {
        return _context.Sellers.AsNoTracking().Where(criterion).ToList();
    }
}