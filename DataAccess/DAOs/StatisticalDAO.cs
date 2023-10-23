using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class StatisticalDAO
    {
        private static StatisticalDAO instance = null;
        public static readonly object instanceLock = new object();
        public static StatisticalDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StatisticalDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> Statistical(DateTime startDate, DateTime endDate)
        {
            var ods = new List<Order>();
            try
            {
                using var context = new PRN231_ASM03_AJAXContext();

                // Truy vấn danh sách các đơn hàng trong khoảng thời gian đã cho
                ods = context.Orders
                    .Where(order => order.OrderDate >= startDate && order.OrderDate <= endDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return ods;
        }

    }
}
