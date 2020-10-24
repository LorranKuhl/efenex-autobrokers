using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex.decorators
{
    public class VeiculoDecorator 
    {
        readonly Veiculo veiculo;
        public Int64 Id { get => this.veiculo.Id; }

        public VeiculoDecorator(Veiculo veiculo)
        {
            this.veiculo = veiculo;
        }

        public string Descricao
        {
            get
            {
                return $"{this.veiculo.Ano.ToString()}  {this.veiculo.Marca} {this.veiculo.Modelo}";
            }
        }

        public string Valor
        {
            get
            {
                return $"R$ {this.veiculo.Valor}";
            }
        }
    }
}
