using Dapper;
using Efenex.model.venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efenex.controller
{
    class VendasController : BaseController
    {
        public List<Venda> Index
        {
            get
            {
                IEnumerable<Venda> vendas = Connection.Query<Venda>("SELECT * FROM vendas"); ;
                return vendas.ToList();
            }
        }

        public object Show(int id)
        {
            Venda venda = new Venda();
            return venda.Find(id);
        }
        public bool Create(Venda parametros)
        {
            Venda venda = new Venda { cliente_id = parametros.cliente_id, vendedor_id= parametros.vendedor_id, veiculo_id= parametros.veiculo_id };
            return venda.Save();
        }


    }
}
