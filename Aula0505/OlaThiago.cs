using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Digite seu primeiro nome");
    string s = Console.ReadLine();
    Console.WriteLine("Olá, " + s);
    
    Console.WriteLine("Digite seu nome completo");
    string x = Console.ReadLine();
    string[] nomes = x.Split(' ');
    Console.WriteLine("Olá, " + nomes[0]);
  }
}