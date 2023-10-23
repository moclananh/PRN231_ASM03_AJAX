using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IOrderRespository
    {
        List<Order> GetOrders();

        void DeleteOrder(int idO);

        Order GetOrder(int id);

        void UpdateOrder(Order o);

        void AddOrder(Order order);
    }
}
