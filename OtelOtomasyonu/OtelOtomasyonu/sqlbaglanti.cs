using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyonu
{
    internal class sqlbaglanti
    {
        public SqlConnection Baglanti() 
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G1H3THT;Initial Catalog=Otel;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
