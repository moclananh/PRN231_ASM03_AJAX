﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IStatisticalRespository
    {
        List<Order> GetStatisticalByDate(DateTime startDate, DateTime endDate);
    }
}
