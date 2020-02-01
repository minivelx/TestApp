using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.EstructuraDatos.ArbolBinario
{
    public class Arbol
    {
        public Arbol()
        {
            raiz = null;
        }

        public Nodo raiz { get; set; }


        public void InsertarNodo()
        {
            Console.Write("Ingrese el valor del nodo :");
            int nuevoValor = 0;
            int.TryParse(Console.ReadLine(), out nuevoValor);

            Nodo nuevo = new Nodo();
            nuevo.valor = nuevoValor;

            if(raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if(raiz.valor != nuevoValor)
                {
                    if(raiz.valor < nuevoValor)
                        raiz.nDerecho = InsertarRama(raiz.nDerecho, nuevo);
                    else
                        raiz.nIzquierdo = InsertarRama(raiz.nIzquierdo, nuevo);
                }
                else
                {
                    Console.Write("El valor " + nuevoValor + " ya se encuentra ingresado en el árbol.");
                    Console.ReadLine();
                }
            }
        }

        private Nodo InsertarRama(Nodo rama, Nodo nuevo)
        {
            if(rama== null)
            {
                rama = nuevo;
            }
            else
            {
                if (rama.valor != nuevo.valor)
                {
                    if (rama.valor < nuevo.valor)
                        rama.nDerecho = InsertarRama(rama.nDerecho, nuevo);
                    else
                        rama.nIzquierdo = InsertarRama(rama.nIzquierdo, nuevo);
                }
                else
                {
                    Console.Write("El valor " + nuevo.valor + " ya se encuentra ingresado en el árbol.");
                    Console.ReadLine();
                }
            }          

            return rama;
        }

        private List<Nodo> RecorrerNodos(Nodo nodo, ref List<Nodo> lista)
        {
            if (nodo != null)
            {
                RecorrerNodos(nodo.nIzquierdo, ref lista);
                lista.Add(nodo);
                RecorrerNodos(nodo.nDerecho, ref lista);
   
            }

            return lista;            
        }

        public void ConsultarRamas(int n)
        {
            var lista = new List<Nodo>();
            RecorrerNodos(raiz, ref lista);
            var nodoBuscado = lista.FirstOrDefault(x => x.valor == n);
            if (nodoBuscado== null)
                Console.WriteLine("No existe nodo con el valor ingresado.");
            else
            {
                var derecho = nodoBuscado.nDerecho == null ? "nulo" : nodoBuscado.nDerecho.valor.ToString();
                var izquierdo = nodoBuscado.nIzquierdo == null ? "nulo" : nodoBuscado.nIzquierdo.valor.ToString();
                Console.WriteLine("Rama izquierda = " + izquierdo  + " , Rama derecha = " + derecho );
                Console.ReadLine();
            }
        }

        public void ContarNodos()
        {
            var lista = new List<Nodo>();
            RecorrerNodos(raiz, ref lista);
            Console.WriteLine("El número de nodos es: " + lista.Count());
            Console.ReadLine();
        }
    }
}
