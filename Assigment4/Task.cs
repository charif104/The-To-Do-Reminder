using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment4
{
    public class Task
    {
        private DateTime date;
        private string description;
        private PriorityTypes priority;

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
                if (!string.IsNullOrEmpty(value))
                    description = value;
            }
        }

     public string MinueAndSecondString
        {
            get
            {
                return date.Minute.ToString("00") + date.Second.ToString("00");
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

        public DateTime TaskDate
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

      

       private void DefaultValues()
        {
            date = DateTime.Now;
            description = "string.empty";
            priority = PriorityTypes.Normal;

        }

      private string GetPriorityString()
        {
            return priority.ToString().Replace('_', ' ');
        }
      private string GetTimeString()
        {
            return date.Hour.ToString() + date.Minute.ToString();
        }
      public Task()
        {
            DefaultValues();
        }
      public Task(DateTime taskDate)
        {
            DefaultValues();
            this.date = taskDate;

        }

     public override string ToString()
        {
            string textOut = String.Format("{0, -20} {1,-10} {2, -10}  {3, -20 }",
                date.ToLongDateString(), GetTimeString(), GetPriorityString(), description);
            // string textOut = String.Format("{0, -20} {1,10} {2, -16  {3, -20",
            //    date.ToLongDateString(), GetTimeString(), GetPriorityString(), description);
            return textOut;
        }

    }
}
