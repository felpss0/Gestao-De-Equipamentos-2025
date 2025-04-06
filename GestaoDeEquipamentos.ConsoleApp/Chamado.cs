namespace GestaoDeEquipamentos.ConsoleApp
{
    class Chamado
    {
        public int Id;
        public string Titulo;
        public string Descricao;
        public string Equipamento;
        public DateTime DataAbertura;
        public Chamado(string titulo, string descricao, string equipamento, DateTime dataAbertura) 
        {
            Titulo = titulo;
            Descricao = descricao;
            Equipamento = equipamento;
            DataAbertura = dataAbertura;
        }

        public string ObterNumeroChamado()
        {
            string tresPrimeirosCaracteres = Titulo.Substring(0, 3).ToUpper();

            return $"{tresPrimeirosCaracteres}-{Id}";
        }
    }
}
