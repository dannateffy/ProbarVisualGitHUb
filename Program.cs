using System;

namespace ProbarVisualGitHUb
{
    class Program
    {
        static void Main(string[] args)
        {
            Primo primo = new Primo();
            Console.WriteLine("             UNIVERSIDAD NACIONAL DE CHIMBORAZO");
            Console.WriteLine("                 FACULTAD DE INGENIERIA");
            Console.WriteLine("                     CARRERA TIC");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("|Grupo: H");
            Console.WriteLine("|Integrantes: Dayana Naranjo y Lorenz Berrones");
            Console.WriteLine("|Tema: Herramienta colaborativa GitHub junto con Visual Studio");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("COMPROBAR SI UN NUMERO ES PRIMO");
            Console.WriteLine("Ingrese numero a comprobar:");
            primo.Num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("$$$$$$$$$");
            Console.WriteLine("CARGANDO");
            Console.WriteLine("$$$$$$$$$");
            primo.NumPri();           
            Console.ReadKey();
            Console.WriteLine("Gracias por su atencion");
            Console.ReadKey();
        }
    }
}
