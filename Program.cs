using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(0150, 360987);
            Cliente cliente = new Cliente();

            cliente.Nome = "José Carlos";
            cliente.CPF = "438.022.044.25";
            cliente.Profissao = "Engenheiro de Software";

            conta.Saldo = 100;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Titular.CPF);
            Console.WriteLine(conta.Saldo);
            Console.WriteLine(ContaCorrente.Count);

            Console.ReadLine();
        }
    }
}
