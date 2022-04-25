using Businness.Abscract;
using Businness.Constants;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductManager _productManager;

		public ProductController(IProductManager productManager)
		{
			_productManager = productManager;
		}

		[HttpGet("getall")]
		public IActionResult GetAllProduct()
		{
			var products = _productManager.GetAllProducts();
			if (products.Count ==0)
				return Ok(new { status = 200, message = "hec bir mahusle tapilmadi" });
			return Ok(new {status=200,message = products});


		}
		[HttpGet("productlist")]
		public IActionResult ProductList()
		{
			var productList = _productManager.GetAllProductList();
			return Ok(new { status = 200, message = productList });
		}
		[HttpPost("add")]
		public IActionResult AddProduct(AddProductDTO product)
		{
			try
			{
				_productManager.AddProduct(product);
			}
			catch (Exception e)
			{
				return Ok(new {status=400,message = e});
			}
			return Ok(new { status = 200 ,message ="mehsul elave olundu!"}) ;

		}
	}
}
