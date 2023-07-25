// See https://aka.ms/new-console-template for more information
using BOL;
using DAL;
using Microsoft.Extensions.DependencyInjection;



Console.WriteLine("Welcome to Test ORM");

IDBManager dbm = new DBManager();
bool status = true;
while (status)
{
	Console.WriteLine("Choose option: ");
	Console.WriteLine("1. Display records");
	Console.WriteLine("2. Insert new record");
	Console.WriteLine("3. Update existing record");
	Console.WriteLine("4. Delete existing record");
	Console.WriteLine("5. Exit");

	switch (int.Parse(Console.ReadLine()))
		{
		case 1:
			List<Department> dlist = dbm.GetAll();
			foreach (var dept in dlist)
			{
				Console.WriteLine(" Id: {0}, Name: {1}, Location: {2}",
									dept.Id, dept.Name, dept.Location);
			}
			break;

		case 2:
			Department newDept = new Department()
			{
				Id = 23,
				Name = "Research",
				Location = "Chennai"

			};
			dbm.Insert(newDept);
			break;
		case 3:
			Department d = new Department() { Id=23, Name="Sales" , Location="Delhi"};
			dbm.Update(d);
			break;
		case 4:
			dbm.Delete(23);
			break;
		case 5:
			status = false;
			Console.WriteLine("Thankyou for visiting");
			break;
		default:
			Console.WriteLine("Wrong choice");
			break;
	}

	}		
	


