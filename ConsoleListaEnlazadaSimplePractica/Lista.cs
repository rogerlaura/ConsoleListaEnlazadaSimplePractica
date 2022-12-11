using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleListaEnlazadaSimplePractica
{
    internal class Lista
    {
        public Nodo primero, ultimo;
        public Lista()
        {
            this.primero = null;
            this.ultimo = null;

        }
        public bool ListaVacia()
        {
            if(this.primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertarDelante(string nombre, int horas, string nombred, char sexo)
        {
            Nodo nuevo=new Nodo();
            nuevo.nombre= nombre;
            nuevo.canthoras= horas;
            nuevo.nombred = nombred;
            nuevo.sexod = sexo;
            if (this.ListaVacia())
            {
                this.primero = nuevo;
                this.ultimo = nuevo;
            }
            else
            {
                nuevo.siguiente = this.primero;
                this.primero = nuevo;
            }
        }
        public void InsertarDetras(string nombre, int horas,string nombred,char sexo)
        {
            Nodo nuevo = new Nodo();
            nuevo.nombre = nombre;
            nuevo.canthoras = horas;
            nuevo.nombred = nombred;
            nuevo.sexod = sexo;
            if (this.ListaVacia())
            {
                this.primero = nuevo;
                this.ultimo = nuevo;
            }
            else
            {
                this.ultimo.siguiente = nuevo;
                this.ultimo = nuevo;
            }
        }
        
        public void InsertarOrdenado(string nombre,int horas,string nombred,char sexo)
        {
            int menor=0;
            Nodo nuevo, aux, aux1;
            nuevo= new Nodo();
            nuevo.nombre = nombre;
            nuevo.canthoras = horas;
            nuevo.nombred=nombred;
            nuevo.sexod = sexo;
            if (this.ListaVacia())
            {
                this.primero = nuevo;
                this.ultimo = nuevo;

            }
            else
            {
                aux = this.primero;
                aux1 = this.primero;
                menor=aux1.nombre.CompareTo(nombre);
                while ((aux1 != null) && (menor < 0))
                {
                    aux = aux1;
                    aux1 = aux1.siguiente;
                    if (aux1 != null)
                    {
                        menor = aux1.nombre.CompareTo(nombre);
                    }
                    
                }
                if (aux1 == this.primero)
                {
                    nuevo.siguiente = this.primero;
                    this.primero = nuevo;
                }
                else
                {
                    aux.siguiente = nuevo;
                    nuevo.siguiente= aux1;
                    if (aux1 == null)
                    {
                        this.ultimo = nuevo;
                    }
                }
            }
        }
        public void BuscarAsignatura(string nombre)
        {
            Nodo aux;
            bool existencia=false;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    if (aux.nombre.CompareTo(nombre) == 0)
                    {
                        existencia = true;
                        Console.WriteLine("Nombre: " + aux.nombre);
                        Console.WriteLine("CantidadHoras: " + aux.canthoras);
                        Console.WriteLine();
                    }
                    
                    aux = aux.siguiente;
                }
                if (existencia == false)
                {
                    Console.WriteLine("No existe la asignatura en la lista");
                }
            }
        }
        public void MostrarTodo()
        {
            Nodo aux;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    Console.WriteLine("Nombre: " + aux.nombre);
                    Console.WriteLine("CantidadHoras: " + aux.canthoras);
                    Console.WriteLine();
                    aux = aux.siguiente;
                }
            }
        }
        public void MostrarTodoDocente()
        {
            Nodo aux;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    Console.WriteLine("Nombre: " + aux.nombre);
                    Console.WriteLine("CantidadHoras: " + aux.canthoras);
                    Console.WriteLine("Nombre del Docente: " + aux.nombred);
                    Console.WriteLine("Genero del Docente : " + aux.sexod);
                    Console.WriteLine();
                    aux = aux.siguiente;
                }
            }
        }
        public void EliminarElemento(String nombre)
        {
            Nodo aux,aux1;
            if (this.ListaVacia())
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                aux=this.primero;
                aux1 = this.primero;
                while((aux1!=null)&&(aux1.nombre != nombre))
                {
                    aux = aux1;
                    aux1=aux1.siguiente;
                }
                if(aux1.nombre == nombre)
                {
                    aux.siguiente = aux1.siguiente;
                    if (aux1 == this.primero)
                    {
                        this.primero=aux1.siguiente;
                    }
                    else
                    {
                        this.ultimo = aux;
                    }
                }
                else
                {
                    Console.WriteLine("No existe la asignatura en la lista");
                }
            }
        }
        public void TotalAsignatura()
        {
            Nodo aux;
            int total = 0;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    total += 1;
                    aux = aux.siguiente;
                }
            }
            Console.WriteLine("Total de las asignatura es: " + total);
        }
        public void AsignaturaMayorCantidadHoras()
        {
            Nodo aux,aux1=null;
            int mayor = 0;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    if (aux.canthoras >= mayor)
                    {
                        mayor = aux.canthoras;
                        aux1 = aux;
                    }
                    aux = aux.siguiente;
                }
            }
            Console.WriteLine("ASIGNATURA CON MAYOR CANTIDAD DE HORAS");
            Console.WriteLine("Nombre: " + aux1.nombre);
            Console.WriteLine("CantidadHoras: " + aux1.canthoras);
            Console.WriteLine();
            
        }
        public void AsignaturaMenorCantidadHoras()
        {
            Nodo aux, aux1 = null;
            int menor = 1000;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    if (aux.canthoras <= menor)
                    {
                        menor = aux.canthoras;
                        aux1 = aux;
                    }
                    aux = aux.siguiente;
                }
            }
            Console.WriteLine("ASIGNATURA CON MAYOR CANTIDAD DE HORAS");
            Console.WriteLine("Nombre: " + aux1.nombre);
            Console.WriteLine("CantidadHoras: " + aux1.canthoras);
            Console.WriteLine();

        }
        public void AsignturaDocenteMasculino()
        {
            Nodo aux;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    if (aux.sexod == 'M')
                    {
                        Console.WriteLine("Nombre: " + aux.nombre);
                        Console.WriteLine("CantidadHoras: " + aux.canthoras);
                        Console.WriteLine();
                    }
                    aux = aux.siguiente;
                }
            }
        }
        public void AsignturaDocenteFemenino()
        {
            Nodo aux;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    if (aux.sexod == 'F')
                    {
                        Console.WriteLine("Nombre: " + aux.nombre);
                        Console.WriteLine("CantidadHoras: " + aux.canthoras);
                        Console.WriteLine();
                    }
                    aux = aux.siguiente;
                }
            }
        }

        public void PromedioCantidaHorasAsignatura()
        {
            Nodo aux;
            double suma = 0;
            double cantidad = 0;
            if (this.ListaVacia())
            {
                Console.WriteLine("Lista Vacia");
            }
            else
            {
                aux = this.primero;
                while (aux != null)
                {
                    cantidad++;
                    suma += aux.canthoras;
                    aux = aux.siguiente;
                }
            }
            Console.WriteLine("El promedio es: " + suma + "/" + cantidad + " = " + suma / cantidad);
        }
    }
}
