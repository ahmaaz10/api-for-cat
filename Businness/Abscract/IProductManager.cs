﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Abscract
{
	public interface IProductManager
	{
		List<Product> GetAllProducts();
		List<ProductDTO> GetAllProductList();
		void AddProduct(AddProductDTO product);
	}
}
