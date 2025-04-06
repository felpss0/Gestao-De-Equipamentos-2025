namespace GestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            ControleChamado controleChamado = new ControleChamado();

            while (true) 
            {
                string opcaoEscolhida = telaEquipamento.ApresentarMenu();    

                switch (opcaoEscolhida)
                {
                    case "1":
                        telaEquipamento.CadastrarEquipamento();
                        break;
                    case "2":
                        telaEquipamento.EditarEquipamento();
                        break;
                    case "3":
                        telaEquipamento.ExcluirEquipamento();
                        break;
                    case "4":
                        telaEquipamento.VisualizarEquipamento(true);
                        break;
                    case "5":
                        controleChamado.RegistrarChamado();
                        break;
                    case "6":
                        controleChamado.EditarChamado();
                        break;
                    case "7":
                        controleChamado.ExcluirChamado();
                        break;
                    case "8":
                        controleChamado.VisualizarChamado(true);
                        break;

                    default:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }


                Console.ReadLine();
            }
            


        }
    }
}
