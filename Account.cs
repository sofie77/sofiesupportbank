using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportbank
{
    class Account
    {
        // so get;set to get the information from the program and then 
        public string Name;
        public decimal Balance;

        public Account (string name)
        {
            this.Name = name;
            // a bit redundant
            this.Balance = 0;

        }

    }
}
