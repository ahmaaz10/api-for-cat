using Businness.Abscract;
using DataAccess.Abscract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businness.Concrete
{
	public class CategoryManager : ICategoryManager
	{
		private readonly ICategoryDal categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			this.categoryDal = categoryDal;
		}

		public void Add(Category category)
		{
			categoryDal.Add(category);
		}

		public List<Category> GetAllCategories()
		{
			return categoryDal.GetAll();
		}

		public Category GetCategoryById(int id)
		{
			return categoryDal.Get(x => x.Id == id);
		}

		public void Remove(Category category)
		{
			categoryDal.Delete(category);
		}

		public void Update(Category category)
		{
			categoryDal.Update(category);
		}
	}
}
