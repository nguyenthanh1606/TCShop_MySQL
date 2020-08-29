using System.Collections.Generic;
using System.Threading.Tasks;
using TCShop.ViewModels.Catalog.Products;
using TCShop.ViewModels.Common;

namespace TCShop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategory(string languageId, GetPublicProductPagingRequest request);
        Task<List<ProductViewModel>> GetAll(string languageId);
    }
}