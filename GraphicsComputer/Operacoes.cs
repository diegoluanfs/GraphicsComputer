using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Operacoes
    {
        public static double NormaDoVetor(int opcao, int[] vector)
        {
            double tamanho;
            return tamanho = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
        }
        public static int[,] SomaMatrizes(int[,] matriz, int[,] matriz2)
        {
            int[,] matrizResp = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizResp[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }
            return matrizResp;
        }
        public static int[,] SubtraiMatrizes(int[,] matriz, int[,] matriz2)
        {
            int[,] matrizResp = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizResp[i, j] = matriz[i, j] - matriz2[i, j];
                }
            }
            return matrizResp;
        }
        public static int[,] CriaMatriz()
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
            return matriz;
        }
    }
}
