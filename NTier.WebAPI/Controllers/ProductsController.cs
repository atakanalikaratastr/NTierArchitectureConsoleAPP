using Microsoft.AspNetCore.Mvc;
using NTier.Business.Abstract;
using NTier.Entities;
using System;

namespace NTier.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService =  productService;
        }
  
        [HttpGet("getProductDetailList")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _productService.GetProductDetails();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("addProduct")]
        public IActionResult Add(Product product)
        {
            try
            {
                _productService.Add(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("updateProduct")]
        public IActionResult Update(Product product)
        {
            try
            {
                _productService.Update(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("getProduct")]
        public IActionResult Get(int Id)
        {
            try
            {
                var result = _productService.GetProductByProductId(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteProduct")]
        public IActionResult Delete(Product product)
        {
            try
            {
                _productService.Delete(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
