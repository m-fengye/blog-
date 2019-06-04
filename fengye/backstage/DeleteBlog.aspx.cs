﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fengye.backstage
{
    public partial class DeleteBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserInfo"] == null)
                {
                    Response.Redirect("../login.aspx");
                }
                if (Request["Id"] != null)
                {
                    BLL.Blogs bll = new BLL.Blogs();
                    bll.DeleteBlog(Convert.ToInt32(Request["Id"]));
                    Response.Redirect("ManagerBlog.aspx");
                }
            }
        }
    }
}