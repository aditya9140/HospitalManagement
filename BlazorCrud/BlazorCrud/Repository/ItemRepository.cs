using BlazorCrud.Data;
using BlazorCrud.DBContext;
using BlazorCrud.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Repository
{
    public class ItemRepository : IItemRepository
    {
        ContextDB _contextDB;

        public ItemRepository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }
        public string Delete(int itemId)
        {
            var item = _contextDB.Employees.FirstOrDefault(x => x.EmployeeId == itemId);
            _contextDB.Employees.Remove(item);
            _contextDB.SaveChanges();
            return "Deleted";
        }

        public Employee Get(int itemId)
        {
            return _contextDB.Employees.FirstOrDefault(x => x.EmployeeId == itemId);
        }

        public List<Employee> Gets()
        {
            return _contextDB.Employees.ToList();
        }

        public Employee Save(Employee oItem)
        {
            _contextDB.Employees.Add(oItem);
            _contextDB.SaveChanges();
            return this.Get(oItem.EmployeeId);
        }

        

        public Employee Update(Employee oItem)
        {
            _contextDB.Employees.Update(oItem);
            _contextDB.SaveChanges();
            return this.Get(oItem.EmployeeId);
        }

     
    }
}
