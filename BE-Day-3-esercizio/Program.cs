using System;
using System.Linq;

namespace BE_Day_3_esercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sceltaEsercizio;

            do
            {
                do
                {
                    do { Console.WriteLine("\nScegli l'esercizio giornaliero \n1) BankAccount\n2) Crea e popola array\n3) Somma e media di array\n4) per chiudere l'app\n"); }
                    while (!int.TryParse(Console.ReadLine(), out sceltaEsercizio));

                } while (sceltaEsercizio != 1 && sceltaEsercizio != 2 && sceltaEsercizio != 3 && sceltaEsercizio != 4);

                if (sceltaEsercizio == 1)
                {

                    string askOpenAccount;

                    do
                    {
                        Console.WriteLine("\nVuoi aprire un conto corrente ? y/n ");
                        askOpenAccount = Console.ReadLine();
                    }

                    while (askOpenAccount != "y" && askOpenAccount != "n");

                    if (askOpenAccount == "y")
                    {
                        BankAccount myAccount = new BankAccount();
                        Console.WriteLine("\nInserisci il tuo nome: \n");
                        myAccount.Name = Console.ReadLine();
                        Console.WriteLine("\nInserisci il tuo cognome \n");
                        myAccount.Surname = Console.ReadLine();

                        string chooseOperation;
                        Console.WriteLine($"\nCiao {myAccount.Name} {myAccount.Surname} \n");

                        do
                        {
                            Console.WriteLine($"Il tuo saldo è pari a : {myAccount.AccountBalance} \n");
                            Console.WriteLine("Che operazione vuoi effettuare ?\n");
                            Console.WriteLine("premi P per prelevare\nPremi D per depositare\nPremi C per chiudere l'applicazione\n");
                            chooseOperation = Console.ReadLine().ToLower();

                            if (chooseOperation == "p")
                            {
                                Console.WriteLine("\ninserisci la cifra da prelevare");
                                decimal withdrawalTry = Convert.ToDecimal(Console.ReadLine());

                                if (withdrawalTry > myAccount.AccountBalance)
                                {
                                    Console.WriteLine("\nNon hai abbastanza soldi poveraccio\n");
                                    Console.ReadKey();
                                }
                                else
                                    myAccount.Withdrawal(withdrawalTry);
                            }
                            if (chooseOperation == "d")
                            {
                                Console.WriteLine("\ninserisci la cifra da depositare");
                                decimal depositTry = Convert.ToDecimal(Console.ReadLine());

                                if (depositTry < 1000)
                                {
                                    Console.WriteLine("\nIl deposito minimo è 1000 euri\n");
                                    Console.ReadKey();
                                }
                                else
                                    myAccount.Deposit(depositTry);
                            }
                            if (chooseOperation == "c")
                            {
                                Console.Clear();
                                break;
                            }

                        }
                        while (chooseOperation != "C");



                    }
                    else Console.Clear();



                }

                if (sceltaEsercizio == 2)
                {
                    int arrayLength;

                    do { Console.WriteLine("\nInserisci la dimensione dell'array desiderata: "); }
                    while (!int.TryParse(Console.ReadLine(), out arrayLength));

                    string[] arrayNomi = new string[arrayLength];

                    for (int x = 0; x < arrayLength; x++)
                    {
                        Console.WriteLine($"inserisci il nome numero {x + 1}: ");
                        arrayNomi[x] = Console.ReadLine();
                    }
                    Console.WriteLine("\nAdesso inserisci il nome da ricercare");
                    string nomeDaCercare = Console.ReadLine();

                    if (Array.IndexOf(arrayNomi, nomeDaCercare) != -1)
                        Console.WriteLine($"Il nome {nomeDaCercare} è contenuto nell'array");
                    else
                        Console.WriteLine($"Il nome {nomeDaCercare} non è contenuto nell'array");

                    Console.ReadKey();
                    Console.Clear();

                }

                if (sceltaEsercizio == 3)
                {
                    int arrayLength;

                    do { Console.WriteLine("\nInserisci la dimensione dell'array desiderata: "); }
                    while (!int.TryParse(Console.ReadLine(), out arrayLength));

                    int[] arrayNumeri = new int[arrayLength];

                    for (int x = 0; x < arrayLength; x++)
                    {
                        do { Console.WriteLine($"inserisci il numero {x + 1}: "); }
                        while (!int.TryParse(Console.ReadLine(), out arrayNumeri[x]));

                    }

                    int somma = arrayNumeri.Sum();
                    double media = arrayNumeri.Average();

                    Console.WriteLine($"La somma dei numeri è: {somma}\nLa media aritmetica è: {media}");

                    Console.ReadKey();
                    Console.Clear();

                }

                else if (sceltaEsercizio == 4) break;
            }

            while (sceltaEsercizio == 1 || sceltaEsercizio == 2 || sceltaEsercizio == 3);
        }
    }
}
