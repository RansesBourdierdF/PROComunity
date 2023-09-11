
using System;

namespace MiembroDeLacomunidad
{
    public class Estudiente : MBDeLaComunidad
    {
       public string MatriculaActiva { get; set; }

        public override void Gruardar()
        {
            throw new System.NotImplementedException();
        }

        public override void Obtener()
        {
            Console.WriteLine("Obtenido");


        }




    }

}