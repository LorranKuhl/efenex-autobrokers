using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Efenex.controller
{
    public class BaseController : IBaseController
    {
        protected IDbConnection Connection = DatabaseConnection.Instance;



        public List<object> Index()
        {
            throw new NotImplementedException();
        }

        public object Show(long id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Update(long id, object parametros)
        {
            throw new NotImplementedException();
        }
    }
}
