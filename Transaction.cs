using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportbank
{
    class Transaction
    {
        public string date;
        public string from;
        public string to;
        public string narrative;
        public decimal amount;

        public Transaction(string date, string from, string to, string narrative, decimal amount)
        {
            this.date = date;
            this.from = from;
            this.to = to;
            this.narrative = narrative;
            this.amount = amount;
        }
    }
}
