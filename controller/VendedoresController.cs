using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using Efenex.model;

namespace Efenex.controller
{
    class VendedoresController : BaseController
    {
        public List<Vendedor> Index
        {
            get
            {
                IEnumerable<Vendedor> clientes = Connection.Query<Vendedor>("SELECT * FROM vendedors");
                return clientes.ToList();
            }
        }

    }
}
