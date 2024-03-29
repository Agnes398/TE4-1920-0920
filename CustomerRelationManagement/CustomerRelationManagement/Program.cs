﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerRelationManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = "";

            //lista med favoriternas info 
            System.Collections.ArrayList Customers = new System.Collections.ArrayList();

            do
            {
                Console.WriteLine("Registrera en ny favorit? n/j");
                userinput = Console.ReadLine();
                    if (userinput == "n")
                    {
                    break;
                    }

                Console.WriteLine("Var snäll och mata in perosnens namn, efternamn, email adress och telefonnummer: ");


                //lägger in information(objekt) Customer i listan Customers
                Customers.Add(new Customer() { Namn = Console.ReadLine(), efterNamn = Console.ReadLine(), email = Console.ReadLine(), telefonnummer = Console.ReadLine() });



            } while (userinput == "j"); //fortsätt mata in nya favoriter så länge userInput är lika med j


            //antalet favoriter i listan?
            int countCustomers = Customers.Count;
            Console.WriteLine("Du har {0} favoriter", countCustomers);


            //skriv ut favoriternas information
            foreach (Customer c in Customers)
            {
                Console.WriteLine("{0} {1} {2} {3}", c.Namn, c.efterNamn, c.email, c.telefonnummer);
            }

        }
    }
}
