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
    }
}
