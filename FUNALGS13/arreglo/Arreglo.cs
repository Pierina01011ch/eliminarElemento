using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglo
{
    internal class Arreglo
    {
        private int[] arreglo;

        public Arreglo(int n)
        {
            arreglo = new int[n];
        }

        public void LlenarArreglo()
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }
        }

        public void MostrarArreglo()
        {
            foreach (int valor in arreglo)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
        }

        public void EliminarElemento(int posicion)
        {
            if (posicion >= 0 && posicion < arreglo.Length)
            {
                for (int i = posicion; i < arreglo.Length - 1; i++)
                {
                    arreglo[i] = arreglo[i + 1]; 
                }

                Array.Resize(ref arreglo, arreglo.Length - 1);
            }
            else
            {
                Console.WriteLine("La posición ingresada es inválida.");
            }
        }

    }

}

