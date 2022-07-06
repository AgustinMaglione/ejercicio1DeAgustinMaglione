using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1DeAgustinMaglione
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesos, dolar, euro, conversion1,conversion2;
            Console.WriteLine("Ingrese la cantidad en pesos que quieres convertir:");
            pesos = double.Parse(Console.ReadLine());
            dolar = pesos / 230;
            Console.Write($"La cantidad de dolar que pudes compra es { Math.Truncate( dolar) } dolar ");
            euro = dolar * 1.17;
            Console.Write($" y en euros es  { euro } euros ");
            Console.ReadLine();
        }
    
    }
  
}

