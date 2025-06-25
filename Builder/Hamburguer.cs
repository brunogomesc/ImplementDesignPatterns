using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hamburguer
    {

        public string TipoPao { get; set; } = string.Empty;

        public string TipoCarne { get; set; } = string.Empty;

        public bool TemBacon { get; set; }

        public bool TemBatataPalha { get; set; }

        public bool TemQueijo { get; set; }

        public bool TemSalada { get; set; }

        public string GetDescricao()
        {
            StringBuilder descricao = new StringBuilder();

            descricao.AppendLine($"Hambúrguer com pão: {TipoPao} ");
            descricao.AppendLine($"com carne: {TipoCarne} ");

            if (TemBacon)
                descricao.AppendLine("com bacon");
            if (TemBatataPalha)
                descricao.AppendLine("com batata palha");
            if(TemQueijo)
                descricao.AppendLine("com queijo");
            if (TemSalada)
                descricao.AppendLine("com salada");

            if (descricao.Length == 0)
                descricao.AppendLine("Nenhum ingrediente adicional.");

            return descricao.ToString();
        }

    }
}
