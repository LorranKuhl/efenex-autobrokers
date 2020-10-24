using Dapper;
using Efenex.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efenex
{
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public bool Save()
        {
            var response = Connection.Execute(@$"INSERT INTO {TableName()}(Nome,Cpf,Rg,DataNascimento) VALUES(@Nome,@Cpf,@Rg,@DataNascimento)", this);
            return response == 1;
        }
    }
}
