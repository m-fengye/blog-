using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Blogs
    {
        DAL.Blogs dal = new DAL.Blogs();
        /// <summary>
        /// 查询所有博客
        /// </summary>
        /// <returns>返回博客配图标题</returns>
        public DataSet SelectAllBlogs()
        {
            DataSet ds = dal.SelectAllBolgs();
            return ds;
        }
        /// <summary>
        /// 查询博客
        /// </summary>
        /// <returns>返回博客标题内容时间作者</returns>
        public DataSet SelectBlog(int id)
        {
            DataSet ds = dal.SelectBlog(id);
            return ds;
        }
        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="">博客信息</param>
        /// <returns>是否添加成功</returns>
        public bool InsertToBlogs(Model.Blogs bloginfo)
        {
            return dal.InsertToBlogs(bloginfo);
        }
        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>是否删除成功</returns>
        public bool DeleteBlog(int id)
        {
            return dal.DeleteBlog(id);
        }
    }
}
