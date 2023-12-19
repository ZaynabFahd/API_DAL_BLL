using BLL.Models.FormUser;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this CreateUserForm form)
        {
            return new User()
            {
                Id = 0,
                Email = form.Email,
                Name = form.Name,
                Password = form.Password
            };
        }
    }
}
