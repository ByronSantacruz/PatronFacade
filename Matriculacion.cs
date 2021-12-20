using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacade
{
    public class Matriculacion
    {
        private Secretaria PreMatricula;
        private Libreria GeneraCompra;
        private Biblioteca GeneraReserva;
        private Plan_Estudios ObtenPropuesta;
        public Matriculacion(string text)
        {
            PreMatricula = new Secretaria();
            PreMatricula.setNombre("Byron");
            PreMatricula.setApellido("Santacruz");
            PreMatricula.setID(1315586477);
            PreMatricula.setTelefono(0981307530);
            PreMatricula.setCorreo("byron.santacruz2002@gmail.com");
            ObtenPropuesta = new Plan_Estudios();
            ObtenPropuesta.setMateriasO(2);
            GeneraCompra = new Libreria();
            GeneraCompra.setCantidadLibro(4);
            GeneraReserva = new Biblioteca();
            GeneraReserva.setCantidadReserva(2);
        }
        public void MostrarFachada()
        {
            PreMatricula.CrearExpediente();
            ObtenPropuesta.MateriasObligatorias();
            ObtenPropuesta.MateriasOpcionales();
            GeneraCompra.CompraLibro();
            GeneraReserva.ReservaLibro();

        }
    }
}
