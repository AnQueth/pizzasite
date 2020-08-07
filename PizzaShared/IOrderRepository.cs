using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShared
{
    public interface IOrderRepository
    {
        Task Add(Order order);
    }
}
