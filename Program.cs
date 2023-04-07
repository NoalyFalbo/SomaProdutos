
using System;
//sing System.Globalization;

namespace MeuCodigo
{
  class Program
  {
    static void Main(string[] args)
    {

      // Console.Clear();
      //Console.WriteLine("Digite o codigo da peça : ");
      //Console.ReadLine();
      Console.WriteLine("Digite a quantidade de peça : ");
      Console.WriteLine("Digite o valor unitario da peça: ");

      double quantidade, valorUnitario, total, pagar;

      valorUnitario = double.Parse(Console.ReadLine());
      quantidade = double.Parse(Console.ReadLine());
      total = valorUnitario * quantidade;
      pagar = total;

      Console.WriteLine("Valor a pagar R$ " + pagar);

    }
  }
}