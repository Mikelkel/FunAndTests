using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage sortiedeGarage1 = null;
            sortiedeGarage1 = Garage.Instance;


            Garage sortiedeGarage2 = null;
            sortiedeGarage2 = Garage.Instance;


            sortiedeGarage1.RemoveCarFromGarage();
            sortiedeGarage2.RemoveCarFromGarage();
            sortiedeGarage1.RemoveCarFromGarage();


            if (sortiedeGarage1.CountVehicle() == sortiedeGarage2.CountVehicle())
            {
                // Notre Singleton fonctionne, il n'y à qu'une seule instance.
                Console.WriteLine("Les deux instances sont identiques.");
            }

            Console.ReadLine();
            //string __outputGarageFormat = "Voiture {0} sortie du garage";
            //Garage __garage = null;
            //__garage = Garage.Instance;
            //Console.WriteLine(string.Format(__outputGarageFormat,(__garage.RemoveCarFromGarage()).Modele));
            //Console.WriteLine(string.Format(__outputGarageFormat, (__garage.RemoveCarFromGarage()).Modele));
            //Console.WriteLine(string.Format(__outputGarageFormat, (__garage.RemoveCarFromGarage()).Modele));
            //Console.WriteLine(string.Format(__outputGarageFormat, (__garage.RemoveCarFromGarage()).Modele));

        }
    }
}
