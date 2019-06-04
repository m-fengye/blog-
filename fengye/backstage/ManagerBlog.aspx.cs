using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace fengye.backstage
{
    public partial class ManagerBlog : System.Web.UI.Page
    {
        BLL.Blogs bllb = new BLL.Blogs();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserInfo"] == null)
                {
                    Response.Redirect("../login.aspx");
                }
                DataSet dsb = bllb.SelectAllBlogs();
                foreach (DataRow dr in dsb.Tables[0].Rows)
                {
                    Control c = ParseControl(@"<tr class='service'>
                                                <td class='tableitem'>
                                                    <p class='itemtext'>"+dr["Title"]+@"</p>
                                                </td>
                                                <td class='tableitem'>
                                                    <p class='itemtext'>"+dr["BlogTime"]+@"</p>
                                                </td>
                                                <td class='tableitem'>
                                                    <p class='itemtext'>"+dr["Author"]+ @"</p>
                                                </td>
                                                <td class='tableitem'>
                                                    <p class='itemtext'><a href='EditBlog.aspx?Id=" + dr["Id"] + @"'>Edit</a>&emsp;<a href='DeleteBlog.aspx?Id=" + dr["Id"]+@"'>Delete</a></p>
                                                </td>
                                            </tr>");
                    Panel1.Controls.Add(c);
                }
            }
        }
    }
}