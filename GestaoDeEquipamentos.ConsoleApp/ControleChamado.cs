namespace GestaoDeEquipamentos.ConsoleApp
{
    class ControleChamado
    {
        public Chamado[] controle = new Chamado[100];
        public int contadorChamados = 0;
        public void RegistrarChamado() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Registrando chamado...");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            Console.WriteLine("Digite o Titulo do chamado");
            string tituloChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a descrição do chamado");
            string descricaoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite qual o equipamento do chamado");
            string equipamentoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a data de abertura do chamado");
            DateTime dataChamado = Convert.ToDateTime(Console.ReadLine());

            Chamado novoChamado = new Chamado(tituloChamado, descricaoChamado, equipamentoChamado, dataChamado);
            novoChamado.Id = GeradorIds.GerarIdChamado();

            controle[contadorChamados++] = novoChamado;
        
        }

        public void EditarChamado() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Visualizando Chamado...");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine();

            VisualizarChamado(false);

            Console.WriteLine("Digite o ID do chamado que deseja alterar");
            int idSelecionadoChamado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o titulo do chamado: ");
            string tituloChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a descrição do chamado: ");
            string descricaoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite qual o equipamento do chamado: ");
            string equipamentoChamado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a data de abertura do chamado: (dd/MM/yyyy)");
            DateTime dataChamado = Convert.ToDateTime(Console.ReadLine());

            Chamado novoChamado = new Chamado(tituloChamado, descricaoChamado, equipamentoChamado, dataChamado);

            bool conseguiuEditarChamado = false;

            for (int i = 0; i < controle.Length; i++) 
            {
                if (controle[i] == null) continue;

                else if (controle[i].Id == idSelecionadoChamado) 
                {
                    controle[i].Titulo = novoChamado.Titulo;
                    controle[i].Descricao = novoChamado.Descricao;
                    controle[i].Equipamento = novoChamado.Equipamento;
                    controle[i].DataAbertura = novoChamado.DataAbertura;

                    conseguiuEditarChamado = true;
                }
            }

            if (!conseguiuEditarChamado) 
            {
                Console.WriteLine("Houve um erro ao editar o chamado");
                return;
            }
            Console.WriteLine("O chamado foi editado com sucesso");
        }

        public void ExcluirChamado() 
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Excluindo Chamado...");
            Console.WriteLine("----------------------------------------");


            VisualizarChamado(false);

            Console.WriteLine("Digite o ID do chamado que deseja excluir");
            int idSelecionadoChamado = Convert.ToInt32(Console.ReadLine());

            bool conseguiuExcluir = false;

            for (int i = 0; i < controle.Length; i++) 
            {
                if (controle[i] == null) continue;

                else if (controle[i].Id == idSelecionadoChamado) 
                {
                    controle[i] = null;
                    conseguiuExcluir = true;
                }
            }
            if (!conseguiuExcluir) 
            {
                Console.WriteLine("Houve um erro durante a exclusão de um chamado");
                return;
            }
            Console.WriteLine("O chamado foi excluido com sucesso");
        }

        public void VisualizarChamado(bool exibirTituloChamado) 
        {
            if (exibirTituloChamado)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Gestão de Chamados");
                Console.WriteLine("----------------------------------------");

                Console.WriteLine("Visualizando Chamado...");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -11} | {3, -15} | {4, -15} | {5, -10}",
                "Id", "Titulo", "Descrição", "Num. Chamado", "Equipamento", "Data de Abertura do chamado"
                );

            for (int i = 0; i < controle.Length; i++)
            {
                Chamado c = controle[i];

                if (c == null) continue;

                Console.WriteLine(
                "{0, -10} | {1, -20} | {2, -11} | {3, -15} | {4, -15} | {5, -10}",
                c.Id, c.Titulo, c.Descricao, c.ObterNumeroChamado(), c.Equipamento, c.DataAbertura
                );


            }

            Console.WriteLine();

        }
    }
}
