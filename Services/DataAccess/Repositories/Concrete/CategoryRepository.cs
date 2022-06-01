using Services.DataAccess.Repositories.Abstract;
using Services.Entities;

namespace Services.DataAccess.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(Category category)
        {
            _appDbContext.Categories.Add(category);
            _appDbContext.SaveChanges();
        }

        public void Delete(Category category)
        {
            _appDbContext.Categories.Remove(category);
            _appDbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _appDbContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _appDbContext.Categories.Find(id);
        }

        public void Update(Category category)
        {
            _appDbContext.Update(category);
            _appDbContext.SaveChanges();
        }
    }
}
