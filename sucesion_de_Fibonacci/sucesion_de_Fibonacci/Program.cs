// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class FibonacciRecursion
{

    //CALCULAR EL FACTORIAL DE UN NUMERO CON RECURSIVIDAD

    //static void Main()
    //{
    //    Console.WriteLine("Ingrese por favor el numero a factorizar");
    //    int num = int.Parse(Console.ReadLine());

    //    int resultado = CalcularFactorial(num);

    //    Console.WriteLine("El factorial de " + num + " " + "es: " + resultado);



    //    static int CalcularFactorial(int numero)
    //    {
    //        if (numero == 0)
    //        {
    //            return 1;
    //        }
    //        else
    //        {
    //            return numero * CalcularFactorial(numero - 1);
    //        }
    //    }


    //}



    //CALCULAR EL FACTORIAL DE UN NUMERO DE MANERA CLASICA

    //static void Main()
    //{
    //    Console.WriteLine("Ingrese por favor el numero a factorizar");
    //    int numero = int.Parse(Console.ReadLine());
    //    int multiplicacion;
    //    int resultado = numero;


    //    for (int i = 1; i < numero; i++)
    //    {

    //        multiplicacion = resultado * i;
    //        resultado = multiplicacion;



    //    }

    //    Console.Write("El factorial de " + numero + " es: " + resultado);
    //}

    //CALCULAR LA SUCESION DE FIBONACCI UTILIZANDO RECURSIVIDAD Y EL METODO NORMAL

    static void Main()
    {

        Console.WriteLine("Ingrese por favor el limite de la sucesion");
        int limite = int.Parse(Console.ReadLine());

        if (limite <= 0)
        {
            Console.WriteLine("El limite debe ser mayor que cero");
        }
        else if (limite >= 1)
        {

            int n = limite;
            Console.WriteLine("sucesion de Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }

        }
    }

    static int Fibonacci(int n)
    {
       
        if (n <= 1)
        {
            return n;
        }
        else
        {                 
            return Fibonacci(n-1) + Fibonacci(n-2);          
            
        }
    }
}

