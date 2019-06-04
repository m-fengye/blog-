using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Text.RegularExpressions;
using System.Data;

namespace fengye.backstage
{
    public partial class EditBlog : System.Web.UI.Page
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
                    DataSet ds = bll.SelectBlog(Convert.ToInt32(Request["Id"]));
                    txtEditor.Text = ds.Tables[0].Rows[0]["BlogContent"].ToString();
                    txtTitle.Value = ds.Tables[0].Rows[0]["Title"].ToString();
                    bll.DeleteBlog(Convert.ToInt32(Request["Id"]));
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Blogs bloginfo = new Blogs();
            Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);
            bloginfo.Author = Request.Cookies["UserInfo"]["UserName"];
            if(txtEditor.Text=="")
            {
                Response.Write("<script>alert('请输入博客内容')</script>");
                return;
            }
            bloginfo.BlogContent = txtEditor.Text;
            bloginfo.BlogTime = DateTime.Now;
            bloginfo.Layout = "/backstage/ueditorUTF8/net/upload/image/default.png";
            Match match = regImg.Match(bloginfo.BlogContent);
            if (match.Value != "")
                bloginfo.Layout = match.Groups["imgUrl"].Value;
            if (txtTitle.Value == "")
            {
                Response.Write("<script>alert('请输入博客标题')</script>");
                return;
            }
            bloginfo.Title = txtTitle.Value;
            try
            {
                BLL.Blogs bll = new BLL.Blogs();
                if (bll.InsertToBlogs(bloginfo))
                {
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('添加失败')</script>");
            }
        }
    }
}