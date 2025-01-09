using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using EquipmentProcurementManager.Models;

namespace EquipmentProcurementManager.Repozitoriji
{
    public class RepozitorijZahtjeva
    {
        

        public static Zahtjev DohvatiZahtjev(int id)
        {
            Zahtjev zahtjev = null;

            string sql = $"SELECT * FROM novizahtjev WHERE idzahtjeva={id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;
        }
        public static List<Zahtjev> DohvatiZahtjev()
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            string sql = "SELECT *, idfinanciranje, idzaposlenik FROM novizahtjev ORDER BY idzahtjeva";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }

        public static List<Zahtjev> PretragaZahtjeva(int id)
        {
            List<Zahtjev> zahtjevi = new List<Zahtjev>();

            string sql = $"SELECT *, idfinanciranje, idzaposlenik FROM novizahtjev WHERE idzahtjeva = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zahtjev zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }
        private static Zahtjev CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["idzahtjeva"].ToString());
            string klasa = reader["klasa"].ToString();
            string ubroj = reader["ubroj"].ToString();
          //  DateTime datum = DateTime.ParseExact(reader["datum"].ToString());

            //int idZaposlenici = int.Parse(reader["idzaposlenik"].ToString());
            //var zaposlenik = RepozitorijZaposlenika.DohvatiZaposlenika(idZaposlenici);
            int idzaposlenik = int.Parse(reader["idzaposlenik"].ToString());
           
            string opis = reader["opis"].ToString();
            string ponuditelj = reader["ponuditelj"].ToString();
            float cijenabezpdv = float.Parse(reader["cijenaBezPDV"].ToString());
            float cijenasapdv = float.Parse(reader["cijenasaPDV"].ToString());
           // bool ponudaodabrana = bool.Parse(reader["ponudaodabrana"].ToString());

            //int idFinanciranje = int.Parse(reader["idfinanciranje"].ToString());
            //var financiranje = RepozitorijFinanciranja.DohvatiFinanciranje(idFinanciranje);
            int idfinanciranje = int.Parse(reader["idfinanciranje"].ToString());

            var zahtjev = new Zahtjev
            {
                idzahtjeva = id,
                klasa = klasa,
                ubroj = ubroj,
              //  datum = datum,
                idzaposlenik = idzaposlenik,
                opis = opis,
                ponuditelj = ponuditelj,
                cijenaBezPDV = cijenabezpdv,
                cijenaSaPDV = cijenasapdv,
              //  ponudaodabrana = ponudaodabrana,
                idfinanciranje= idfinanciranje
            };

            return zahtjev;
        }
        public static void UnesiPodatke(Zahtjev z)
        {
            string sql = $"INSERT INTO novizahtjev (klasa, ubroj, idzaposlenik, opis, ponuditelj, cijenaBezPDV, cijenaSaPDV, idfinanciranje) VALUES ('{z.klasa}','{z.ubroj}',{z.idzaposlenik},'{z.opis}','{z.ponuditelj}',{z.cijenaBezPDV},{z.cijenaSaPDV},{z.idfinanciranje})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void BrisanjeZahtjeva(int id)
        {
            string sql = $"DELETE FROM novizahtjev WHERE idzahtjeva = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
