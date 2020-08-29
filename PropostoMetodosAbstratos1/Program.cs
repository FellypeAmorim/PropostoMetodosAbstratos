using PropostoMetodosAbstratos1.Entities;
using System;
using System.Collections.Generic;

namespace PropostoMetodosAbstratos1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            
            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char resposta = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualincome = double.Parse(Console.ReadLine());
                
                if(resposta == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpendidutres = double.Parse(Console.ReadLine());
                    list.Add(new Individual(healthexpendidutres, name, anualincome));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    int numberofemployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberofemployee, name, anualincome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0;

            foreach (TaxPayer taxpayer in list)
            {                
                Console.WriteLine(taxpayer.Name + ": R$" + taxpayer.Tax().ToString("F2"));              
                double tax = taxpayer.Tax();
                sum += tax;
                
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2"));
            
                
            

        }
    }
}
