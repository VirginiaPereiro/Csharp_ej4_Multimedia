using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_CSharp_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos un objeto de tipo IOperaciones
            //que es el interfaz que tiene los métodos
            IOperaciones<Multimedia>ope=new OperacionMultimediaLista();
            int codigo = 0;

            //hacemos un menú
            do
            {
                Console.WriteLine("1.Alta 2.Listar 3.Buscar 4.Salir");
                Int32.TryParse(Console.ReadLine(), out codigo);
                
                switch (codigo)
                {
                    case 1:
                        Alta(ope);
                        break;
                    case 2:
                        ope.Listar();
                        break;
                    case 3:
                        Buscar(ope);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

            } while (codigo != 4);

        }

        private static void Alta(IOperaciones<Multimedia> ope)
        {
            int tipo;
            Console.WriteLine("Tipo 1.Libro 2.Cancion");
            int.TryParse(Console.ReadLine(), out tipo);

            Console.WriteLine("Titulo");
            var tit = Console.ReadLine();
            
            Console.WriteLine("Autor");
            var aut = Console.ReadLine();

            if (tipo == 1)
            {
                Console.WriteLine("Páginas");
                int pag;
                int.TryParse(Console.ReadLine(), out pag);

                Console.WriteLine("Idioma 0.Español 1.Inglés 2.Francés 3.Chino");
                int idi = 0;
                int.TryParse(Console.ReadLine(), out idi);

                ope.Add(new Libro(tit, aut, ope.GetCodigo(), pag, (Idioma) idi));
            }
            else
            {
                Console.WriteLine("Duración");
                int dur;
                int.TryParse(Console.ReadLine(), out dur);

                Console.WriteLine("Formato");
                Formato forma;
                Formato.TryParse(Console.ReadLine(), true, out forma);

                ope.Add(new Cancion(tit,aut,ope.GetCodigo(),dur,forma));
            }

        }


        private static void Buscar(IOperaciones<Multimedia> ope)
        {
            int cod;
            Console.WriteLine("Código");
            int.TryParse(Console.ReadLine(), out cod);

            ope.GetObjeto(cod).Detalles();
        }
        
    }
}
