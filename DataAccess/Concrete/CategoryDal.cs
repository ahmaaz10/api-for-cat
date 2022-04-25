using Core.DataAccess.EntityFramework;
using DataAccess.Abscract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
	public class CategoryDal : EfEntityRepositoryBase<Category,ShopDbContext>,ICategoryDal
	{
		 
	}
}
