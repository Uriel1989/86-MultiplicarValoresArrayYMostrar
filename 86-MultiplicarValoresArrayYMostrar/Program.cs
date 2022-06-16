using System;

//Pedir un numero por teclado y multiplicar todos los valores de un array y mostrar el array.

namespace _86_MultiplicarValoresArrayYMostrar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero por teclado para mutiplicar los valores del array:");

            int i = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[3];

            array[0] = 1;
            array[1] = 3;
            array[2] = 6;

            Console.Clear();

            for (int q = 0; q < array.Length; q++)
            {
                Console.WriteLine("Los valores del array son: " + array[q]);
            }

            for (int q = 0; q < array.Length; q++)
            {
                Console.WriteLine("El resultado de multipicar por " + i +" la cuenta es: " + array[q]*i);
            }
        }
    }
}
