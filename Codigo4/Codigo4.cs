using System;

class Codigo4
{
   static void Main()
   {
       Console.WriteLine("Cafe tamanhos: 1=pequeno 2=medio 3=grande");
       Console.Write("\nSelecione um tamanho: ");
       string str = Console.ReadLine();
       int custo = 0;

       switch (str)
       {
          case "1":
          case "pequeno":
              custo += 25;
              break;
          case "2":
          case "medio":
              custo += 25;
              goto case "1";
          case "3":
          case "grande":
              custo += 50;
              goto case "1";
          default:
              Console.WriteLine("\nSeleção inválida. Por favor selecione 1, 2, ou 3.");
              break;
      }
      if (custo != 0)
      {
          Console.WriteLine("\nPor favor insira {0} centavos.", custo);
      }
      Console.WriteLine("\nObrigado!");
      Console.ReadKey();
   }
}
