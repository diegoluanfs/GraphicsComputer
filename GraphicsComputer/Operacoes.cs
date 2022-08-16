using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Operacoes
    {
        public static double NormaDoVetor(int opcao, int[] vetor)
        {
            double tamanho;
            return tamanho = Math.Sqrt(vetor[0] * vetor[0] + vetor[1] * vetor[1] + vetor[2] * vetor[2]);
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
    }
}
