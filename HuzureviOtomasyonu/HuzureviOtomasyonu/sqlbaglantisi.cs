using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuzureviOtomasyonu
{
    internal class sqlbaglantisi
    {
       
        public SqlConnection baglanti()
            {
                //fonksiyonların database'e bağlanması saylayan method
         SqlConnection baglan = new SqlConnection(@"Data Source=.;Initial Catalog=huzureviOtomasyonudbo;Integrated Security=True");
                //yukarda database'in yolunu belirtiyor
         baglan.Open();
                //database'e bağlanıyor
         return baglan;
            }
    }
    

}
