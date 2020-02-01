using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestApp.Agrupacion
{
    public class Almacen
    {
        public Almacen()
        {
            registrosVentas = new List<Registro>();
        }

        public List<Registro> registrosVentas { get; set; }

        public void CargarVentas()
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "archivo.json");            

            using (StreamReader jsonStream = File.OpenText(ruta))
            {
                var json = jsonStream.ReadToEnd();
                registrosVentas = JsonConvert.DeserializeObject<List<Registro>>(json);
            }

            Console.WriteLine("Datos cargados correctamente!.");
            Console.ReadLine();
        }
        public void AgruparVentas()
        {
            Console.Clear();
            if (registrosVentas.Count == 0) Console.WriteLine("No hay datos para mostrar.");

            var lstAgrupacion = registrosVentas.GroupBy(x => new { x.ciudad, x.mes });

            foreach(var grupo in lstAgrupacion )
            {
                var total = grupo.Sum(x => x.venta);
                Console.WriteLine("Ciudad: " + grupo.Key.ciudad + " , Mes: " + grupo.Key.mes + " , Total: " + total);
            }
            Console.ReadLine();
        }
    }
}
