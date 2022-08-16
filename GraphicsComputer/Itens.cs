using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Itens
    {
        public static int[] CriarVetor()
        {
            int[] vetor = new int[3];

            Menus.Enunciado("Entre com o valor para x: ");
            vetor[0] = Int32.Parse(Console.ReadLine());

            Menus.Enunciado("Entre com o valor para y: ");
            vetor[1] = Int32.Parse(Console.ReadLine());

            Menus.Enunciado("Entre com o valor para z: ");
            vetor[2] = Int32.Parse(Console.ReadLine());

            return vetor;
        }
        public static int[,] CriarMatriz()
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Menus.Enunciado("Entre com o valor da posição(" + i + " , " + j + "): ");
                    matriz[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            Menus.MostrarMatriz(matriz);
            return matriz;
        }
        public static int[,] CriarMatrizIdentidade()
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        matriz[i, j] = 1;
                }
            }
            Console.Clear();
            Menus.MostrarMatriz(matriz);
            return matriz;
        }
    }
}
