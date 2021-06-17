using BlazorCrud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.IRepository
{
    public interface IItemRepository
    {
        public Employee Save(Employee oItem);

        public Employee Update(Employee oItem);


        public Employee Get(int itemId);


        public List<Employee> Gets();


        public string Delete(int itemId);
    }
}
