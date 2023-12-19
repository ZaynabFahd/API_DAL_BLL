using BLL.Models.FormUser;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();

        User? Create(CreateUserForm form);

        User? GetById(int id);

        bool Update(int id, UpdateUserForm form);

        bool Delete(int id);
    }
}
