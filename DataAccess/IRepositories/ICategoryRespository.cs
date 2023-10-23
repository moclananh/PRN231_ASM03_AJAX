using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepositories
{
    public interface ICategoryRespository
    {
        List<Category> GetAllCategories();
        Category GetCategoryByID(int CategoryId);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int CategoryId);
    }
}
