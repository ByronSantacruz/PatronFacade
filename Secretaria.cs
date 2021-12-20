using System;

namespace ByronSantacruz3BFacade
{
    public class Secretaria 
    {
        private string Nombre;
        private string Apellido;
        private int ID;
        private double Telefono;
        private string Correo;
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }
        public int getID()
        {
            return ID;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public double  getTelefono()
        {
            return Telefono;
        }
        public void setTelefono(double Telefono)
        {
            this.Telefono = Telefono;
        }
        public string getCorreo()
        {
            return Correo;
        }
        public void setCorreo(string Correo)
        {
            this.Correo = Correo;
        }
        public void CrearExpediente()
        {
            Console.WriteLine("Expediente con datos del alumno:\nNombre: {0}\nApellido: {1}\nCedula de indentidad: {2}\nNumero de telefono: +593{3}\nCorreo electronica: {4}",Nombre,Apellido,ID,Telefono,Correo);
        }
    }
}
