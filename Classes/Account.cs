using System;

namespace myBank.Classes
{
    public class Account
    {
        private AccountType AccountType {get; set; }
        private double Balance {get; set; }
        private double Credit {get; set; }
        private string Name {get; set; }

        public Account(AccountType accountType, double balance, double credit, string name)
        {
            this.AccountType = accountType;
            this.Balance = balance;
            this.Credit = credit;
            this.Name = name;
        }

        public bool withdraw(double drawValue)
        {
            if (this.Balance - drawValue < (this.Credit *-1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false; 
            }
            this.Balance -= drawValue;

            Console.WriteLine("Saldo atual da conta de {0} e {1}", this.Name, this.Balance);

            return true;
        }

        public void deposit(double depositValue)
        {
            this.Balance += depositValue;
            
            Console.WriteLine("Saldo atual da conta de {0} e {1}", this.Name, this.Balance);
        }

        public void transfer(double transferValue, Account accountDestination)
        {
            if (this.withdraw(transferValue))
            {
                accountDestination.deposit(transferValue);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno +="AccountType" + this.AccountType + " | ";
            retorno +="Name" + this.Name + " | ";
            retorno +="Balance" + this.Balance + " | ";
            retorno +="Credit" + this.Credit;
            return retorno;
        }
    }
}