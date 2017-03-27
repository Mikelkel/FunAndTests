using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton
{
    public class Voiture
    {
        private int id;
        private string modele;


        public Voiture(int id, string modele)
        {
            Modele = modele;
            Id = id;
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Modele
        {
            get
            {
                return modele;
            }
            set
            {
                modele = value;
            }
        }
    }
}
