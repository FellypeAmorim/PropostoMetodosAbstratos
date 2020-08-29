using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoMetodosAbstratos1.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double Anualincome { get; set; }

        protected TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualincome)
        {
            Name = name;
            Anualincome = anualincome;
        }

        public abstract double Tax();

    }
}
