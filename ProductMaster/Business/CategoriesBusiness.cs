using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMaster.Entities;
using ProductMaster.Database;

namespace ProductMaster.Business
{
    public class CategoriesBusiness
    {
        DataBaseAccess _dbAccess;
        public CategoriesBusiness()
        {
            _dbAccess = new DataBaseAccess();
        }

        public List<Categories> GetCategories()
        {
            return _dbAccess.CategoriesDbSet.ToList();
        }

        public Categories GetCategoryByName(string CategoryName)
        {
            return _dbAccess.CategoriesDbSet.Where(c => c.CategoryName == CategoryName).FirstOrDefault();
        }

        public int AddCategory(string CategoryName, string CategoryDescription = null)
        {
            var objCategory = new Categories()
            {
                CategoryName = CategoryName,
                CategoryDescription = CategoryDescription
            };
            _dbAccess.CategoriesDbSet.Add(objCategory);
            return _dbAccess.SaveChanges();
        }

        public int DeteleCategory(int Id, string CategoryName)
        {
            var category = new Categories { Id = Id, CategoryName = CategoryName };
            _dbAccess.CategoriesDbSet.Attach(category);
            _dbAccess.CategoriesDbSet.Remove(category);
            return _dbAccess.SaveChanges();
        }
    }
}
