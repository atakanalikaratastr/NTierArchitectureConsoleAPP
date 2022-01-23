using NTier.Business.Abstract;
using NTier.DataAccess.Abstract;
using NTier.Entities;
using System;
using System.Collections.Generic;

namespace NTier.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDAL _productDal;
        ISupplierService _supplierService;
        public ProductManager(IProductDAL productDal, ISupplierService supplierService)
        {
            _productDal = productDal;
            _supplierService = supplierService;
        }

        public void Add(Product product)
        {
            SupplierLimitExceded();
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetProductByProductId(int id)
        {
            return _productDal.Get(x => x.ProductID == id);
        }

        public List<ProductDetailDTO> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public List<Product> GetProductList()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategoryId(int id)
        {
            return _productDal.GetAll(x => x.CategoryID == id);
        }
        
        public void Update(Product product)
        {
            _productDal.Update(product);
        }   

        private void SupplierLimitExceded()
        {
            var result = _supplierService.GetSuppliers().Count;
            if (result > 3)
            {
                throw new Exception("Tedarikçi limiti aşıldığı için ürün eklenemez!");
            }
        }
    }
}
