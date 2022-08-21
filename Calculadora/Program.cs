using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            double resultado = 0;
            double valor1;
            double valor2;

            Console.WriteLine("Ingresar el valor");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la letra para la operacion a realizar: s, r, m, d");
            op = Console.ReadLine();
            Console.WriteLine("Ingresar el proximo valor");
            valor2 = double.Parse(Console.ReadLine());
            int num;

            switch (op)
            {
                case "s":
                    if (op == "s")
                        resultado = valor1 + valor2;
                    Console.WriteLine("El resultado de la suma es de: " + resultado);
                    break;

                case "r":
                    if (op == "r")
                        resultado = valor1 - valor2;
                    Console.WriteLine("El resultado de la resta es de: " + resultado);
                    break;

                case "m":
                    if (op == "m")
                        resultado = valor1 * valor2;
                    Console.WriteLine("El resultado de la multiplicacion es de: " + resultado);
                    break;

                case "d":
                    if (op == "d")
                        resultado = valor1 / valor2;
                    Console.WriteLine("El resultado de la division es de: " + resultado);
                    break;

                default:
                    Console.WriteLine("Esta operacion no esta disponible... ");

                    return;
            }         
                   
        }   
    }
}
