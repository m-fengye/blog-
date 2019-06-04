using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Data;

namespace fengye.backstage
{
    public partial class EditCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserInfo"] == null)
                {
                    Response.Redirect("../login.aspx");
                }
                txtEditor.Text = "<p style='text-align:center;'><span style='font-size:20px;'>添加代码时请先选择代码语言(请先删除再编辑)</span><br/></p>";
                if (Request["Id"] != null)
                {
                    BLL.Codes bll = new BLL.Codes();
                    DataSet ds = bll.SelectCode(Convert.ToInt32(Request["Id"]));
                    txtEditor.Text = ds.Tables[0].Rows[0]["Code"].ToString();
                    txtTitle.Value = ds.Tables[0].Rows[0]["Title"].ToString();
                    bll.DeleteCode(Convert.ToInt32(Request["Id"]));
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Codes codeinfo = new Codes();
            codeinfo.Author = Request.Cookies["UserInfo"]["UserName"];
            if (txtEditor.Text == "")
            {
                Response.Write("<script>alert('请输入代码内容')</script>");
                return;
            }
            codeinfo.Code = txtEditor.Text;
            codeinfo.Time = DateTime.Now;
            codeinfo.Download = "";
            if (txtTitle.Value == "")
            {
                Response.Write("<script>alert('请输入代码标题')</script>");
                return;
            }
            codeinfo.Title = txtTitle.Value;
            try
            {
                BLL.Codes bll = new BLL.Codes();
                if (bll.InsertToCodes(codeinfo))
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