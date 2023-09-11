

using System;

namespace MiembroDeLacomunidad
{
    public class Empleado : MBDeLaComunidad
    {
        public string Codigo { get; set; }
        public string Despartamento { get; set; }
        public string Posicion { get; set; }

        public override void Gruardar()
        {
            throw new NotImplementedException();
        }

        public override void Obtener()
        {
            Console.WriteLine("Obtenido");


        }






    }
}