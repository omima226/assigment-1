using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_1
{
    internal class BankAccount
    {
       public string AccountNumber { get; }
       public string AccountHolderName { get; set; }
       public decimal Balance { get; private set; }
       
        //bouns 
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("please enter positive number and try again");
            }
            else { 
                UpdateBalance(amount);
                }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0) { throw new ArgumentException("please enter positive number and try again"); }
            else if (amount < Balance) { throw new ArgumentException("Your balance is insufficient"); }
            else { UpdateBalance(-amount); }
        }

        public void UpdateBalance(decimal amount)
        {
            Balance += amount;
        }



    }
}
