﻿
namespace GestaoDeEquipamentos.ConsoleApp
{
    public static class GeradorIds
    {
        public static int IdEquipamentos = 0;
        public static int IdChamado = 0;

        public static int GerarIdEquipamento() 
        {
            IdEquipamentos++;

            return IdEquipamentos;
        }

        //public static Guid GerarGuidEquipamento() 
        //{
        //    return Guid.NewGuid();
        //}


        public static int GerarIdChamado() 
        {
            IdChamado++;

            return IdChamado;
        }
    }
}
