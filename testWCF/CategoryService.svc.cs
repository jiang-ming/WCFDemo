using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace testWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CategoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CategoryService.svc or CategoryService.svc.cs at the Solution Explorer and start debugging.
    public class CategoryService : ICategoryService
    {
        private CategoryDB data;
        
        public CategoryService()
        {
            data = new CategoryDB();
        }
        public List<Category> GetCategories()
        {
            return data.GetCategories();
        }
        public Category GetCategoryById(string id)
        {
            return data.GetCategoryById(id);
        }
        public int InsertCategory(Category c)
        {
            try
            {
                return data.InsertCategory(c);
            }
            catch
            {
                return -1;
            }
        }
        public int UpdateCategory(Category c)
        {
            return data.UpdateCategory(c);
        }

        public int DeleteCategory(Category c)
        {
            return data.DeleteCategory(c);
        }
    }
}
