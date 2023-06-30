using OrderManagement.Models.Context;
using OrderManagement.Models.Models;
using OrderManagement.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Repository.Services
{
    public class UserServices : IUser
    {
        OrderManagementEntities db = new OrderManagementEntities();
        public string Login(UserModel user)
        {
            try
            {
                Users DbUser = db.Users.Where(x => x.email.Equals(user.email)).FirstOrDefault();
                if (DbUser != null)
                {
                    if (DbUser.password.Equals(user.password))
                    {
                        return Convert.ToString(DbUser.id);
                    }
                    else
                    {
                        return "Invalid Password";
                    }
                }
                return "Invalid Email";
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
