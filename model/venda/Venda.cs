using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Efenex.model.venda
{
    // Facade
    class Venda : BaseModel
    {
        private readonly IVeiculo veiculo;
        private readonly IVendedor vendedor;
        public string DataVenda = DateTime.Today.ToString();
        public long veiculo_id { get; set; }
        public long vendedor_id { get; set; }
        public long cliente_id { get; set; }

        public bool Save()
        {
            var response = Connection.Execute(@$"INSERT INTO {TableName()}(DataVenda,vendedor_id,veiculo_id,cliente_id) 
                                                    VALUES(@Data,@VendedorId,@VeiculoId,@ClienteId)",
                                                    new { 
                                                          Data = this.DataVenda,
                                                          VendedorId = this.veiculo_id,
                                                          VeiculoId = this.vendedor_id,
                                                          ClienteId = this.cliente_id
                                                        });
            if (response == 1)
            {

                IVeiculo.MarcarComoVendido(this.veiculo_id);
                IVendedor.RealizarVenda();
                return true;
            }
            return false;
        }
    }
}
