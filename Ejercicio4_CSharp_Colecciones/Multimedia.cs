using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    public abstract class Multimedia
    {
        //propiedades
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public int Codigo { get; set; }

        //constructores
        protected Multimedia()//más cómodo para instanciar
        {
        }

        protected Multimedia(string titulo,string autor,int codigo)
        {
            Titulo = titulo;
            Autor = autor;
            Codigo = codigo;
        }

        //metodo abstracto
        public abstract void Detalles();


    }
 }

