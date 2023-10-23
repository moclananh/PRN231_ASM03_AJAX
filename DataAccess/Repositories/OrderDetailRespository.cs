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
    public class OrderDetailRespository : IOrderDetailRespository
    {
        public void AddOD(OrderDetail o) => OrderDetailDAO.Instance.AddOderDetail(o);


        public void DeleteOD(int idO, int idP) => OrderDetailDAO.Instance.Delete(idO, idP);


        public OrderDetail GetOrderDetail(int idO, int idP) => OrderDetailDAO.Instance.GetOrderDetail(idO, idP);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrders();

        public void UpdateOD(OrderDetail o) => OrderDetailDAO.Instance.Modify(o);
    }
}
