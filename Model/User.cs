﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        int id;
        string username;
        string password;
        bool isadmin;
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        /// <summary>
        /// 是否是管理员
        /// </summary>
        public bool IsAdmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }
    }
}
