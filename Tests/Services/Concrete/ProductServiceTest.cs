using Services.Business.Abstract;
using Services.Business.Concrete;
using Services.Dtos;
using Services.Results;
using Tests.Services.Bases;
using Xunit;

namespace Tests.Services.Concrete
{
    public class ProductServiceTest : BaseProductServiceTest
    {
        private readonly IProductService _productService;
        public ProductServiceTest()
        {
            _productService = new ProductService(_productRepository);
        }
        [Fact]
        public void Add_ProductNameEmpty_ReturnErrorResult()
        {
            var productDto = new CreateProductDto
            {
                Name = "",
                Color = "Kırmızı",
                CategoryId = 1,
            };
            var result = _productService.Add(productDto);

            Assert.IsAssignableFrom<ErrorResult>(result);
        }
        [Fact]
        public void Add_Execute_ReturmSuccessResult()
        {
            var productDto = new CreateProductDto
            {
                Name = "adds",
                Color = "Kırmızı",
                CategoryId = 1,
            };
            var result = _productService.Add(productDto);
            Assert.IsAssignableFrom<SuccessResult>(result);
        }
    }
}
