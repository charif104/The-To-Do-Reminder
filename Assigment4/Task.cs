using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4
{
 public  class Task
    {
        private DateTime date;
        private String description;
        private PriorityTypes priority;

        public Task(DateTime date, string description, PriorityTypes priority)
        {
            this.date = date;
            this.description = description;
            this.priority = priority;
            DefaultValues();
        }
       public Task(DateTime taskDate)
        {
            this.date = taskDate;
            DefaultValues();
        }

        public Task()
        {
            DefaultValues();
        }

        private void DefaultValues()
        {
            date = DateTime.Now;
            description = "string.empty";
            priority = PriorityTypes.Normal;

        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if(!string.IsNullOrEmpty(value))
                description = value;
            }
        }

        public PriorityTypes Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }
    }
}
