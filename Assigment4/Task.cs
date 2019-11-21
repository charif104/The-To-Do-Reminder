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

       public Task(DateTime taskDate)
        {
            DefaultValues();
            this.date = taskDate;
          
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

       public string MinueAndSecondString
        {
            get
            {
                return date.Minute.ToString("00") + date.Second.ToString("00");
            }
        }

        public override string ToString()
        {
            string textOut = String.Format("{0, -20} {1,10} {2, -16  {3, -20", 
                date.ToLongDateString(),GetTimeString(), GetPriorityString(), Description );
            return textOut;
        }

        private string GetPriorityString()
        {
            return priority.ToString().Replace('_', ' ');
        }

        private string GetTimeString()
        {
            return date.Hour.ToString()+ date.Minute.ToString();
        }
    }
   
}
