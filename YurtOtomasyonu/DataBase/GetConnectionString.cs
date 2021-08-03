using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YurtOtomasyonu.DataBase
{
    class GetConnectionString
    {
        public SqlConnection BaglantiAdresi()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=KI\SQLDEVELOPER;Initial Catalog=YurtOtomasyonu;Integrated Security=True");
            return baglanti;
        }

    }
}
