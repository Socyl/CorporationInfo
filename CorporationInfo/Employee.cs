using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{    
    abstract class Employee : PhoneBookItem 
    {
        private static int LastEmpNum = 0;
        public int EmpNum { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<decimal> hours = new List<decimal>();

        public List<decimal> Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Employee(string firstName, string lastName, string phone = "TBD", string email = "TBD")
        {
            FirstName = firstName;
            LastName = lastName;
            EmpNum = LastEmpNum++;
            Phone = phone;
            Email = email;
        }

        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

        public abstract decimal Pay(int start, int end);

        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

        public string Phone { get; set; }

        public string Email { get; set; }
        //BC GetContactSummary() is hidden.  adding override so it implements GetContactSummary() abstract from PhoneBookItem
        public override string GetContactSummary()
        {
            return FirstName + " " + LastName + "\n" +
                   "Phone: " + Phone + "\n" +
                   "Email: " + Email;
        }
    }
}
