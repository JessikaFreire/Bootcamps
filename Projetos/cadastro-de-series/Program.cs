using System;

namespace cadastro_de_series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "L":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

            Console.WriteLine("\n\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
			Console.WriteLine("Sessão encerrada. Obrigada!");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
			Console.ReadLine();
        }

        private static void ExcluirSerie()
		{
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceSerie);
		}

        private static void VisualizarSerie()
		{
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			var serie = repositorio.RetornaPorId(indiceSerie);

			Console.WriteLine(serie);
		}

        private static void AtualizarSerie()
		{
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}

            Console.WriteLine("\n");
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.WriteLine("\n");
			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie atualizaSerie = new Serie(id: indiceSerie,
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Atualiza(indiceSerie, atualizaSerie);
		}
        private static void ListarSeries()
		{
            Console.WriteLine("\n\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
			Console.WriteLine("Listar séries");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
                Console.WriteLine("\n");
				Console.WriteLine("Nenhuma série cadastrada.");
                Console.WriteLine("\n");
				return;
			}

			foreach (var serie in lista)
			{
                var excluido = serie.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
			}
		}

        private static void InserirSerie()
		{
            Console.WriteLine("\n\n");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
			Console.WriteLine("Inserir nova série");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
            Console.WriteLine("\n");
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
			Console.Write("Digite o Título da Série: ");
			string entradaTitulo = Console.ReadLine();

            Console.WriteLine("\n");
			Console.Write("Digite o Ano de Início da Série: ");
			int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
			Console.Write("Digite a Descrição da Série: ");
			string entradaDescricao = Console.ReadLine();

			Serie novaSerie = new Serie(id: repositorio.ProximoId(),
										genero: (Genero)entradaGenero,
										titulo: entradaTitulo,
										ano: entradaAno,
										descricao: entradaDescricao);

			repositorio.Insere(novaSerie);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
			Console.WriteLine("JESSFLIX");
			Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("\n");      
			Console.WriteLine("(1) - Listar séries");
			Console.WriteLine("(2) - Inserir nova série");
			Console.WriteLine("(3) - Atualizar série");
			Console.WriteLine("(4) - Excluir série");
			Console.WriteLine("(5) - Visualizar série");
			Console.WriteLine("(L) - Limpar Tela");
			Console.WriteLine("(X) - Sair");
            Console.WriteLine("\n");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
        }
    }
}
