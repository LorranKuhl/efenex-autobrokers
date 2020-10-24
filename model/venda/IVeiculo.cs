using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Efenex.model.venda
{
    public interface IVeiculo
    {
        public static bool MarcarComoVendido(long id)
        {
            var res = DatabaseConnection.Instance.Execute("UPDATE veiculos SET vendido='S' WHERE Id=@Id", new { Id = id });
            return res == 1;
        }
    }
}
