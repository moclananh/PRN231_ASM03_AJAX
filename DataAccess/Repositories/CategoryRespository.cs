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
    public class CategoryRespository : ICategoryRespository
    {
        public void Delete(int CategoryId) => CategoryDAO.Instance.Delete(CategoryId);

        public List<Category> GetAllCategories() => CategoryDAO.Instance.GetListCategories();
        public Category GetCategoryByID(int CategoryId) => CategoryDAO.Instance.GetCategoryByID(CategoryId);

        public void Insert(Category category) => CategoryDAO.Instance.Insert(category);

        public void Update(Category category) => CategoryDAO.Instance.Update(category);
    }
}
