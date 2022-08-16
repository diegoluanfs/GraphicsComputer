using GraphicsComputer;

int [,] matrizIdentidade = new int[3,3];
matrizIdentidade = Itens.CriarMatrizIdentidade();
Menus.MostrarMatriz(matrizIdentidade);

int transformacao = Menus.ChamarMenuTransformacao();
int[] parametros = Menus.ChamarTransformacaoParams(transformacao);
Menus.MostrarVetor(parametros);


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
//    int[] vetor = new int[3];
//    int opcao;
//    vetor = CriaVetor();
//    Console.Clear();
//    opcao = Menus.ChamarMenuVetor();
//    OpcaoEscolhidaVetor(opcao, vetor);
//}
//else if (mainMenu == 2)
//{
//    int[,] matriz = new int[3, 3];
//    int opcao;
//    matriz = Operacoes.CriaMatriz();
//    Console.Clear();
//    opcao = Menus.ChamarMenuMatriz();
//    OpcaoEscolhidaMatriz(opcao, matriz);
//}



