using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleListaEnlazadaSimplePractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int canthoras, opcion;
            string nombre,nombred;
            char sexo;
            Lista l = new Lista();
            do
            {
                Console.WriteLine("\t===========[ MENU ]==========");
                Console.WriteLine("\t\t1.- INSERTAR DELANTE");
                Console.WriteLine("\t\t2.- INSERTAR DETRAS");
                Console.WriteLine("\t\t3.- INSERTAR ORDENADO");
                Console.WriteLine("\t\t4.- BUSCAR ASIGNATURA Y VER SU INFORMACION");
                Console.WriteLine("\t\t5.- ELIMINAR UNA DETERMINADA ASIGNATURA");
                Console.WriteLine("\t\t6.- MOSTRAR TODAS LAS ASIGNATURAS");
                Console.WriteLine("\t\t7.- LISTAR MAS DATOS DEL DOCENTE");
                Console.WriteLine("\t\t8.- TOTAL DE LAS ASIGNATURAS");
                Console.WriteLine("\t\t9.- ASIGNATURAS CON MAYOR CANTIDAD DE HORAS");
                Console.WriteLine("\t\t10.- ASIGNATURA CON MENOR CANTIDAD DE HORAS");
                Console.WriteLine("\t\t11.- ASIGNATURAS CON DOCENTES MASCULINOS");
                Console.WriteLine("\t\t12.- ASIGNATURAS CON DOCENTES FEMENINOS");
                Console.WriteLine("\t\t13.- PROMEDIO CANTIDAD HORAS");
                Console.WriteLine("\t\t14.- SALIR");
                Console.Write("\tELIJA UNA OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombre= Console.ReadLine();
                        Console.Write("\tDIGITE LA CANTIDAD DE HORAS DE LA ASIGNATURA: ");
                        canthoras = int.Parse(Console.ReadLine());
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombred = Console.ReadLine();
                        Console.Write("\tDIGITE EL GENERO DEL DOCENTE (M o F): ");
                        sexo = char.Parse(Console.ReadLine());

                        l.InsertarDelante(nombre,canthoras,nombred,sexo);

                        break;
                    case 2:
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombre = Console.ReadLine();
                        Console.Write("\tDIGITE LA CANTIDAD DE HORAS DE LA ASIGNATURA: ");
                        canthoras = int.Parse(Console.ReadLine());
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombred = Console.ReadLine();
                        Console.Write("\tDIGITE EL GENERO DEL DOCENTE (M o F): ");
                        sexo = char.Parse(Console.ReadLine());
                        l.InsertarDetras(nombre, canthoras,nombred,sexo);
                        break;
                    case 3:
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombre = Console.ReadLine();
                        Console.Write("\tDIGITE LA CANTIDAD DE HORAS DE LA ASIGNATURA: ");
                        canthoras = int.Parse(Console.ReadLine());
                        Console.Write("\tDIGITE EL NOMBRE DE LA ASIGNATURA: ");
                        nombred = Console.ReadLine();
                        Console.Write("\tDIGITE EL GENERO DEL DOCENTE (M o F): ");
                        sexo = char.Parse(Console.ReadLine());
                        l.InsertarOrdenado(nombre, canthoras,nombred,sexo);

                        break;
                    case 4:
                        Console.Write("\tDIGITE EL NOMRE DE LA ASIGNATURA: ");
                        nombre = Console.ReadLine();
                        l.BuscarAsignatura(nombre);
                        break;
                    case 5:
                        //l.Eliminar();
                        Console.Write("\tDIGITE EL NOMRE DE LA ASIGNATURA: ");
                        nombre = Console.ReadLine();
                        l.EliminarElemento(nombre);
                        break;
                    case 6:
                        l.MostrarTodo();
                        break;
                    case 7:
                        l.MostrarTodoDocente();
                        break;
                    case 8:
                        l.TotalAsignatura();
                        break;
                    case 9:
                        l.AsignaturaMayorCantidadHoras();
                        break;
                    case 10:
                        l.AsignaturaMenorCantidadHoras();
                        break;
                    case 11:
                        l.AsignturaDocenteMasculino();
                        break;
                    case 12:
                        l.AsignturaDocenteFemenino();
                        break;
                    case 13:
                        l.PromedioCantidaHorasAsignatura();
                        break;
                    case 14:
                        break;
                    default:
                        Console.WriteLine("\tOPCION NO VALIDO");
                        break;
                }
                Console.ReadKey(true);
                Console.Clear();
            } while (opcion != 14);
        }
    }
}
