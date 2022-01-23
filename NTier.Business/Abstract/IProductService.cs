using NTier.Entities;
using System.Collections.Generic;

namespace NTier.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProductList();
        List<ProductDetailDTO> GetProductDetails();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetProductsByCategoryId(int id);
        Product GetProductByProductId(int id);
    }
}
