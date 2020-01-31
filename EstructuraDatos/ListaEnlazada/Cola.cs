using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.EstructuraDatos.ListaEnlazada
{
    public class Cola
    {
        public Cola()
        {
            primera = null;
            ultima = null;
        }

        public Persona primera { get; set; }
        public Persona ultima { get; set; }

        public void AgregarPersonaEnCola()
        {
            Persona nueva = new Persona();

            Console.Write("Ingrese el nombre de la persona: ");
            nueva.nombre = Console.ReadLine();

            if(primera == null)
            {
                primera = nueva;
                ultima = nueva;
            }
            else
            {
                ultima.pEspalda = nueva;
                nueva.pFrente = ultima;
                ultima = nueva;
            }
        }

        public void ListarOrdenCola()
        {
            if (primera == null) Console.WriteLine("La cola esta vacia.");
            RecorrerOrdenCola().ToList().ForEach(x=> Console.WriteLine(x));
            Console.ReadLine();
        }

        public int ContarPersonasEnCola()
        {
            return primera == null ? 0 : RecorrerOrdenCola().Count();
        }

        public IEnumerable<string> RecorrerOrdenCola()
        {
            var apuntador = primera;

            while (apuntador != null)
            {
                yield return (apuntador.nombre);
                apuntador = apuntador.pEspalda;
            }
        }

        public void AtenderPersona()
        {
            if (primera != null)
            {
                var apuntador = primera.pEspalda;
                if (apuntador != null)
                {
                    primera.pEspalda = null;
                    apuntador.pFrente = null;
                }                
                primera = apuntador;
                Console.WriteLine("Persona atendida correctamente.");
            }
            else
                Console.WriteLine("No hay personas en la cola.");
            Console.ReadLine();
        }

        public void ColarPersona(int posicion)
        {
            if (posicion < 1 || posicion > ContarPersonasEnCola() )
            {
                Console.WriteLine("Posición no valida.");
            }
            else
            {
                Console.Write("Ingrese el nombre de la persona que se va a colar: ");
                var colada = new Persona();
                colada.nombre = Console.ReadLine();

                var personaQueSeLeColan = ConsultarPersonaPorposicion(posicion);
                var frentePersonaQueSeLeColan = personaQueSeLeColan.pFrente;

                if (posicion == 1)
                    primera = colada;
                else
                    frentePersonaQueSeLeColan.pEspalda = colada;
                
                colada.pFrente = frentePersonaQueSeLeColan;
                colada.pEspalda = personaQueSeLeColan;
                personaQueSeLeColan.pFrente = colada;

            }
                
            Console.ReadLine();
        }

        private Persona ConsultarPersonaPorposicion(int posicion)
        {
            int cont = 1;
            var apuntador = primera;

            while (apuntador != null)
            {
                if(cont == posicion)                
                    return apuntador;

                apuntador = apuntador.pEspalda;
                cont++;
            }

            return null;
        }
    }
}
