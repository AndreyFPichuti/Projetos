using System;

class Program {
  
  static bool fibonaci(int num) {
    int a = 0;
    int b = 1;
    while (b < num) {
      int temp = a;
      a = b;
      b = temp + b;
    }
    if(b == num) {
      return true;
    } else {
      return false;
    }
  }
  public static void Main (string[] args) {
    Console.WriteLine("Digite um número inteiro: ");
    int numero = int.Parse(Console.ReadLine());

    if(fibonaci(numero)) {
      Console.WriteLine($"O número {numero} pertence à sequência fibonacci!");
    } else {
      Console.WriteLine($"O número {numero} não pertence à sequência fibonacci!");
    }
  }
}