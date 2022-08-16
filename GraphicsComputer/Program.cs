using GraphicsComputer;

int [,] matrizIdentidade = new int[3,3];
matrizIdentidade = Operacoes.CriaMatrizIdentidade();
Menus.MostraMatriz(matrizIdentidade);

int transformacao = Menus.ChamaTransformacao();
int[] parametros = Menus.ChamaTransformacaoParams(transformacao);
Menus.MostraVetor(parametros);


//Desenvolva uma aplicação que inicialize uma matriz de transformações (matT), inicialmente com valores de modo que ela seja 
//uma matriz identidade. Em seguida, apresente ao usuário um menu para que ele escolha que transformação ele deseja aplicar sobre 
//o objeto (translação, rotação ou escala), passando seus parâmetros (valores de translação tx e ty, ângulo de rotação e fatores de 
//    escala sx e sy) de acordo com a opção escolhida. Então, monte a matriz referente a transformação escolhida, multiplique ela pela 
//    matriz de transformações (matT), e então substitua os valores de matT pelo resultado. Após, apresente novamente matT na tela (agora 
//    com valores atualizados), seguida do menu. A ideia é ir acumulando as várias transformações em matT, conforme o desejo do usuário. A 
//    imagem abaixo mostra como o menu inicial deve ficar.




//int mainMenu = Menus.MainMenu();
//
//if (mainMenu == 1)
//{
//    int[] vector = new int[3];
//    int opcao;
//    vector = CriaVetor();
//    Console.Clear();
//    opcao = Menus.ChamaMenuVetor();
//    OpcaoEscolhidaVetor(opcao, vector);
//}
//else if (mainMenu == 2)
//{
//    int[,] matriz = new int[3, 3];
//    int opcao;
//    matriz = Operacoes.CriaMatriz();
//    Console.Clear();
//    opcao = Menus.ChamaMenuMatriz();
//    OpcaoEscolhidaMatriz(opcao, matriz);
//}

void OpcaoEscolhidaVetor(int opcao, int[] vector)
{
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Até logo!");
            break;
        case 1:
            Console.WriteLine("Bora calcular o tamanho então...");
            double tamanho = Operacoes.NormaDoVetor(opcao, vector);
            Console.WriteLine("Aqui está o resultado: " + tamanho);
            break;
        case 2:
            Console.WriteLine("Bora normalizar o vetor...");
            tamanho = Operacoes.NormaDoVetor(opcao, vector);

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
            matriz2 = Operacoes.CriaMatriz();
            int[,] matrizResp = Operacoes.SomaMatrizes(matriz, matriz2);
            Console.WriteLine("Aqui está o resultado: ");
            Menus.MostraMatriz(matrizResp);
            break;
        case 2:
            Console.WriteLine("Subtração: ");
            int[,] matriz3 = new int[3, 3];
            matriz2 = Operacoes.CriaMatriz();
            int[,] matrizResp2 = Operacoes.SubtraiMatrizes(matriz, matriz3);
            Console.WriteLine("Aqui está o resultado: ");
            Menus.MostraMatriz(matriz2);
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
            int[] vector9, vector10 = new int[3];
            vector9 = CriaVetor();

            for (int i = 0; i < 3; i++)
            {
                vector10[0] = matriz[0, 0] * vector9[0] + matriz[0, 1] * vector9[0] + matriz[0, 2] * vector9[0];
                vector10[1] = matriz[1, 0] * vector9[1] + matriz[1, 1] * vector9[1] + matriz[1, 2] * vector9[1];
                vector10[2] = matriz[2, 0] * vector9[2] + matriz[2, 1] * vector9[2] + matriz[2, 2] * vector9[2];
            }

            Console.WriteLine("Aqui está o resultado: ");
            Console.WriteLine("[" + vector10[0] + "]");
            Console.WriteLine("[" + vector10[1] + "]");
            Console.WriteLine("[" + vector10[2] + "]");
            break;
        case 6:
            Console.WriteLine("Multiplicação de matrizes: ");
            int[,] matriz4 = new int[3, 3];
            matriz4 = Operacoes.CriaMatriz();

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

int[] CriaVetor()
{
    int[] vector = new int[3];

    Menus.Enunciado("Entre com o valor para x: ");
    vector[0] = Int32.Parse(Console.ReadLine());

    Menus.Enunciado("Entre com o valor para y: ");
    vector[1] = Int32.Parse(Console.ReadLine());

    Menus.Enunciado("Entre com o valor para z: ");
    vector[2] = Int32.Parse(Console.ReadLine());

    return vector;
}


