namespace GestaoDeEquipamentos.ConsoleApp
{
    class TelaEquipamento
    {
        public Equipamento[] equipamentos = new Equipamento[100];
        public int contadorEquipamentos = 0;
        public string ApresentarMenu() 
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Escolha a operação desejada");
            Console.WriteLine("1 - Cadastro de Equipamentos");
            Console.WriteLine("2 - Edição de Equipamentos");
            Console.WriteLine("3 - Exclusão de Equipamentos");
            Console.WriteLine("4 - Visualização de Equipamentos");
            Console.WriteLine("5 - Cadastrar Chamado");
            Console.WriteLine("6 - Editar Chamado");
            Console.WriteLine("7 - Excluir Chamado");
            Console.WriteLine("8 - Visualizar Chamado");
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Digite uma opção válida");
            string opcaoEscolhida = Console.ReadLine();

            return opcaoEscolhida;
        }

        public void CadastrarEquipamento() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Cadastrando Equipamento...");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do fabricante do equipamento");
            string fabricante = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o preço de aquisição: R$ ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a data de fabricacao do equipamento: (dd/MM/yyyy)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);
            novoEquipamento.Id = GeradorIds.GerarIdEquipamento();

            equipamentos[contadorEquipamentos++] = novoEquipamento;
        }
        public void EditarEquipamento()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Editando Equipamento...");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            VisualizarEquipamento(false);
            
            Console.Write("Digite o ID do registro que deseja alterar");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do fabricante do equipamento");
            string fabricante = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o preço de aquisição: R$ ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a data de fabricacao do equipamento: (dd/MM/yyyy)");
            DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

            Equipamento novoEquipamento = new Equipamento(nome, fabricante, precoAquisicao, dataFabricacao);

            bool conseguiuEditar = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == idSelecionado) 
                {
                    equipamentos[i].Nome = novoEquipamento.Nome;
                    equipamentos[i].Fabricante = novoEquipamento.Fabricante;
                    equipamentos[i].PrecoAquisicao = novoEquipamento.PrecoAquisicao;
                    equipamentos[i].DataFabricacao = novoEquipamento.DataFabricacao;

                    conseguiuEditar = true;
                }
            }
            if (!conseguiuEditar)
            {
                Console.WriteLine("Houve um erro durante a edição de um registro");
                return; 
            }
            Console.WriteLine("O equipamento foi editado com sucesso");

        }

        public void ExcluirEquipamento()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Excluindo Equipamento...");
            Console.WriteLine("----------------------------------------");


            VisualizarEquipamento(false);

            Console.Write("Digite o ID do registro que deseja alterar");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < equipamentos.Length; i++)
            {
                if (equipamentos[i] == null) continue;

                else if (equipamentos[i].Id == idSelecionado) 
                {
                    equipamentos[i] = null;
                    conseguiuExcluir = true;
                }
            }
            if (!conseguiuExcluir)
            {
                Console.WriteLine("Houve um erro durante a exclusão de um registro");
                return;
            }
            Console.WriteLine("O equipamento foi excluido com sucesso");


        }

        public void VisualizarEquipamento(bool exibirTitulo) 
        {
            if (exibirTitulo) 
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Gestão de Equipamentos");
                Console.WriteLine("----------------------------------------");

                Console.WriteLine("Visualizando Equipamento...");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -11} | {3, -15} | {4, -15} | {5, -10}",
                "Id", "Nome", "Num. Série", "Fabricante", "Preço", "Data de Fabricação"
                );

            for (int i = 0; i < equipamentos.Length; i++)
            {
                Equipamento e = equipamentos[i];

                if (e == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -11} | {3, -15} | {4, -15} | {5, -10}",
                e.Id, e.Nome, e.ObterNumeroSerie(), e.Fabricante, e.PrecoAquisicao.ToString("C2"), e.DataFabricacao.ToShortDateString()
                );


            }

            Console.WriteLine();
        }

        
    }
}
