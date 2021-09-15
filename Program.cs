using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            // reads in lines of the file, dunno if into an array or if I just called it an array. it's a mystery
            var linesArray = File.ReadLines(@"C:\Users\sofien\Desktop\coursework\c# stuffs\supportbank\Transactions2014.csv");

            //list of the class Transaction, then setting a variable for the class 
            var transactions = new List<Transaction>();
            Transaction transaction;

            //loops through each row in csv, and skips header row
            foreach (string line in linesArray.Skip(1))
            {
                //splitting the line at the comma, separating the columns/to-be-objects
                string[] splitline = line.Split(',');
                //because amount is a decimal not a string it has to be converted 
                var amount = Convert.ToDecimal(splitline[4]);
                //making a new transaction for the line that also puts the split variables from the lines into the objects 
                transaction = new Transaction() {date = splitline[0], from = splitline[1], to = splitline[2], narrative = splitline[3], amount = amount};
                //add the transactions to a list
                transactions.Add(transaction);
            }
            // how long is the list of lines
            int length = transactions.Count;
            {
                Console.WriteLine(length);
            }
            // testing testing did the above work?

            Console.WriteLine(transactions[0].amount);
            Console.WriteLine(transactions[1].amount);
            Console.WriteLine(transactions[2].amount);

            //For loop that prints out each line in the "transactions" list in the form "Date: aaa From: bbb To: ccc etc"



        }
    }
}
