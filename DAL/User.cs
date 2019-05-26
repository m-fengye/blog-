﻿using System;
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
            DBHelper db = new DBHelper();
            DataSet ds = DBHelper.SelectToDS("SelectUser", CommandType.StoredProcedure, parameters);
            return ds;
        }
    }
}
