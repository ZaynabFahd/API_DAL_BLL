﻿using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User? Create(User user)
        {
            user.Id = FakeDB.Users.Max(x => x.Id) + 1;

            FakeDB.Users.Add(user);

            return user;
        }

        public bool Delete(User elem)
        {
            FakeDB.Users.Remove(elem);
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return FakeDB.Users;
        }

        public User? GetByEmail(string email)
        {
            return FakeDB.Users.SingleOrDefault(x => x.Email == email);
        }

        public User? GetById(int id)
        {
            return FakeDB.Users.SingleOrDefault(x => x.Id == id);
        }

        public bool Update(User user)
        {
            int index = FakeDB.Users.FindIndex(x => x.Id == user.Id);

            FakeDB.Users[index] = user;

            return true;
        }
    }
}
