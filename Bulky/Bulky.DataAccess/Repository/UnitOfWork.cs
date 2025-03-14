﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		public IProductRepository Category { get; private set; }
		public UnitOfWork(ApplicationDbContext db) 
		{
			_db = db;
			Category = new CategoryRepository(_db);
		}
		public void Save()
		{
			_db.SaveChanges();
		}
	}
	
	
}
