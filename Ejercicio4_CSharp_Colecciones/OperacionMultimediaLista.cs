using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    class OperacionMultimediaLista:IOperaciones<Multimedia>
    {

        private List<Multimedia> lista;

        public OperacionMultimediaLista()
        {
            lista=new List<Multimedia>();
        }


        //métodos
        public void Add(Multimedia data)
        {
            lista.Add(data);
        }

        public void Listar()
        {
            foreach (var multimedia in lista)
            {
                multimedia.Detalles();
            }
        }

        public Multimedia GetObjeto(int busqueda)
        {
            //sin linkiu/LinkQ, no se hace así

            //foreach (var multimedia in lista)
            //{
            //    if (multimedia.Codigo == busqueda)
            //    {
            //        return multimedia;
            //    }
            //} return null;

            //Con LinkQ
            var ele = lista.FirstOrDefault(o => o.Codigo == busqueda);
            return ele;
        }


        public int GetCodigo()
        {
            //return lista.Max(o=>o.Codigo);//así sería con LinkQ
            return lista.Count + 1;//el código será para el primer elemento 1, el 2º 2...
        }
    }
}
