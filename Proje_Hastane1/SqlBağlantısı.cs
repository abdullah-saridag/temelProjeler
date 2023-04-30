using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
    

namespace Proje_Hastane1
{
    internal class SqlBağlantısı 
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-HP3VQE32;Initial Catalog=hastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
