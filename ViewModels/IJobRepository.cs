using System.Collections.Generic;
using Task_List_Dylan.Models;

namespace Task_List_Dylan.ViewModels
{
    public interface IJobRepository
    {
        IEnumerable<Job> GetJob();
        void Add(string title);
        void ChangeJobStatus(int id);
    }
}
