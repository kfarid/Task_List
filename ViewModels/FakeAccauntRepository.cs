using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_List_Dylan.Models;

namespace Task_List_Dylan.ViewModels
{
    public class FakeAccauntRepository : IAccauntRepository
    {
        private IEnumerable<User> UserList = new List<User>
        {
            new User{Login="admin",Password="admin"}
        };

        public void AddAccaunt(string login, string password)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAccaunts()
        {
            return this.UserList;
        }

        public bool IsValid(User user)
        {
            if (user.Password == "admin" && user.Password == "admin")
                return true;
            else
                return false;
        }
    }
}
