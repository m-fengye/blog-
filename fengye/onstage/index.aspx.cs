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
        BLL.Blogs bllb = new BLL.Blogs();
        BLL.Codes bllc = new BLL.Codes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserInfo"] == null)
                {
                    Response.Redirect("../login.aspx");
                }
                lblUserName.Text = "Welcome," + Request.Cookies["UserInfo"]["UserName"];
                DataSet dsb = bllb.SelectAllBlogs();
                foreach(DataRow dr in dsb.Tables[0].Rows)
                {
                    Control c = ParseControl(@"<div class='grid-item'>
                                                <a href='blogContent.aspx?Id="+dr["Id"]+@"' target='_blank'>
                                                    <img src='"+dr["Layout"]+ @"' title='" + dr["Title"] + @"' style='height:180px' class='img-fluid tm-img'>
                                                    <p class='p1' title='" + dr["Title"] + @"'>"+dr["Title"]+@"</p>
                                                </a>
                                             </div>");
                    PlaceHolder3.Controls.Add(c);
                }
                DataSet dsc = bllc.SelectAllCodes();
                foreach (DataRow dr in dsc.Tables[0].Rows)
                {
                    Control c = ParseControl(@"<p class='p2'>
                                                        <a href='codeContent.aspx?Id=" + dr["Id"]+ "' target='_blank'><span>"+ dr["Title"]+ @"</span></a>
                                                        <span class='author'>" + dr["Author"] + @"</span>
                                                        <span class='datetime'>" + dr["Time"] + @"</span>
                                                    </p><hr style='height:1px;border:none;border-top:1px solid #555555;width:93%'/>");
                    PlaceHolder4.Controls.Add(c);
                }

            }
        }
    }
}