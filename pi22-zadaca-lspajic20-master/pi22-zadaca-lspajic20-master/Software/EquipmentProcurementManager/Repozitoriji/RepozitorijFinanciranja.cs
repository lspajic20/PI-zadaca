using DBLayer;
using EquipmentProcurementManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentProcurementManager.Repozitoriji
{
    public class RepozitorijFinanciranja
    {
        public static Financiranje DohvatiFinanciranje(int id)
        {
            Financiranje financiranje = null;
            string sql = $"SELECT * FROM financiranje WHERE idfinanciranje={id}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                financiranje = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return financiranje;
        }

        public static List<Financiranje> DohvatiFinanciranje()
        {
            List<Financiranje> financiranja = new List<Financiranje>();
            string sql = "SELECT idfinanciranje, nazivfinanc FROM financiranje";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Financiranje financiranje = CreateObject(reader);
                financiranja.Add(financiranje);
            }
            reader.Close();
            DB.CloseConnection();
            return financiranja;
        }

        private static Financiranje CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["idfinanciranje"].ToString());
            string naziv = reader["nazivfinanc"].ToString();

            var financiranje = new Financiranje
            {
                idfinanciranje = Id,
                nazivfinanc = naziv
            };

            return financiranje;
        }
    }
}
