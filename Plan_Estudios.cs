using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacade
{
    public class Plan_Estudios 
    {
        private int MateriasO;
        public int getMateriasO()
        {
            return MateriasO;
        }
        public void setMateriasO(int MateriasO)
        {
            this.MateriasO = MateriasO;
        }
        public void MateriasObligatorias()
        {
            Console.WriteLine("Materias obligatorias para usted son 4:\n//Metodos\n//Sistemas operativos\n//Sistema digitales\n//Ecuaciones");
        }
        public void MateriasOpcionales()
        {
            
            Console.WriteLine("//Obtener la lista de materias opcionales//\n1-->Deporte\n2-->Ingles");
            if (MateriasO == 1)
            {
                Console.WriteLine("Usted escogio la materia:\nDeporte");
            }
            else if (MateriasO == 2)
            {
                Console.WriteLine("Usted escogio la materia:\nIngles");
            }
            else if(MateriasO<1 || MateriasO > 2)
            {
                Console.WriteLine("No hay mas materias opcionales");
            }
        }
    }
}
