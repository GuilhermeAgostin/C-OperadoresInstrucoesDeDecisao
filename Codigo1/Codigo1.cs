using System;

class Codigo1
{
  static void Main()
  {
      int n1, n2, n3, n4, res;
      n1=n2=n3=n4=0;
      string resultado = "reprovado";

      Console.Write("Digite sua primeira nota: . . . . ");
      n1=int.Parse(Console.ReadLine());  
      
      Console.Write("\nDigite sua segunda nota:. . . . . ");
      n2=int.Parse(Console.ReadLine());
      
      Console.Write("\nDigite sua terceira nota: . . . ");
      n3=int.Parse(Console.ReadLine());

      Console.Write("\nDigite sua quarta nota: . . . . ");
      n4=int.Parse(Console.ReadLine());

      res=n1+n2+n3+n4;

      if (res >= 30)
      {
          resultado = "aprovado";
          Console.WriteLine("\nCom uma nota de {0} voce foi {1}!", res, resultado);
      }
      else
      {
          Console.WriteLine("\nCom a nota {0} voce foi {1}!", res, resultado); 
      }

      Console.ReadKey();
  }
}