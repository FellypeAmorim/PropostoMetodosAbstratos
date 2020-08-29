using System;
using System.Collections.Generic;
using System.Text;

namespace PropostoMetodosAbstratos1.Entities
{
    class Individual : TaxPayer
    {
        public double Healthexpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthexpenditures, string name, double anualincome) : base(name, anualincome)
        {
            Healthexpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (Anualincome < 20000)
            {              
                return (Anualincome * 15 / 100) - (Healthexpenditures * 50 / 100);
            }
            else
            {
                return (Anualincome * 25 / 100) - (Healthexpenditures * 50 / 100);
            }
        }
    }
}
