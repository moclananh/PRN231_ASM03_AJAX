using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        public static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Product> GetProducts()
        {
            var prs = new List<Product>();
            try
            {
                using var context = new PRN231_ASM03_AJAXContext();
                prs = context.Products.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prs;
        }
        public Product GetProductByID(int id)
        {
            Product pr = null;
            try
            {
                using var context = new PRN231_ASM03_AJAXContext();
                pr = context.Products.SingleOrDefault(m => m.ProductId == id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pr;
        }
        public void AddProduct(Product p)
        {
            try
            {
                Product _p = GetProductByID(p.ProductId);
                if (_p == null)
                {
                    using var context = new PRN231_ASM03_AJAXContext();
                    context.Products.Add(p);
                    context.SaveChanges();
                }
                else throw new Exception("Product is exist!");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void modify(Product p)
        {
            try
            {
                Product _p = GetProductByID(p.ProductId);
                if (_p != null)
                {
                    using var context = new PRN231_ASM03_AJAXContext();
                    context.Products.Update(p);
                    context.SaveChanges();
                }
                else throw new Exception("Product is not exist!");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(int id)
        {
            try
            {
                Product _p = GetProductByID(id);
                if (_p != null)
                {
                    using var context = new PRN231_ASM03_AJAXContext();
                    context.Products.Remove(_p);
                    context.SaveChanges();
                }
                else throw new Exception("Product is not exist!");
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
