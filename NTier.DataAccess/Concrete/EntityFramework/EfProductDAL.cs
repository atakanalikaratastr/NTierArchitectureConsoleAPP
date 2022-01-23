    using Core.DataAccess.EntityFramework;
using NTier.DataAccess.Abstract;
using NTier.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NTier.DataAccess.Concrete
{
    public class EfProductDAL : RepositoryBase<Product, NTier_Context>, IProductDAL
    {
        public List<ProductDetailDTO> GetProductDetails()
        {
            using (var context = new NTier_Context())
            {
                var result = from product in context.Products
                             join supplier in context.Suppliers
                             on product.SupplierID equals supplier.SupplierID
                             join category in context.Categories
                             on product.CategoryID equals category.CategoryID
                             select new ProductDetailDTO
                             {
                                 ProductName = product.ProductName,
                                 CompanyName = supplier.CompanyName,
                                 CategoryName = category.CategoryName
                             };

                return result.ToList();
            }
        }
    }
}
