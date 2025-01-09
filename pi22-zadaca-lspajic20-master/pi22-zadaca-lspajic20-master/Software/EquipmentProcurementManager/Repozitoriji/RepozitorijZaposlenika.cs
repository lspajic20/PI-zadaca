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
    public class RepozitorijZaposlenika
    {
        public static Zaposlenik DohvatiZaposlenika(int id)
        {
            Zaposlenik zaposlenik = null;
            string sql = $"SELECT * FROM zaposlenici WHERE idzaposlenik={id}";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return zaposlenik;
        }
        public static List<Zaposlenik> DohvatiZaposlenika()
        {
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            string sql = "SELECT * FROM zaposlenici";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zaposlenik zaposlenik = CreateObject(reader);
                zaposlenici.Add(zaposlenik);
            }
            reader.Close();
            DB.CloseConnection();
            return zaposlenici;
        }
        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idzaposlenik"].ToString());
            string korime = reader["korisnickoime"].ToString();
            string lozinka = reader["lozinka"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = id,
                korisnickoime = korime,
                lozinka = lozinka
            };

            return zaposlenik;
        }
    }
}
