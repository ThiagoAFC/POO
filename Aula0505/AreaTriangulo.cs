using System; 

public class Program {
  public static void Main(string[] args) {
    Console.WriteLine("Digite um valor para a base do triângulo");
    string s = Console.ReadLine();
    double b = double.Parse(s);
    Console.WriteLine("Digite a altura do triângulo");
    double h = double.Parse(Console.ReadLine());
    double a = (b * h) /2;
    Console.WriteLine(a);
  }
}  