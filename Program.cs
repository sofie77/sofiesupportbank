using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supportbank
{
    class Program
    {
        static void Main(string[] args)
        {


            // reads in lines of the file, dunno if into an array or if I just called it an array. it's a mystery
            // the unsolved case of the array
            var linesArray = File.ReadLines(@"C:\Users\sofien\Desktop\coursework\c# stuffs\supportbank\Transactions2014.csv");

            //list of the class Transaction, then setting a variable for the class 
            var transactions = new List<Transaction>();
            Transaction transaction;

            //acounts
            var accounts = new Dictionary<string, Account>();

            //loops through each row in csv, and skips header row
            foreach (string line in linesArray.Skip(1))
            {
                //splitting the line at the comma, separating the columns/to-be-objects
                string[] splitline = line.Split(',');
                //because amount is a decimal not a string it has to be converted 
                var amount = Convert.ToDecimal(splitline[4]);
                //making a new transaction for the line that also puts the split variables from the lines into the objects 
                transaction = new Transaction(splitline[0], splitline[1], splitline[2], splitline[3], amount);
                //add the transactions to a list
                transactions.Add(transaction);
                //account
                //splitting by from and to and putting into neat variables
                string fromName = splitline[1];
                string toName = splitline[2];
                Account fromAccount = new Account(fromName);
                Account toAccount = new Account(toName);
                if (accounts.ContainsKey(fromName))
                {
                    //if it already does it otherwise do the thing
                }
                else
                {
                    accounts.Add(fromName, fromAccount);
                }
                if (accounts.ContainsKey(toName))
                {
                    //if it already does it otherwise do the thing
                }
                else
                {
                    accounts.Add(toName, toAccount);
                }

                // Add amount to balance of toAccount
                accounts[toName].Balance += amount;
                // Remove amount from balance of fromAccount
                accounts[fromName].Balance -= amount;
            }

            foreach (var entry in accounts)
            {
                Console.WriteLine(entry.Value.Name + ": " + entry.Value.Balance);

            }
        

            // how long is the list of lines
            int length = transactions.Count;
            {
                Console.WriteLine(length);
            }
            // woop woop thats the sound of the c# police (matthew)
            // testing testing testing did the above work?

            Console.WriteLine(transactions[0].amount);
            Console.WriteLine(transactions[1].amount);
            Console.WriteLine(transactions[2].amount);

            // List all - start

            
            Console.Read();

        }
    }
}
