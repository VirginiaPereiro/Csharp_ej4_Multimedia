using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    public interface IOperaciones<Tipo>
        //La interfaz va a trabajar con el generics que es el tipo
        //siempre que necesite utilizar los métodos que se encuentren en él
        //va a valer para siempre y opara cualquier tipo de datos que queramos
    {
        //va a hacer tres operaciones
        void Add(Tipo data);

        void Listar();

        Tipo GetObjeto(int busqueda);//de devuelve Tipo

        int GetCodigo();
    }
}
