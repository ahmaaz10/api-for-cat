﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
	public class ProductDTO
	{

		public int Id { get; set; }
		public decimal Price { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public string Summary { get; set; }
		public string SKU { get; set; }
		public string CategoryName { get; set; }

		public List<string> ProductPitcures { get; set; }

	}
}
