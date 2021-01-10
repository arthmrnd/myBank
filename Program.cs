using System;
using System.Collections.Generic;
//stop at part4 4:32

namespace myBank
{
    class Program
    {
        static List<Classes.Account> listAccounts = new List<Classes.Account>();
        static void Main(string[] args)
        {
            string userOption = setUserOption();
            while (userOption.ToUpper() != "X")
			{
				switch (userOption)
				{
					case "1":
						listAccount();
						break;
					case "2":
						insertAccount();
						break;
					case "3":
						transferCash();
						break;
					case "4":
						withdrawCash();
						break;
					case "5":
						depositCash();
						break;
                    case "L":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				userOption = setUserOption();
			}
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void depositCash()
        {
            Console.Write("Digite o número da conta: ");
			int indexAccount = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double depositValue = double.Parse(Console.ReadLine());

            listAccounts[indexAccount].withdraw(depositValue);
        }

        private static void withdrawCash()
        {
            Console.Write("Digite o número da conta: ");
			int indexAccount = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			double drawValue = double.Parse(Console.ReadLine());

            listAccounts[indexAccount].withdraw(drawValue);
        }

		private static void transferCash()
		{
			Console.Write("Digite o número da conta de origem: ");
			int indexOriginAccount = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
			int indexDestinyAccount = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser transferido: ");
			double transferValue = double.Parse(Console.ReadLine());

            listAccounts[indexOriginAccount].transfer(transferValue, listAccounts[indexDestinyAccount]);
		}

        private static void listAccount()
		{
			Console.WriteLine("Listar contas");

			if (listAccounts.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listAccounts.Count; i++)
			{
				Classes.Account Accountw = listAccounts[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(Accountw);
			}
		}

        private static void insertAccount()
        {
            
			Console.WriteLine("Inserir nova conta");

			Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
			int entryaccountType = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string entryName = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entryBalance = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entryCredit = double.Parse(Console.ReadLine());

			Classes.Account novaConta = new Classes.Account(accountType: (AccountType)entryaccountType,
										balance: entryBalance,
										credit: entryCredit,
										name: entryName);

			listAccounts.Add(novaConta);
        }

        private static string setUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Jew's Bank para te servir!");
            Console.WriteLine("Informe a Opção desejada:");

            Console.WriteLine("1- Listar contas");
			Console.WriteLine("2- Inserir nova conta");
			Console.WriteLine("3- Transferir");
			Console.WriteLine("4- Sacar");
			Console.WriteLine("5- Depositar");
            Console.WriteLine("L- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string UserOption = Console.ReadLine().ToUpper();
			Console.WriteLine();
            return UserOption;
        }
    }
}
