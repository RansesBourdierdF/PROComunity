

using System;

namespace MiembroDeLacomunidad
{
    public abstract class MBDeLaComunidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }


        public abstract void Gruardar();

        public virtual void Obtener() 
        { 
            Console.WriteLine("Obtenido"); 


        }



    }
}

