using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_KAB_GROBOGAN.Setup
{
    class DBConnection
    {
        public SqlConnection conn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = MandhegParkingSystem; Integrated Security = True");
    }
}
