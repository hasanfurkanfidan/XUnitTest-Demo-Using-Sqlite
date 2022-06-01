using Services.DataAccess.Repositories.Abstract;
using Services.Entities;

namespace Services.DataAccess.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(Product product)
        {
            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
        }

        public void Delete(Product product)
        {
            _appDbContext.Remove(product);
            _appDbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _appDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _appDbContext.Products.Find(id);
        }

        public void Update(Product product)
        {
            _appDbContext.Update(product);
            _appDbContext.SaveChanges();
        }
    }
}
