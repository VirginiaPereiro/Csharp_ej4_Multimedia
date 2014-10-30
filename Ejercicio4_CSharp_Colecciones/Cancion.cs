using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    class Cancion:Multimedia
    {

        public int Duracion { get; set; }
        public Formato Formato { get; set; }

        public Cancion(string titulo, string autor, int codigo, int duracion, Formato formato)
            : base(titulo, autor, codigo)
        {
            Duracion = duracion;
            Formato = formato;
        }

        public override void Detalles()
        {
            Console.WriteLine("La canción llamada {0}, del autor {1}, con el código {2} tiene una duracion de {3} y su formato es {4}",
                              Titulo, Autor, Codigo, Duracion, Formato);
        }

       
    }
}
