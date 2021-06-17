using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.Data
{
    public class SQLConnConfig
    {

        public string Value { get;  }

        public SQLConnConfig(string value) => Value = value;





    }
}
