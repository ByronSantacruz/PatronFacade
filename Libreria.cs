using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacade
{
    public class Libreria 
    {
        public int CantidadLibro;
        public int getCantidadLibro()
        {
            return CantidadLibro;
        }
        public void setCantidadLibro(int CantidadLibro)
        {
            this.CantidadLibro = CantidadLibro;
        }
        public void CompraLibro()
        {
            Console.WriteLine("//Bienvenido a la librería escoja cuanto libro desea comprar//");
            if(CantidadLibro == 1)
            {
                Console.WriteLine("Usted escogio {0} libro:\n//Metodos", CantidadLibro);
            }
            else if(CantidadLibro == 2)
            {
                Console.WriteLine("Usted escogio {0} libro:\n//Metodos\n//Sistemas operativos", CantidadLibro);
            }
            else if(CantidadLibro == 3)
            {
                Console.WriteLine("Usted escogio {0} libro:\n//Metodos\n//Sistemas operativos\n//Sistema digitales", CantidadLibro);
            }
            else if(CantidadLibro ==4 )
            {
                Console.WriteLine("Usted escogio {0} libro:\n//Metodos\n//Sistemas operativos\n//Sistema digitales\n//Ecuaciones", CantidadLibro);
            }
            else if (CantidadLibro < 1 || CantidadLibro > 4)
            {
                Console.WriteLine("No existe el libro que elegio");
            }
        }
    }
}
