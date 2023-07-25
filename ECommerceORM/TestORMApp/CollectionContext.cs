using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using Microsoft.EntityFrameworkCore;
/*using Microsoft.Extensions.Configuration*/

namespace DAL
{
	public class CollectionContext:DbContext
	{
		

		public DbSet<Department> Departments { get; set; }

	

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string conString = @"server=192.168.10.150;port=3306;user=dac21;password=welcome;database=dac21_campus";
			//optionsBuilder.UseMySQL(conString);
			optionsBuilder.UseMySQL(conString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Department>(entity =>
			{
				entity.HasKey(entity => entity.Id);
				entity.Property(e => e.Name).IsRequired();
				entity.Property(e => e.Location).IsRequired();
			});
			modelBuilder.Entity<Department>().ToTable("departments");

		}
	}
}
