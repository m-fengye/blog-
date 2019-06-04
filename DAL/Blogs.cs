using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class Blogs
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 查询所有博客
        /// </summary>
        /// <returns>返回博客配图标题</returns>
        public DataSet SelectAllBolgs()
        {
            DataSet ds = DBHelper.SelectToDS("SelectAllBlogs", CommandType.StoredProcedure);
            return ds;
        }
        /// <summary>
        /// 查询博客
        /// </summary>
        /// <returns>返回博客标题内容时间作者</returns>
        public DataSet SelectBlog(int id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int) };
            parameters[0].Value = id;
            DataSet ds = DBHelper.SelectToDS("SelectBlog", CommandType.StoredProcedure, parameters);
            return ds;
        }
        /// <summary>
        /// 添加博客
        /// </summary>
        /// <param name="">博客信息</param>
        /// <returns>是否添加成功</returns>
        public bool InsertToBlogs(Model.Blogs bloginfo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Title",SqlDbType.NVarChar,150),
                new SqlParameter("@BlogContent",SqlDbType.NVarChar,-1),
                new SqlParameter("@BlogTime",SqlDbType.DateTime),
                new SqlParameter("@Author",SqlDbType.NVarChar,50),
                new SqlParameter("@Layout",SqlDbType.NVarChar,100)};
            parameters[0].Value = bloginfo.Title;
            parameters[1].Value = bloginfo.BlogContent;
            parameters[2].Value = bloginfo.BlogTime;
            parameters[3].Value = bloginfo.Author;
            parameters[4].Value = bloginfo.Layout;
            return Convert.ToBoolean(DBHelper.ExecuteSql("InsertToBlogs", CommandType.StoredProcedure, parameters));
            
        }
        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>是否删除成功</returns>
        public bool DeleteBlog(int id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int) };
            parameters[0].Value = id;
            return Convert.ToBoolean(DBHelper.ExecuteSql("DeleteBlog", CommandType.StoredProcedure, parameters));
        }
    }
}
