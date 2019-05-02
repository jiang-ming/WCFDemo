using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace testWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICategoryService" in both code and config file together.
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetCategories();

        [OperationContract]
        Category GetCategoryById(string id);

        [OperationContract]
        int InsertCategory(Category c);

        [OperationContract]
        int UpdateCategory(Category c);

        [OperationContract]
        int DeleteCategory(Category c);
    }
    [DataContract]
    public class Category
    {
        [DataMember]
        public string CategoryID { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public string LongName { get; set; }
    }
}
