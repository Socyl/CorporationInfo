using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    sealed class PhoneBook
    {
        public List<PhoneBookItem> PhoneBookEntries { get; set; }

        public PhoneBook()
        {
            PhoneBookEntries = new List<PhoneBookItem>();
        }
        public string GetPhoneBook()
        {
            string phonebook = "";

            //BC elements of PhoneBookEntries list are PhoneBookItems, not strings
            foreach (PhoneBookItem item in PhoneBookEntries)
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }

    }
}
