using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Batch31.Data;

namespace Batch31.Web
{
    public partial class Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            GridView1.DataSource = data.GetBooks().ToList();
            GridView1.DataBind();
        }
    }
}