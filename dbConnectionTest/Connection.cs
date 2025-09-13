using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbConnectionTest
{
    internal class Connection:DbConnection
    {
        SqlConnection ss = new SqlConnection();

    }
}
