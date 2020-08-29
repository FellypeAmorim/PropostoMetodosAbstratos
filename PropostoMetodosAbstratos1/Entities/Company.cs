using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoMetodosAbstratos1.Entities
{
    class Company : TaxPayer
    {
        public int Numberofemployee { get; set; }


        public Company()
        {
        }

        public Company(int numberofemployee, string name, double anualincome) : base(name, anualincome)
        {
            Numberofemployee = numberofemployee;
        }

        public override double Tax()
        {
            if (Numberofemployee > 10)
            {
                return Anualincome * 14 / 100;
            }
            else
            {
                return Anualincome * 16 /100;
            }
        }
    }
}
