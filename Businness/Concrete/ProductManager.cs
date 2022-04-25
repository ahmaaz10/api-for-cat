using Businness.Abscract;
using DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
	public class ProductManager : IProductManager
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public void AddProduct(AddProductDTO productDTO)
		{
			Product product = new()
			{
				Name = productDTO.Name,
				CategoryId = productDTO.CategoryId,
				Description = productDTO.Description,
				Price = productDTO.Price,
				SKU = productDTO.SKU,
				Summary = productDTO.Summary,

			};
		
			_productDal.Add(product);
		}

		public List<ProductDTO> GetAllProductList()
		{
			return _productDal.GetAllProducts();
		}

		public List<Product> GetAllProducts()
		{
			return _productDal.GetAll();
		}
	}
}
