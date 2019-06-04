using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;

namespace BLL
{
    public class User
    {
        DAL.User dal = new DAL.User();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userinfo">用户信息</param>
        /// <returns>登录状态</returns>
        public DataSet SelectLogin(Model.User userinfo)
        {
            DataSet ds = dal.Userlogin(userinfo);
            return ds;
        }
        /// <summary>
        /// 查询用户名是否存在
        /// </summary>
        /// <param name="UserName">用户名</param>
        /// <returns>用户名</returns>
        public bool SelectUserName(string UserName)
        {
            return dal.SelectUserName(UserName);
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userinfo">用户信息</param>
        /// <returns>操作状态</returns>
        public bool InsertToUsers(Model.User userinfo)
        {
            return dal.InsertToUsers(userinfo);
        }
    }
}
