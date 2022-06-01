using Services.DataAccess.Repositories.Abstract;
using Services.DataAccess.Repositories.Concrete;
using Services.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Services.Entities;

namespace Tests.Services.Bases
{
    public abstract class BaseProductServiceTest
    {
        protected readonly IProductRepository _productRepository;
        protected readonly ICategoryRepository _categoryRepository;
        public BaseProductServiceTest()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            var context = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>().UseSqlite(connection).Options);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            _productRepository = new ProductRepository(context);
            _categoryRepository = new CategoryRepository(context);
            Seed();
        }
        public void Seed()
        {

            _categoryRepository.Add(new Category
            {
                Name = "Kalem"
            });

            _productRepository.Add(new Product
            {
                CategoryId = 1,
                Color = "Mavi",
                Name = "Kalem"
            });
        }
    }
}
