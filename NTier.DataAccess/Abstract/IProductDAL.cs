using Core.DataAccess;
using NTier.Entities;
using System.Collections.Generic;

namespace NTier.DataAccess.Abstract
{
    public interface IProductDAL : IRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
