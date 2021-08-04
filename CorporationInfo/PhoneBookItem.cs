using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    //BC added abstract to class due to GetContactSummary() being abstract
    abstract class PhoneBookItem
    {
        //BC added abstract to function
        public abstract string GetContactSummary();
    }
}
