/*
Desenvolva um programa que leia pelo teclado os valores x, y e z de um vetor de 3 dimensões (ou preencha com valores aleatórios). 
Em seguida, apresente ao usuário um menu com as seguintes opções:

Calcular o tamanho do vetor;
Normalizar o vetor, apresentando o vetor resultante da normalização;
Adicionar outro vetor ao que foi lido anteriormente, lendo os valores x, y e z deste novo vetor;
Subtrair outro vetor ao que foi lido anteriormente, lendo os valores x, y e z deste novo vetor;
Ler o valor de um escalar e realizar a multiplicação do mesmo pelo vetor, mostrando o vetor resultante;
Ler o valor de um escalar e realizar a divisão do mesmo pelo vetor, mostrando o vetor resultante;
Calcular o produto escalar do vetor lido anteriormente por outro vetor, lendo os valores x, y e z deste novo vetor e mostrando o resultado na tela.
Desenvolva um programa que leia pelo teclado os valores de uma matriz 3x3 (ou preencha com valores aleatórios), e então apresente um menu com as seguintes opções:

Adição e subtração de outra matriz, lendo os valores dessa outra matriz 3x3 e mostrando o resultado na tela;
Multiplicação e Divisão de um escalar lido pelo teclado;
Multiplicação da matriz por um vetor de 3 elementos, este lido pelo teclado;
Multiplicação da matriz por outra matriz 3x3, esta lida pelo teclado;
Apresentar a transposta da matriz lida inicialmente.
 */

int[] vector = new int[3];
int opcao;
vector = CriaVetor();
Console.Clear();
opcao = ChamaMenu();
OpcaoEscolhida(opcao, vector);

//for(int i = 0; i < vector.Length; i++)
//{
//    Console.WriteLine(vector[i]);
//    vector[i] = i;
//}

void OpcaoEscolhida(int opcao, int[] vector)
{
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Até logo!");
            break;
        case 1:
            Console.WriteLine("Bora calcular o tamanho então...");
            double tamanho = NormaDoVetor(opcao, vector);
            Console.WriteLine("Aqui está o resultado: " + tamanho);
            break;
        case 2:
            Console.WriteLine("Bora normalizar o vetor...");
            tamanho = NormaDoVetor(opcao, vector);

            double[] vector2 = new double[3];
            vector2[0] = vector[0] / tamanho; 
            vector2[1] = vector[1] / tamanho; 
            vector2[2] = vector[2] / tamanho; 
            Console.WriteLine("O vetor normalizado ficou com x, y e z: [" + vector2[0] + "," + vector2[1] + "," + vector2[2] + "]");
            break;
        case 3:
            Console.WriteLine("Bora criar mais um vetor...");
            int[] vector3, vector4 = new int[3];
            vector3 = CriaVetor();
            Console.Clear();
            Console.WriteLine("Agora, bora somar esses dois. Só um pouco, perdi minha calculadora...");
            Thread.Sleep(4000);
            vector4[0] = vector[0] + vector3[0];
            vector4[1] = vector[1] + vector3[1];
            vector4[2] = vector[2] + vector3[2];
            Console.WriteLine("A soma dos vetores resultou em: [" + vector4[0] + "," + vector4[1] + "," + vector4[2] + "]");
            break;
        case 4:
            Console.WriteLine("Case 4");
            break;
        case 5:
            Console.WriteLine("Case 5");
            break;
        case 6:
            Console.WriteLine("Case 6");
            break;
        case 7:
            Console.WriteLine("Case 7");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

double NormaDoVetor(int opcao, int[] vector)
{
    double tamanho;
    return tamanho = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
}

int ChamaMenu()
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

int[] CriaVetor()
{
    int[] vector = new int[3];

    Enunciado("Entre com o valor para x: ");
    vector[0] = Int32.Parse(Console.ReadLine());

    Enunciado("Entre com o valor para y: ");
    vector[1] = Int32.Parse(Console.ReadLine());

    Enunciado("Entre com o valor para z: ");
    vector[2] = Int32.Parse(Console.ReadLine());

    return vector;
}

void Enunciado(string phrase)
{
    Console.WriteLine(phrase);
}
