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
        public static int ChamarMenuVetor()
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
        public static int ChamarMenuMatriz()
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
        public static int ChamarMenuTransformacao()
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
        public static int[] ChamarTransformacaoParams(int param)
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
        public static void MostrarMatriz(int[,] matrizResp)
        {
            Console.WriteLine("[" + matrizResp[0, 0] + ", " + matrizResp[0, 1] + ", " + matrizResp[0, 2] + "]");
            Console.WriteLine("[" + matrizResp[0, 1] + ", " + matrizResp[1, 1] + ", " + matrizResp[1, 2] + "]");
            Console.WriteLine("[" + matrizResp[0, 2] + ", " + matrizResp[1, 2] + ", " + matrizResp[2, 2] + "]");
        }
        public static void MostrarVetor(int[] vetorResp)
        {
            Console.WriteLine("[" + vetorResp[0]+ "]");
            Console.WriteLine("[" + vetorResp[1]+ "]");
            //Console.WriteLine("[" + vetorResp[2]+ "]");
        }



        void OpcaoEscolhidaVetor(int opcao, int[] vetor)
        {
            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Até logo!");
                    break;
                case 1:
                    Console.WriteLine("Bora calcular o tamanho então...");
                    double tamanho = Operacoes.NormaDoVetor(opcao, vetor);
                    Console.WriteLine("Aqui está o resultado: " + tamanho);
                    break;
                case 2:
                    Console.WriteLine("Bora normalizar o vetor...");
                    tamanho = Operacoes.NormaDoVetor(opcao, vetor);

                    double[] vetor2 = new double[3];
                    vetor2[0] = vetor[0] / tamanho;
                    vetor2[1] = vetor[1] / tamanho;
                    vetor2[2] = vetor[2] / tamanho;
                    Console.WriteLine("O vetor normalizado ficou com x, y e z: [" + vetor2[0] + "," + vetor2[1] + "," + vetor2[2] + "]");
                    break;
                case 3:
                    Console.WriteLine("Bora criar mais um vetor...");
                    int[] vetor3 = new int[3];
                    int[] vetor4 = new int[3];
                    vetor3 = Itens.CriarVetor();
                    Console.Clear();
                    Console.WriteLine("Agora, bora somar esses dois. Só um pouco, perdi minha calculadora...");
                    Thread.Sleep(4000);
                    vetor4[0] = vetor[0] + vetor3[0];
                    vetor4[1] = vetor[1] + vetor3[1];
                    vetor4[2] = vetor[2] + vetor3[2];
                    Console.WriteLine("A soma dos vetores resultou em: [" + vetor4[0] + "," + vetor4[1] + "," + vetor4[2] + "]");
                    break;
                case 4:
                    Console.WriteLine("Bora criar mais um vetor...");
                    int[] vetor5, vetor6 = new int[3];
                    vetor5 = Itens.CriarVetor();
                    Console.Clear();
                    Console.WriteLine("Agora, bora subtrair esse vetor. Só um pouco, perdi minha calculadora...");
                    Thread.Sleep(4000);
                    vetor6[0] = vetor[0] - vetor5[0];
                    vetor6[1] = vetor[1] - vetor5[1];
                    vetor6[2] = vetor[2] - vetor5[2];
                    Console.WriteLine("A subtração dos vetores resultou em: [" + vetor6[0] + "," + vetor6[1] + "," + vetor6[2] + "]");
                    break;
                case 5:
                    Console.WriteLine("Entre com o valor de um escalar: ");
                    int escalar = Int32.Parse(Console.ReadLine());
                    vetor[0] = vetor[0] * escalar;
                    vetor[1] = vetor[1] * escalar;
                    vetor[2] = vetor[2] * escalar;
                    Console.WriteLine("A multiplicação do vetor pelo escalar resultou em: [" + vetor[0] + "," + vetor[1] + "," + vetor[2] + "]");
                    break;
                case 6:
                    Console.WriteLine("Entre com o valor de um escalar: ");
                    int escalarDividir = Int32.Parse(Console.ReadLine());
                    vetor[0] = vetor[0] / escalarDividir;
                    vetor[1] = vetor[1] / escalarDividir;
                    vetor[2] = vetor[2] / escalarDividir;
                    Console.WriteLine("A divisão do vetor pelo escalar resultou em: [" + vetor[0] + "," + vetor[1] + "," + vetor[2] + "]");
                    break;
                case 7:
                    Console.WriteLine("Meeee, nem era pra escolher essa função... Deixa eu ver aqui se consigo resolver...");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("Suador, vou te dizer. Mas ok, achei um livro aqui ...");
                    int[] vetor7, vetor8 = new int[3];
                    vetor7 = Itens.CriarVetor();
                    Console.Clear();
                    vetor8[0] = vetor[0] + vetor7[0];
                    vetor8[1] = vetor[1] + vetor7[1];
                    vetor8[2] = vetor[2] + vetor7[2];
                    var sum = vetor8[0] + vetor8[1] + vetor8[2];
                    Console.WriteLine("O produto escalar entre os vetores é: " + sum);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        void OpcaoEscolhidaMatriz(int opcao, int[,] matriz)
        {
            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Até logo!");
                    break;
                case 1:
                    Console.WriteLine("Soma: ");
                    int[,] matriz2 = new int[3, 3];
                    matriz2 = Itens.CriarMatriz();
                    int[,] matrizResp = Operacoes.SomaMatrizes(matriz, matriz2);
                    Console.WriteLine("Aqui está o resultado: ");
                    Menus.MostrarMatriz(matrizResp);
                    break;
                case 2:
                    Console.WriteLine("Subtração: ");
                    int[,] matriz3 = new int[3, 3];
                    matriz2 = Itens.CriarMatriz();
                    int[,] matrizResp2 = Operacoes.SubtraiMatrizes(matriz, matriz3);
                    Console.WriteLine("Aqui está o resultado: ");
                    Menus.MostrarMatriz(matriz2);
                    break;
                case 3:
                    Console.WriteLine("Bora multiplicar por um escalar. Entre com o valor de um escalar: ");
                    int escalar = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matriz[i, j] = matriz[i, j] * escalar;
                        }
                    }
                    Console.WriteLine("Aqui está o resultado: ");
                    Console.WriteLine("[" + matriz[0, 0] + ", " + matriz[0, 1] + ", " + matriz[0, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 1] + ", " + matriz[1, 1] + ", " + matriz[1, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 2] + ", " + matriz[1, 2] + ", " + matriz[2, 2] + "]");
                    break;
                case 4:
                    Console.WriteLine("Bora dividir por um escalar. Entre com o valor de um escalar: ");
                    int escalar2 = Int32.Parse(Console.ReadLine());
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matriz[i, j] = matriz[i, j] * escalar2;
                        }
                    }
                    Console.WriteLine("Aqui está o resultado: ");
                    Console.WriteLine("[" + matriz[0, 0] + ", " + matriz[0, 1] + ", " + matriz[0, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 1] + ", " + matriz[1, 1] + ", " + matriz[1, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 2] + ", " + matriz[1, 2] + ", " + matriz[2, 2] + "]");
                    break;
                case 5:
                    Console.WriteLine("Multiplicação de matriz por vetor: ");
                    int[] vetor9, vetor10 = new int[3];
                    vetor9 = Itens.CriarVetor();

                    for (int i = 0; i < 3; i++)
                    {
                        vetor10[0] = matriz[0, 0] * vetor9[0] + matriz[0, 1] * vetor9[0] + matriz[0, 2] * vetor9[0];
                        vetor10[1] = matriz[1, 0] * vetor9[1] + matriz[1, 1] * vetor9[1] + matriz[1, 2] * vetor9[1];
                        vetor10[2] = matriz[2, 0] * vetor9[2] + matriz[2, 1] * vetor9[2] + matriz[2, 2] * vetor9[2];
                    }

                    Console.WriteLine("Aqui está o resultado: ");
                    Console.WriteLine("[" + vetor10[0] + "]");
                    Console.WriteLine("[" + vetor10[1] + "]");
                    Console.WriteLine("[" + vetor10[2] + "]");
                    break;
                case 6:
                    Console.WriteLine("Multiplicação de matrizes: ");
                    int[,] matriz4 = new int[3, 3];
                    matriz4 = Itens.CriarMatriz();

                    matriz[0, 0] = matriz[0, 0] * matriz4[0, 0] + matriz[0, 1] * matriz4[1, 0] + matriz[0, 2] * matriz4[2, 0];
                    matriz[0, 1] = matriz[0, 0] * matriz4[0, 1] + matriz[0, 1] * matriz4[1, 1] + matriz[0, 2] * matriz4[2, 1];
                    matriz[0, 2] = matriz[0, 0] * matriz4[0, 2] + matriz[0, 1] * matriz4[1, 2] + matriz[0, 2] * matriz4[2, 2];

                    matriz[1, 0] = matriz[1, 0] * matriz4[0, 0] + matriz[1, 1] * matriz4[1, 0] + matriz[1, 2] * matriz4[2, 0];
                    matriz[1, 1] = matriz[1, 0] * matriz4[0, 1] + matriz[1, 1] * matriz4[1, 1] + matriz[1, 2] * matriz4[2, 1];
                    matriz[1, 2] = matriz[1, 0] * matriz4[0, 2] + matriz[1, 1] * matriz4[1, 2] + matriz[1, 2] * matriz4[2, 2];

                    matriz[2, 0] = matriz[2, 0] * matriz4[0, 0] + matriz[1, 1] * matriz4[1, 0] + matriz[2, 2] * matriz4[2, 0];
                    matriz[2, 1] = matriz[2, 0] * matriz4[0, 1] + matriz[1, 1] * matriz4[1, 1] + matriz[2, 2] * matriz4[2, 1];
                    matriz[2, 2] = matriz[2, 0] * matriz4[0, 2] + matriz[1, 1] * matriz4[1, 2] + matriz[2, 2] * matriz4[2, 2];

                    Console.WriteLine("Aqui está o resultado: ");
                    Console.WriteLine("[" + matriz[0, 0] + ", " + matriz[0, 1] + ", " + matriz[0, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 1] + ", " + matriz[1, 1] + ", " + matriz[1, 2] + "]");
                    Console.WriteLine("[" + matriz[0, 2] + ", " + matriz[1, 2] + ", " + matriz[2, 2] + "]");
                    break;
                case 7:
                    Console.WriteLine("Bora montar a matriz transposta: ");
                    int[,] matrizAux = new int[3, 3];

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            matrizAux[j, i] = matriz[i, j];
                        }
                    }

                    Console.WriteLine("Aqui está o resultado: ");
                    Console.WriteLine("[" + matrizAux[0, 0] + ", " + matrizAux[0, 1] + ", " + matrizAux[0, 2] + "]");
                    Console.WriteLine("[" + matrizAux[0, 1] + ", " + matrizAux[1, 1] + ", " + matrizAux[1, 2] + "]");
                    Console.WriteLine("[" + matrizAux[0, 2] + ", " + matrizAux[1, 2] + ", " + matrizAux[2, 2] + "]");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
