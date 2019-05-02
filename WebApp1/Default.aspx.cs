using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp1.CateService;
namespace WebApp1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryServiceClient svc = new CategoryServiceClient();
            Category category = svc.GetCategoryById("fx");
            string name = category.LongName;
            svc.Close();
        }

        protected void dvCategory_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            ddlCategories.DataBind();
        }

        protected void dvCategory_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            ddlCategories.DataBind();
        }

        protected void dvCategory_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            ddlCategories.DataBind();
        }
    }
}