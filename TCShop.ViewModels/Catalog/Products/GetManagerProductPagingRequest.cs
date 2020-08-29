using System.Collections.Generic;
using TCShop.ViewModels.Common;

namespace TCShop.ViewModels.Catalog.Products
{
    public class GetManagerProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}