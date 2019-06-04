using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Codes
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 查询所有代码
        /// </summary>
        /// <returns>返回代码标题时间作者</returns>
        public DataSet SelectAllCodes()
        {
            
            DataSet ds = DBHelper.SelectToDS("SelectAllCodes", CommandType.StoredProcedure);
            return ds;
        }
        /// <summary>
        /// 根据Id查询
        /// </summary>
        /// <returns>返回标题,代码,下载,时间,作者</returns>
        public DataSet SelectCode(int id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int) };
            parameters[0].Value = id;
            DataSet ds = DBHelper.SelectToDS("SelectCode", CommandType.StoredProcedure,parameters);
            return ds;
        }
        /// <summary>
        /// 添加代码
        /// </summary>
        /// <param name="codeinfo">代码信息</param>
        /// <returns>操作状态</returns>
        public bool InsertToCodes(Model.Codes codeinfo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Title",SqlDbType.NVarChar,150),
                new SqlParameter("@Code",SqlDbType.NVarChar,-1),
                new SqlParameter("@Download",SqlDbType.NVarChar,50),
                new SqlParameter("@Time",SqlDbType.DateTime),
                new SqlParameter("@Author",SqlDbType.NVarChar,50)};
            parameters[0].Value = codeinfo.Title;
            parameters[1].Value = codeinfo.Code;
            parameters[2].Value = codeinfo.Download;
            parameters[3].Value = codeinfo.Time;
            parameters[4].Value = codeinfo.Author;
            return Convert.ToBoolean(DBHelper.ExecuteSql("InsertToCodes", CommandType.StoredProcedure, parameters));
        }
        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns>操作状态</returns>
        public bool DeleteCode(int id)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Id",SqlDbType.Int) };
            parameters[0].Value = id;
            return Convert.ToBoolean(DBHelper.ExecuteSql("DeleteCode", CommandType.StoredProcedure, parameters));
        }
    }
}
