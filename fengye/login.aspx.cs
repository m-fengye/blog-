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
            if(!IsPostBack)
            {
                Model.User userinfo = new Model.User();
                if (Request.Cookies["UserInfo"] == null)
                    return;
                userinfo.Username = Request.Cookies["UserInfo"]["UserName"];
                userinfo.Password = Request.Cookies["UserInfo"]["Password"];
                Login(userinfo);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.User userinfo = new Model.User();
            if (txtUserName.Value == "")
            {
                Response.Write("<script>alert('请输入用户名')</script>");
                return;
            }
            if (txtPassword.Value == "")
            {
                Response.Write("<script>alert('请输入密码')</script>");
                return;
            }
            
            userinfo.Username = txtUserName.Value;
            userinfo.Password = MD5Encryption.MD5(txtPassword.Value);
            Login(userinfo);
            
        }
        /// <summary>
        /// 处理登录事件
        /// </summary>
        /// <param name="userinfo">用户信息</param>
        protected void Login(Model.User userinfo)
        {
            DataSet ds;
            try
            {
                ds = bll.SelectLogin(userinfo);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('系统错误')</script>");
                return;
            }
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Cookies["UserInfo"]["UserName"] = userinfo.Username;
                Response.Cookies["UserInfo"]["Password"] = userinfo.Password;
                if (chkRememberMe.Checked == true)
                {
                    Response.Cookies["UserInfo"].Expires = DateTime.Now.AddDays(1);
                }
                if (Convert.ToBoolean(ds.Tables[0].Rows[0][3]))
                {
                    Response.Redirect("backstage/index.aspx");
                }
                else
                {
                    Response.Redirect("onstage/index.aspx");
                }
            }
            else
            {
                Response.Write("<script>alert('账号或密码不正确')</script>");
            }
        }
    }
}