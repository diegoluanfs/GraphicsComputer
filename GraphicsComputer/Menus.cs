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
        public static int ChamaTransformacao()
        {
            bool res;
            int a, opcao = 0;
            string opcaoIn;
            Console.WriteLine("1 - Translação\n2 - Rotação\n" +
                                "3 - Escala\n 0 - Sair.");
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
                    Console.WriteLine("1 - Translação\n2 - Rotação\n" +
                                "3 - Escala\n 0 - Sair.");
                }
            } while (!res);
            return opcao;
        }
        public static int[] ChamaTransformacaoParams(int param)
        {
            string paramString = "";
            if (param == 1)
            {
                paramString = "translação";
            }
            else if (param == 2)
            {
                paramString = "rotação";
            }
            else if (param == 3)
            {
                paramString = "escala";
            }
            bool resX, resY;
            int a, opcaoX = 0, opcaoY = 0;
            int[] opcao = new int[2];
            string opcaoInX, opcaoInY;
            //Console.Clear();
            Console.WriteLine("Entre com os parâmetros de " + paramString + " em x:");
            opcaoInX = Console.ReadLine();
            do
            {
                resX = int.TryParse(opcaoInX, out a);
                if (resX == true)
                {
                    opcaoX = Int32.Parse(opcaoInX);
                    opcao[0] = opcaoX;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Translação\n2 - Rotação\n" +
                                "3 - Escala\n 0 - Sair.");
                }
            } while (!resX);
            //Console.Clear();
            Console.WriteLine("Entre com os parâmetros de " + paramString + " em y:");
            opcaoInY = Console.ReadLine();
            do
            {
                resY = int.TryParse(opcaoInY, out a);
                if (resY == true)
                {
                    opcaoY = Int32.Parse(opcaoInY);
                    opcao[1] = opcaoY;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1 - Translação\n2 - Rotação\n" +
                                "3 - Escala\n 0 - Sair.");
                }
            } while (!resY);
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
        public static void MostraVetor(int[] vetorResp)
        {
            Console.WriteLine("[" + vetorResp[0]+ "]");
            Console.WriteLine("[" + vetorResp[1]+ "]");
            //Console.WriteLine("[" + vetorResp[2]+ "]");
        }
    }
}
