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
        /// <summary>
        /// 查询所有博客
        /// </summary>
        /// <returns>返回博客配图标题</returns>
        public DataSet SelectAllBolgs()
        {
            DBHelper db = new DBHelper();
            DataSet ds = DBHelper.SelectToDS("SelectAllBlogs", CommandType.StoredProcedure);
            return ds;
        }
    }
}
