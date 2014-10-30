using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    public class Libro:Multimedia
    {

        public int Paginas { get; set; }
        //aquí llamo a mi fichero de enumeraciones que se encuentra en el mismo namespace 
        //si estuviese en otro namespace habría que poner el nombre de namespace.comosellame
        public Idioma Idioma { get; set; } 

        public Libro(string titulo, string autor, int codigo, int paginas, Idioma idioma)
            : base(titulo, autor, codigo)
        {
            Paginas = paginas;
            Idioma = idioma;
        }

        public override void Detalles()
        {
          Console.WriteLine("El libro llamado {0}, del autor {1}, con el código {2} tiene un total de páginas {3} y su idioma es {4}",
                              Titulo, Autor, Codigo, Paginas, Idioma);
        }
        
    }
}
