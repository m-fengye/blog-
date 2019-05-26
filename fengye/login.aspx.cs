using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BLL;

namespace fengye
{
    public partial class login : System.Web.UI.Page
    {
        BLL.User bll = new BLL.User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.User userinfo = new Model.User();
            if (txtUserName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "js", "initMessagebox('请输入账号');", true);
                return;
            }
            if (txtPassword.Text == "")
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "js", "initMessagebox('请输入密码');", true);
                return;
            }
            
            userinfo.Username = txtUserName.Text;
            userinfo.Password = txtPassword.Text;
            DataSet ds;
            try
            {
                 ds = bll.SelectLogin(userinfo);
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "js", "initMessagebox('系统错误');", true);
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToBoolean(ds.Tables[0].Rows[0][3]))
                {
                    Response.Redirect("manager.aspx");
                }
                else
                {
                    Response.Redirect("index.aspx");
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "js", "initMessagebox('账号或密码不正确');", true);
            }
        }
    }
}