using System;

class Codigo3
{
 static void Main()
  {
    int tempo = 0;
    char letraEscolha ;
    string escolha = ""; 
    
    inicio:
    
    Console.WriteLine("\nDe Belo Horizonte a Sao Paulo\n");  
    Console.WriteLine("\nEscolha um meio de transporte : [a] para aviao, [c] para carro, [o] para onibus\n");
    letraEscolha=char.Parse(Console.ReadLine());  

    switch (letraEscolha)
     {
        case 'a':
            tempo = 50;
            escolha = "aviao";
            break;
        case 'c':
            tempo = 150;
            escolha = "carro";
            break;
        case 'o':
            tempo = 200;
            escolha = "onibus";
            break;
        default:
            tempo = -1;
            break;
     }
    

     if (tempo<0)
     {
        Console.WriteLine("\nO modo meio viagem escolhido correspondente a letra {0} é inválido.\n",letraEscolha);
        Console.WriteLine("\nDeseja tentar novamente? Escolha [s] ou [n]\n");
        letraEscolha=char.Parse(Console.ReadLine());
               
        if(letraEscolha == 's' || letraEscolha == 'S'){goto inicio;}

        else{Console.WriteLine("Fim do programa");}
     }
     else
     {
        Console.WriteLine("\nSua escolha para o meio de transporte foi {0} que corresponde a letra {1}.\n", escolha,letraEscolha);
        Console.WriteLine("\nPara o meio de transporte escolhido a duração é de {0} minutos.\n", tempo);
        Console.WriteLine("\nDeseja escolher outro meio de transporte? Escolha [s] ou [n]\n");
        letraEscolha=char.Parse(Console.ReadLine());

        if(letraEscolha == 's' || letraEscolha == 'S' ){goto inicio;}

        else{Console.WriteLine("\nFim do programa");}
     }
  }
}