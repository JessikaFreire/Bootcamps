using System;
using System.Collections.Generic;

namespace Aplicacao_de_Transferencias_Bancarias
{
    class Program
	{
		static List<Conta> listContas = new List<Conta>();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarContas();
						break;
					case "2":
						InserirConta();
						break;
					case "3":
						Transferir();
						break;
					case "4":
						Sacar();
						break;
					case "5":
						Depositar();
						break;
                    case "L":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			Console.WriteLine("\n");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("							Sessão encerrada. Obrigada!"					);
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.ReadLine();
		}

		private static void Depositar()
		{	
			Console.WriteLine("\n");
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.WriteLine("\n");
			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
		}

		private static void Sacar()
		{
			Console.WriteLine("\n");
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.WriteLine("\n");
			Console.Write("Digite o valor a ser sacado: ");
			double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
		}

		private static void Transferir()
		{
			Console.WriteLine("\n");
			Console.Write("Digite o número da conta de origem: ");
			int indiceContaOrigem = int.Parse(Console.ReadLine());

			Console.WriteLine("\n");
            Console.Write("Digite o número da conta de destino: ");
			int indiceContaDestino = int.Parse(Console.ReadLine());

			Console.WriteLine("\n");
			Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
		}

		private static void InserirConta()
		{
			Console.WriteLine("\n");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("Inserir nova conta");

			Console.WriteLine("\n");
			Console.Write("Digite '1' para Conta Fisica ou '2' para Juridica: ");
			int entradaTipoConta = int.Parse(Console.ReadLine());

			Console.WriteLine("\n\n");
			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.WriteLine("\n");
			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.WriteLine("\n");
			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
										saldo: entradaSaldo,
										credito: entradaCredito,
										nome: entradaNome);

			listContas.Add(novaConta);
		}

		private static void ListarContas()
		{	
			Console.WriteLine("\n");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("Listar contas:");

			if (listContas.Count == 0)
			{	
				Console.WriteLine("\n");
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
				Console.Write("({0}) - ", i);
				Console.WriteLine(conta);
			}
		}

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("								Olá, bem-vindo(a) ao Jess Bank!						");
			Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------");
			Console.WriteLine("\n");
			Console.WriteLine("Digite a opção desejada:");
			Console.WriteLine("\n");
			Console.WriteLine("(1) - Listar contas");
			Console.WriteLine("(2) - Inserir nova conta");
			Console.WriteLine("(3) - Transferir");
			Console.WriteLine("(4) - Sacar");
			Console.WriteLine("(5) - Depositar");
            Console.WriteLine("(L) - Limpar Tela");
			Console.WriteLine("(X) - Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
