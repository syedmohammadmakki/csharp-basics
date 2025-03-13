using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
	public interface IProductRepository : IRepository<Category>
	{
		void Remove(Category obj);
		void Update(Category obj);
   
	}
}
