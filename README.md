# C#
# Operadores e instruções de decisão

### Operadores

A linguagem fornece vários operadores sendo eles por exemplo:

* Operadores aritméticos que executam operações aritméticas com operandos numéricos
* Operadores de comparação que comparam operandos numéricos
* Operadores lógicos boolianos que executam operações lógicas com bool operandos

A precedência de operador e a associação determinam a ordem em que as operações em uma expressão são executadas. Você pode usar parênteses para alterar a ordem de avaliação imposta pela prioridade e pela associação dos operadores.

Exemplos de expressões que estão no lado direito das atribuições:

```C#
int a, b, c;
a = 7;
b = a;
c = b++;
b = a + b * c;
c = a >= 100 ? b : c / 10;
a = (int)Math.Sqrt(b * b + c * c);

string s = "String literal";
char l = s[s.Length - 1];

var numbers = new List<int>(new[] { 1, 2, 3 });
b = numbers.FindLast(n => n > 1);
```

Expressões de consulta que permitem o uso de recursos de consulta:

```C#
var scores = new[] { 90, 97, 78, 68, 85 };
IEnumerable<int> highScoresQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;
Console.WriteLine(string.Join(" ", highScoresQuery));
// Output:
// 97 90 85
```
Em uma expressão com vários operadores, os operadores com maior precedência são avaliados antes dos operadores com menor precedência. Como por exemplo:

```C#
var a = 2 + 2 * 2;
Console.WriteLine(a); //  output: 6
```

```C#
var a = (2 + 2) * 2;
Console.WriteLine(a); //  output: 8
```
### Instrução de decisão (Binária e Múltipla)

Com a linguagem C# conseguimos empregar uma lógica de tomada de decisões, permitindo que execute  instruções diferentes com base em um conjunto de condições.
A instrução de ramificação usada mais amplamente é a instrução *if* (binária). A instrução *if* usa uma expressão booliana colocada entre parênteses. Se a expressão for verdadeira, o código após a instrução *if* será executado, caso contrário não executará.

Exemplo:

* Adicionar uma instrução *if* para exibir mensagens diferentes com base no valor da variável total

```C#
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

```
*Switch* é uma instrução de seleção (múltipla) que escolhe uma única seção de opção para executar a partir de uma lista de candidatos com base em uma correspondência de padrão com a expressão de correspondência.

Exemplo:

```C#
      int caseSwitch = 1;

      switch (caseSwitch)
      {
          case 1:
              Console.WriteLine("Case 1");
              break;
          case 2:
              Console.WriteLine("Case 2");
              break;
          default:
              Console.WriteLine("Default case");
              break;
      }
   
// The example displays the following output:
//       Case 1

```
