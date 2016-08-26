using MVCFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFilters.Providers
{
    public interface IUserProvider
    {
        User AddUser(User user);

        User GetUserById(int id);

        User RemoveUser(int id);
    }
}