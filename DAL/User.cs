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
    public class User
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 根据用户名密码登录
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns>用户信息表</returns>
        public DataSet Userlogin(Model.User userinfo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                new SqlParameter("@Password",SqlDbType.NVarChar,50)};
            parameters[0].Value = userinfo.Username;
            parameters[1].Value = userinfo.Password;
            
            DataSet ds = DBHelper.SelectToDS("SelectUser", CommandType.StoredProcedure, parameters);
            return ds;
        }
        /// <summary>
        /// 查询用户名是否存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户名</returns>
        public bool SelectUserName(string UserName)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserName",SqlDbType.NVarChar,50)};
            parameters[0].Value = UserName;
            DataSet ds = DBHelper.SelectToDS("SelectUserName", CommandType.StoredProcedure, parameters);
            return Convert.ToBoolean(ds.Tables[0].Rows.Count);
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userinfo">用户信息</param>
        /// <returns>操作状态</returns>
        public bool InsertToUsers(Model.User userinfo)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@UserName",SqlDbType.NVarChar,50),
                new SqlParameter("@Password",SqlDbType.NVarChar,50),
                new SqlParameter("@IsAdmin",SqlDbType.Bit,1) };
            parameters[0].Value = userinfo.Username;
            parameters[1].Value = userinfo.Password;
            parameters[2].Value = userinfo.IsAdmin;
            return Convert.ToBoolean(DBHelper.ExecuteSql("InsertToUsers", CommandType.StoredProcedure, parameters));
        }
    }
}
