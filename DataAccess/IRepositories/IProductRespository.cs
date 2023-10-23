using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface IProductRespository
    {
        List<Product> GetProducts();
        void AddProduct(Product p);

        void UpdateProduct(Product p);

        void DeleteProduct(int id);

        Product GetProduct(int id);
    }
}
