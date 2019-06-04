using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fengye
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Model.User userinfo = new Model.User();
            if (txtUserName.Value == "")
            {
                Response.Write("<script>alert('请输入用户名')</script>");
                return;
            }
            userinfo.Username = txtUserName.Value;
            if (txtPassword.Value == "")
            {
                Response.Write("<script>alert('请输入密码')</script>");
                return;
            }
            userinfo.Password = BLL.MD5Encryption.MD5(txtPassword.Value);
            if (!chkReadMe.Checked)
            {
                Response.Write("<script>alert('请同意协议')</script>");
                return;
            }
            userinfo.IsAdmin = false;
            BLL.User bll = new BLL.User();
            if (!bll.SelectUserName(userinfo.Username))
            {
                if (bll.InsertToUsers(userinfo))
                {
                    Response.Write("<script>alert('注册成功');window.location.href='Login.aspx'</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名已使用');</script>");
            }
            
        }
    }
}