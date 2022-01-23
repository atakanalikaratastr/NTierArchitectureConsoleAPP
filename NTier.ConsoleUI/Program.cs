using NTier.Business.Concrete;
using NTier.DataAccess.Concrete;
using NTier.DataAccess.Concrete.EntityFramework;
using NTier.Entities;
using System;

namespace NTier.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDAL()
               , new SupplierManager(new EfSupplierDAL()));

            #region GetProductList
            //var ProductList = productManager.GetProductList();
            //ProductList.ForEach(x => Console.WriteLine(x.ProductName));
            #endregion

            #region ProductList(Detail)
            //var productDetails = productManager.GetProductDetails();

            //productDetails.ForEach(x => Console.WriteLine(x.ProductName + " " + x.CompanyName + " " + x.CategoryName));
            #endregion

            #region Product Add
            try
            {
                productManager.Add(new Product
                {
                    ProductName = "Test",
                    UnitPrice = 100,
                    CategoryID = 1,
                    SupplierID = 1
                });

                var productList = productManager.GetProductList();
                productList.ForEach(x => Console.WriteLine(x.ProductName));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Product Update
            //productManager.Update(new Product
            //{
            //    ProductID = 1007,
            //    ProductName = "TestUpdate",
            //    UnitPrice = 200,
            //    CategoryID = 2,
            //    SupplierID = 2
            //});

            //var productList = productManager.GetProductList();
            //productList.ForEach(x => Console.WriteLine(x.ProductName));
            #endregion

            #region Product Delete
            //productManager.Delete(new Product
            //{
            //    ProductID = 1007,
            //    ProductName = "TestUpdate",
            //    UnitPrice = 200,
            //    CategoryID = 2,
            //    SupplierID = 2
            //});

            //var productList = productManager.GetProductList();
            //productList.ForEach(x => Console.WriteLine(x.ProductName));
            #endregion

            #region GetProductsByCategoryId
            //var getByProductsByCategoryId = productManager.GetProductsByCategoryId(2);
            //getByProductsByCategoryId.ForEach(x => Console.WriteLine(x.ProductName)); 
            #endregion

            #region GetProductByProductId
            //var product = productManager.GetProductByProductId(1);
            //Console.WriteLine(product.ProductName);
            #endregion
        }
    }
}
