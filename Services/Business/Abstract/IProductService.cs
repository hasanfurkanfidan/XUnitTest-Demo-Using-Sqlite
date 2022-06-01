using Services.Dtos;
using Services.Results;

namespace Services.Business.Abstract
{
    public interface IProductService
    {
        Result Add(CreateProductDto createProductDto);
    }
}
