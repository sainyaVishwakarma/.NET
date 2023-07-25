using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace DAL;

public interface IDBManager
{
	void Delete(int v);
	List<Department> GetAll();
	void Insert(Department newDept);
	void Update(Department d);
}
