using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_List_Dylan.Models;

namespace Task_List_Dylan.ViewModels
{
    public interface IAccauntRepository
    {
        IEnumerable<User> GetAccaunts();
        void AddAccaunt(string login, string password);
        bool IsValid(User user);
    }
}
