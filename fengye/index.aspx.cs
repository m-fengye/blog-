using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace fengye
{
    public partial class index : System.Web.UI.Page
    {
        BLL.Blogs bll = new BLL.Blogs();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = bll.SelectAllBlogs();

                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    Control c = ParseControl(@"<div class='grid-item'>
                                                <a href = 'BlogContent.aspx?Id="+dr["Id"]+@"'>
                                                    <img src='"+dr["Layout"]+ @"' title='" + dr["Title"] + @"' class='img-fluid tm-img'>
                                                    <p class='p1' title='" + dr["Title"] + @"'>"+dr["Title"]+@"</p>
                                                </a>
                                             </div>");
                    PlaceHolder3.Controls.Add(c);
                }
                
                
            }
        }
    }
}