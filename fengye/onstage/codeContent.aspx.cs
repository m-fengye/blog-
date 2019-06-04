using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace fengye
{
    public partial class codeContent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["Id"]);
            BLL.Codes bll = new BLL.Codes();
            DataSet ds = bll.SelectCode(id);
            Page.Title = ds.Tables[0].Rows[0]["Title"].ToString();
            Control c = ParseControl(ds.Tables[0].Rows[0]["Code"].ToString());
            PlaceHolder1.Controls.Add(c);
        }
    }
}