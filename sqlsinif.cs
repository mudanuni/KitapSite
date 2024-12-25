using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace KitapSite
{
    public class sqlsinif
    {
        public SqlConnection baglanti() {

            SqlConnection baglan = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog=KitapSite Integrated Security = True;TrustServerCertificate=True;");
            baglan.Open();
            return baglan;
        }
    }
}