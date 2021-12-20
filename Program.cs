using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacade
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cliente numero 1
            Matriculacion Cliente1 = new Matriculacion("texto");
            Cliente1.MostrarFachada();
            Console.ReadLine();
        }
    }
}
