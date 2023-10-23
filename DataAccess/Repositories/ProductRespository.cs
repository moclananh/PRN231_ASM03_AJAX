﻿using BusinessObject.Models;
using DataAccess.DAOs;
using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ProductRespository : IProductRespository
    {
        public void AddProduct(Product p) => ProductDAO.Instance.AddProduct(p);


        public void DeleteProduct(int id) => ProductDAO.Instance.delete(id);


        public Product GetProduct(int id) => ProductDAO.Instance.GetProductByID(id);


        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();


        public void UpdateProduct(Product p) => ProductDAO.Instance.modify(p);
    }
}
