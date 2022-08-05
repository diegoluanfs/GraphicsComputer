
int[] vector = new int[3];
int opcao;
vector = CriaVetor();
Console.Clear();
opcao = ChamaMenu();
OpcaoEscolhida(opcao, vector);

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
            Console.WriteLine("Bora criar mais um vetor...");
            int[] vector5, vector6 = new int[3];
            vector5 = CriaVetor();
            Console.Clear();
            Console.WriteLine("Agora, bora subtrair esse vetor. Só um pouco, perdi minha calculadora...");
            Thread.Sleep(4000);
            vector6[0] = vector[0] - vector5[0];
            vector6[1] = vector[1] - vector5[1];
            vector6[2] = vector[2] - vector5[2];
            Console.WriteLine("A subtração dos vetores resultou em: [" + vector6[0] + "," + vector6[1] + "," + vector6[2] + "]");
            break;
        case 5:
            Console.WriteLine("Entre com o valor de um escalar: ");
            int escalar = Int32.Parse(Console.ReadLine());
            vector[0] = vector[0] * escalar;
            vector[1] = vector[1] * escalar;
            vector[2] = vector[2] * escalar;
            Console.WriteLine("A multiplicação do vetor pelo escalar resultou em: [" + vector[0] + "," + vector[1] + "," + vector[2] + "]");
            break;
        case 6:
            Console.WriteLine("Entre com o valor de um escalar: ");
            int escalarDividir = Int32.Parse(Console.ReadLine());
            vector[0] = vector[0] / escalarDividir;
            vector[1] = vector[1] / escalarDividir;
            vector[2] = vector[2] / escalarDividir;
            Console.WriteLine("A divisão do vetor pelo escalar resultou em: [" + vector[0] + "," + vector[1] + "," + vector[2] + "]");
            break;
        case 7:
            Console.WriteLine("Meeee, nem era pra escolher essa função... Deixa eu ver aqui se consigo resolver...");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Suador, vou te dizer. Mas ok, achei um livro aqui ...");
            int[] vector7, vector8 = new int[3];
            vector7 = CriaVetor();
            Console.Clear();
            vector8[0] = vector[0] + vector7[0];
            vector8[1] = vector[1] + vector7[1];
            vector8[2] = vector[2] + vector7[2];
            var sum = vector8[0] + vector8[1] + vector8[2];
            Console.WriteLine("O produto escalar entre os vetores é: " + sum);
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
