using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    sealed class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() :
            this("","",15.0M)
        {
        }

        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate, string phone = "TBD", string email = "TBD")
            :base(firstName,lastName, phone, email)
        {
            HourlyRate = hourlyRate;
        }
        //BC method was hidden, added override
        public override string PaySummary 
        {
            get 
            {
                return "This employee is payed " + HourlyRate + " per hour"; 
            }
        }

        public override decimal Pay(int start, int end)
        {
            decimal hours = 0;
            for(int day = start; day < end; ++day)
            {
                hours += Hours[day];
            }
            return hours * HourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
