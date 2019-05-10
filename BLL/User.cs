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
        public DataSet SelectLogin(Model.User userinfo)
        {
            DataSet ds = dal.Userlogin(userinfo);
            return ds;
        }
    }
}
