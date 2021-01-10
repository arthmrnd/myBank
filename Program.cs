using System;
using System.Collections.Generic;

namespace myBank
{
    class Program
    {
        static List<Classes.Account> listAccounts = List<Classes.Account>();
        static void Main(string[] args)
        {
            string userOption = setUserOption();
            while (userOption.ToUpper() != "X")
			{
				switch (userOption)
				{
					case "1":
						//listAccount();
						break;
					case "2":
						//insertAccount();
						break;
					case "3":
						//transfer();
						break;
					case "4":
						//withdraw();
						break;
					case "5":
						//deposit();
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
