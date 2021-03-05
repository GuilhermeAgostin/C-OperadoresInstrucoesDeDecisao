using System;

class Codigo2
{
  static void Main()
  {
    int tempo = 0;
    char letraEscolha ;
    string escolha = ""; 
    
    Console.WriteLine("De Belo Horizonte a Sao Paulo");  
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

     if (tempo<0){Console.WriteLine("\nO modo de viagem escolhido correspondente a letra {0} é inválido.",letraEscolha);}

     else
     {
         Console.WriteLine("\nSua escolha para um meio de transporte foi {0} que corresponde a letra {1}.\n", escolha,letraEscolha);
         Console.WriteLine("\nPara o modo de viagem escolhido a duração é de {0} minutos.", tempo);
     }

     Console.ReadKey();
  }
}