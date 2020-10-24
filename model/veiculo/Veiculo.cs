using Efenex.model;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Efenex
{
    public class Veiculo : BaseModel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }

        

        public bool Save()
        {
            var response = Connection.Execute(@$"INSERT INTO {TableName()}(Marca,Ano,Modelo,Placa,Tipo,Valor) VALUES(@Marca,@Ano,@Modelo,@Placa,@Tipo,@Valor)", this);
            return response == 1;
        }
    }
}
