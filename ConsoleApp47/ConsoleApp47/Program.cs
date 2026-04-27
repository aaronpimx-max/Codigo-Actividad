using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static ConsoleApp47.Program;

namespace ConsoleApp47
{
    internal class Program
    {
        public class Cliente
        {
            private int _id;
            private string _nombre;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string Nombre
            {
                get { return _nombre; }
                set { _nombre = value; }
            }

            public Decimal Credito { get; set; }

            public void Comprar(decimal monto)
            {
                Credito += monto;
            }

            public void Vender(decimal monto)
            {
                Credito += monto;
            }
        }

        
            public static void RealizarTransacciones()
            {
                Cliente MiCliente = new Cliente();

                MiCliente.Nombre = "Cliente Inicial";
                MiCliente.Vender(100m);
                Console.WriteLine($"Nombre: {MiCliente.Nombre}, Crédito actual: {MiCliente.Credito}");

                MiCliente.Nombre = "Cliente Actualizado";
                MiCliente.Vender(500m);
                Console.WriteLine($"Nombre: {MiCliente.Nombre}, Crédito acumulado: {MiCliente.Credito}");
            }
        

        static void Main(string[] args)
            {
             Console.WriteLine("Objetos y clases:");

              RealizarTransacciones();

            Console.ReadKey();
            }  
    }
}