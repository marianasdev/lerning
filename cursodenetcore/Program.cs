using System;

namespace cursodenetcore
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int [1];

            //preguntar cuantos pisos y captar el dato


            Console.WriteLine("INGRESE NUMERO DE PISOS");

            pisos = Convert.ToInt16(Console.ReadLine());

            //declaramos el primer for que depende del num de pisos

            for (int i = 1; i <= pisos; i++)
            {
                //colocamos un arreglo con la varianble i que sera la el tamaño del arreglo

                int[] pascal = new int[i];

                //ciclo for que decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.Write("  ");
                }

                //suma de las cifras
                for (int k = 0; k < i; k++)
                {
                    //condicion que evalua la variable del for
                    if (k == 0 || k == (i - 1)) 
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }

                    Console.Write("[" + pascal[k] + "]");
                }

                arreglo = pascal;
                Console.WriteLine("  ");
            }
 
           
        }
    }
}
