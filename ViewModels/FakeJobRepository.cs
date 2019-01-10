using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_List_Dylan.Models;

namespace Task_List_Dylan.ViewModels
{
    public class FakeJobRepository:IJobRepository
    {

        List<Job> jobs = new List<Job> { new Job{Id=0,Name="Проснуться",Status=true},
                                                       new Job{Id=1,Name="Умыться"},
                                                       new Job{Id=2,Name="Одеться"},
                                                       new Job{Id=3,Name="Позавтракать"},
                                                       new Job{Id=4,Name="Пойти на работу",Status=true}
        };



        public IEnumerable<Job> GetJob()
        {
            return jobs;
        }

        public void Add(string title) 
        {
            var custom = new Job
            {
                Id = jobs.Last().Id + 1,
                Name = title
            };
            jobs.Add(custom);
        }

        public void ChangeJobStatus(int JobId)
        {
            var test = jobs.FirstOrDefault(x => x.Id == JobId);
            if (test.Status)
                test.Status = false;
            else
                test.Status = true;

        }
    }
}
