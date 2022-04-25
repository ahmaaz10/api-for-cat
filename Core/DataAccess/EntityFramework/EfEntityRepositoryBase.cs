
using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRespository<TEntity>
		where TEntity : class , IEntity,new()
		where TContext : DbContext,new()
	{
		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				using TContext context1 = new();
				var addEntity = context.Entry(entity);
				addEntity.State= EntityState.Added;
				context.SaveChanges();

			}
		}
	

		public void Update(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				using TContext context1 = new();
				var UpdateEntity = context.Entry(entity);
				UpdateEntity.State = EntityState.Modified;
				context.SaveChanges();

			}
		}

		public void Delete(TEntity entity)
		{
			using TContext context = new();
			var deleteEntity = context.Entry(entity);
			deleteEntity.State = EntityState.Deleted;
			context.SaveChanges();

		
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			using TContext context = new();
			return filter == null 
				? context.Set<TEntity>().ToList()
				: context.Set<TEntity>().Where(filter).ToList();
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{ 
			using TContext context = new();
			return context.Set<TEntity>().FirstOrDefault(filter);
		}

		
	}
}
