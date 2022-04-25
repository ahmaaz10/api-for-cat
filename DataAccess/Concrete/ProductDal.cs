using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal : EfEntityRepositoryBase<Product, ShopDbContext>, IProductDal
    {
        public List<ProductDTO> GetAllProducts()
        {

            using (ShopDbContext _context = new())
            {
                var products = _context.Products.Include(x => x.Category).Include(x => x.ProductPitcures).ToList();
                var productPictures = _context.ProductPitcure;

                List<ProductDTO> result = new();

              

                for (int i = 1; i < products.Count; i++)
                {
                    List<string> pitcures = new();


                    foreach (var item in productPictures.Where(x => x.ProductId == products[i].Id))
                    {
                        pitcures.Add(item.PhotoUrl);
                    }

                    ProductDTO productList = new()
                    {

                        Id = products[i].Id,
                        Name = products[i].Name,
                        Description = products[i].Description,
                        SKU = products[i].SKU,
                        CategoryName = products[i].Category.Name,
                        Price = products[i].Price,
                        Summary = products[i].Summary,
                        ProductPitcures = pitcures,

                    };
                    result.Add(productList);

                }






                return result;
            }
        }
    }
}