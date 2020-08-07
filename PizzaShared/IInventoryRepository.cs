using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaShared
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetAll();
      
    }
}
