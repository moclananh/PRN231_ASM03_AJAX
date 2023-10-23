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
    public class StatisticalRespository : IStatisticalRespository
    {
        public List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate)
            => StatisticalDAO.Instance.Statistical(startDate, endDate);
    }
}
