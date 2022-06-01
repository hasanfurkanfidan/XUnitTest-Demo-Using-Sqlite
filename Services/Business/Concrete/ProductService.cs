using Services.Business.Abstract;
using Services.DataAccess.Repositories.Abstract;
using Services.Dtos;
using Services.Results;

namespace Services.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Result Add(CreateProductDto createProductDto)
        {
            if (string.IsNullOrEmpty(createProductDto.Name))
                return new ErrorResult();

            _productRepository.Add(new Entities.Product
            {
                CategoryId = createProductDto.CategoryId,
                Color = createProductDto.Color,
                Name = createProductDto.Name,
            });

            return new SuccessResult();
        }
    }
}
