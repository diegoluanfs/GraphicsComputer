using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Menus
    {
        public static int MainMenu()
        {
            bool res;
            int a, opcao = 0;
            string opcaoIn;
            Console.WriteLine("1 - Trabalhar com vetores\n2 - Trabalhar com matrizes\n0 - Sair.");
            opcaoIn = Console.ReadLine();
            do
            {
                res = int.TryParse(opcaoIn, out a);
                if (res == true)
                {
                    opcao = Int32.Parse(opcaoIn);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Trabalhar com vetores\n2 - Trabalhar com matrizes\n0 - Sair.");
                    opcaoIn = Console.ReadLine();
                }
            } while (!res);
            return opcao;
        }

        public static int ChamaMenuVetor()
        {
            bool res;
            int a, opcao = 0;
            string opcaoIn;
            Console.WriteLine("1 - Calcular o tamanho do vetor; \n2 - Normalizar o vetor;\n3 - Adicionar outro vetor ao que foi lido anteriormente;" +
                "\n4 - Subtrair outro vetor ao que foi lido anteriormente;\n5 - Multiplicar por um escalar;\n6 - Dividir por um escalar;" +
                "\n7 - Calcular o produto escalar do vetor lido anteriormente por outro vetor;\n 0 - Sair.");
            opcaoIn = Console.ReadLine();
            do
            {
                res = int.TryParse(opcaoIn, out a);
                if (res == true)
                {
                    opcao = Int32.Parse(opcaoIn);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Calcular o tamanho do vetor; \n2 - Normalizar o vetor;\n3 - Adicionar outro vetor ao que foi lido anteriormente;" +
                        "\n4 - Subtrair outro vetor ao que foi lido anteriormente;\n5 - Multiplicar por um escalar;\n6 - Dividir por um escalar;" +
                        "\n7 - Calcular o produto escalar do vetor lido anteriormente por outro vetor;\n 0 - Sair.");
                    opcaoIn = Console.ReadLine();
                }
            } while (!res);
            return opcao;
        }

        public static int ChamaMenuMatriz()
        {
            bool res;
            int a, opcao = 0;
            string opcaoIn;
            Console.WriteLine("1 - Adição de outra matriz\n2 - Subtração de outra matriz\n" +
                                "3 - Multiplicação da matriz por um escalar\n4 - Divisão da matriz por um escalar\n" +
                                "5 - Multiplicação da matriz por um vetor\n6 - Multiplicação da matriz por outra matriz\n" +
                                "7 - Gerar a matriz transposta\n 0 - Sair.");
            opcaoIn = Console.ReadLine();
            do
            {
                res = int.TryParse(opcaoIn, out a);
                if (res == true)
                {
                    opcao = Int32.Parse(opcaoIn);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Adição de outra matriz\n2 - Subtração de outra matriz\n" +
                                "3 - Multiplicação da matriz por um escalar\n4 - Divisão da matriz por um escalar\n" +
                                "5 - Multiplicação da matriz por um vetor\n6 - Multiplicação da matriz por outra matriz\n" +
                                "7 - Gerar a matriz transposta\n 0 - Sair.");
                }
            } while (!res);
            return opcao;
        }
        public static void Enunciado(string phrase)
        {
            Console.WriteLine(phrase);
        }
        public static void MostraMatriz(int[,] matrizResp)
        {
            Console.WriteLine("[" + matrizResp[0, 0] + ", " + matrizResp[0, 1] + ", " + matrizResp[0, 2] + "]");
            Console.WriteLine("[" + matrizResp[0, 1] + ", " + matrizResp[1, 1] + ", " + matrizResp[1, 2] + "]");
            Console.WriteLine("[" + matrizResp[0, 2] + ", " + matrizResp[1, 2] + ", " + matrizResp[2, 2] + "]");
        }
    }
}
