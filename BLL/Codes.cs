using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class Codes
    {
        DAL.Codes dal = new DAL.Codes();
        /// <summary>
        /// 查询所有代码
        /// </summary>
        /// <returns>返回代码标题时间作者</returns>
        public DataSet SelectAllCodes()
        {
            DataSet ds = dal.SelectAllCodes();
            return ds;
        }
        /// <summary>
        /// 根据Id查询
        /// </summary>
        /// <returns>返回标题,代码,下载,时间,作者</returns>
        public DataSet SelectCode(int id)
        {
            return dal.SelectCode(id);
        }
        /// <summary>
        /// 添加代码
        /// </summary>
        /// <param name="codeinfo">代码信息</param>
        /// <returns>操作状态</returns>
        public bool InsertToCodes(Model.Codes codeinfo)
        {
            return dal.InsertToCodes(codeinfo);
        }
        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>操作状态</returns>
        public bool DeleteCode(int id)
        {
            return dal.DeleteCode(id);
        }
    }
}
