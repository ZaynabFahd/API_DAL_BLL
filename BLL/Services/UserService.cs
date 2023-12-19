using BLL.Interfaces;
using BLL.Mappers;
using BLL.Models.FormUser;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User? Create(CreateUserForm form)
        {
            User? user = _userRepository.GetByEmail(form.Email);

            if (user is null)
            {
                return _userRepository.Create(form.ToUser());
            }

            return null;
        }

        public bool Delete(int id)
        {
            User? user = _userRepository.GetById(id);

            if (user is not null)
            {
                return _userRepository.Delete(user);
            }

            return false;
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public bool Update(int id, UpdateUserForm form)
        {
            User? user = _userRepository.GetById(id);

            if (user is not null)
            {
                user.Password = form.Password;
                user.Name = form.Name;

                return _userRepository.Update(user);
            }

            return false;
        }
    }
}
