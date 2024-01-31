﻿using System;
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
                    do { Console.WriteLine("Scegli l'esercizio giornaliero \n1) BankAccount\n2) Crea e popola array\n3) Somma e media di array\n"); }
                    while (!int.TryParse(Console.ReadLine(), out sceltaEsercizio));

                } while (sceltaEsercizio != 1 && sceltaEsercizio != 2 && sceltaEsercizio != 3);

                if (sceltaEsercizio == 1)
                {

                    string askOpenAccount;

                    do
                    {
                        Console.WriteLine("Vuoi aprire un conto corrente ? y/n ");
                        askOpenAccount = Console.ReadLine();
                    }

                    while (askOpenAccount != "y" && askOpenAccount != "n");

                    if (askOpenAccount == "n")
                    {
                        Environment.Exit(0);
                    }

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
                            Console.WriteLine("inserisci la cifra da prelevare");
                            decimal withdrawalTry = Convert.ToDecimal(Console.ReadLine());

                            if (withdrawalTry > myAccount.AccountBalance)
                                Console.WriteLine("Non hai abbastanza soldi poveraccio\n");
                            else
                                myAccount.Withdrawal(withdrawalTry);
                        }
                        if (chooseOperation == "d")
                        {
                            Console.WriteLine("inserisci la cifra da depositare");
                            decimal depositTry = Convert.ToDecimal(Console.ReadLine());

                            if (depositTry < 1000)
                                Console.WriteLine("Il deposito minimo è 1000 euri\n");
                            else
                                myAccount.Deposit(depositTry);
                        }
                        if (chooseOperation == "c")
                            break;
                        // Environment.Exit(0);

                    }
                    while (chooseOperation != "C");



                }

                if (sceltaEsercizio == 2)
                {
                    int arrayLength;

                    do { Console.WriteLine("Inserisci la dimenzione dell'array desiderata: "); }
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



                }

                if (sceltaEsercizio == 3)
                {
                    int arrayLength;

                    do { Console.WriteLine("Inserisci la dimenzione dell'array desiderata: "); }
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

                }

                else Environment.Exit(0);
            }

            while (sceltaEsercizio == 1 || sceltaEsercizio == 2 || sceltaEsercizio == 3);
        }
    }
}
