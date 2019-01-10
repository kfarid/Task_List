using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_List_Dylan.Models
{
    public class Job
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = false;

        public string GetStringOfStatus()
        {
            return this.Status ? "Выполнено" : "В процессе";
        }
    }
}
