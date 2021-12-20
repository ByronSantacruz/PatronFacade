using System;

namespace ByronSantacruz3BFacade
{
    public class Biblioteca : Libreria
    {
        private int CantidadReserva;
        public int getCantidadReservao()
        {
            return CantidadReserva;
        }
        public void setCantidadReserva(int CantidadReserva)
        {
            this.CantidadReserva = CantidadReserva;
        }
        public void ReservaLibro()
        {
            Console.WriteLine("//Bienvenido a la Biblioteca escoja cuanto libro desea reserva//");
            if (CantidadReserva == 1)
            {
                Console.WriteLine("Usted reservado {0} libro:\n//Ingles", CantidadReserva);
            }
            else if (CantidadReserva == 2)
            {
                Console.WriteLine("Usted escogio {0} libro:\n//Ingles\n//Ecuaciones", CantidadReserva);
            }
            else if (CantidadReserva < 1 || CantidadReserva > 2)
            {
                Console.WriteLine("No existe el libro que elegio");
            }
        }
      
    }
}
