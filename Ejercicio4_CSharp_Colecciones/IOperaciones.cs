using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    public interface IOperaciones<Tipo>
        //define qué se va a hacer pero no cómo
        //public interface IOperaciones<Tipo> where Tipo:INumerable, sólo valdría para los de la clase INumerable
        //en una interfaz se busca una estandarización
        //ante cambios que se hagan no suponga mucho trabajo adaptarlo a los nuevos objetivos o cambios
        //aplicacion diseñada a una base de memoria 
        //pero si lo quiero cambiar a una base de datos tendré que cambiar muy poco
        //La interfaz va a trabajar con el generics que es el tipo
        //al hacer el generics podré usarlo para figuras, cadenas lo que se quiera
        //siempre que necesite utilizar los métodos que se encuentren en él
        //va a valer para siempre y opara cualquier tipo de datos que queramos
    {
        //va a hacer tres operaciones
        void Add(Tipo data);

        void Listar();

        Tipo GetObjeto(int busqueda);//de devuelve Tipo

        int GetCodigo();//devuelva el código que se le ha asignado
    }
}
