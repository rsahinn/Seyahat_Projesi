﻿using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Add(T entity)
		{
			using var c = new Context();
			c.Add(entity);
			c.SaveChanges();
		}

		public void Delete(T entity)
		{
			using var c = new Context();
			c.Remove(entity);
			c.SaveChanges();
		}

		public List<T> GetAll()
		{
			using var c=new Context();
			return c.Set<T>().ToList();
		}

		public List<T> GetAll(Expression<Func<T, bool>> filter)
		{
			using var c=new Context();
			return c.Set<T>().Where(filter).ToList();
		}

		public void Update(T entity)
		{
			using var c = new Context();
			c.Update(entity);
			c.SaveChanges();
		}
	}
}
