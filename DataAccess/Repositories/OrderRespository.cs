using BusinessObject.Models;
using DataAccess.DAOs;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderRespository : IOrderRespository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);


        public void DeleteOrder(int idO) => OrderDAO.Instance.Delete(idO);


        public Order GetOrder(int id) => OrderDAO.Instance.GetOrderByID(id);


        public List<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public void UpdateOrder(Order o) => OrderDAO.Instance.Modify(o);
    }
}
