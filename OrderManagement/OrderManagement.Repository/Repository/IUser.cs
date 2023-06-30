using OrderManagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Repository.Repository
{
    public interface IUser
    {
        string Login(UserModel user);
    }
}
