using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BOL;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	public class DBManager : IDBManager
	{
		public void Delete(int v)
		{
			using(var context=new CollectionContext())
			{
				context.Departments.Remove(context.Departments.Find(v));
				context.SaveChanges();
			}
		}

		public List<Department> GetAll()
		{
			using(var context=new CollectionContext())
			{
				var departments = from dept in context.Departments 
								  select dept;
				return departments.ToList<Department>();
			}
		}

		public void Insert(Department newDept)
		{
			using (var context = new CollectionContext())
			{
				context.Departments.Add(newDept);
				context.SaveChanges();
			}
		}

		public void Update(Department d)
		{
			using(var context=new CollectionContext())
			{
				Department dd=context.Departments.Find(d.Id);
				dd.Name=d.Name;
				dd.Location=d.Location;
				context.SaveChanges();
			}
		}
	}
}
