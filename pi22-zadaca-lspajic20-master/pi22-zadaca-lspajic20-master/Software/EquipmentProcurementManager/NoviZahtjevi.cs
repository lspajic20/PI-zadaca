using DBLayer;
using EquipmentProcurementManager.Models;
using EquipmentProcurementManager.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentProcurementManager
{
    public partial class NoviZahtjevi : Form
    {
        public NoviZahtjevi()
        {
            InitializeComponent();
        }

        private void NoviZahtjevi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lspajic20_DBDataSet.zaposlenici' table. You can move, or remove it, as needed.
            // this.zaposleniciTableAdapter.Fill(this.lspajic20_DBDataSet.zaposlenici);
            // TODO: This line of code loads data into the 'lspajic20_DBDataSet.financiranje' table. You can move, or remove it, as needed.
            //this.financiranjeTableAdapter.Fill(this.lspajic20_DBDataSet.financiranje);
            List<Zaposlenik> zaposlenici = RepozitorijZaposlenika.DohvatiZaposlenika();
            cboZaposlenici.DataSource = zaposlenici;

            var financiranja = RepozitorijFinanciranja.DohvatiFinanciranje();
            cboFinanciranje.DataSource = financiranja;
        }

        private void btnSpremiPodatke_Click(object sender, EventArgs e)
        {

            var odabraniZaposlenik = cboZaposlenici.SelectedItem as Zaposlenik;
            var odabranoFinanciranje = cboFinanciranje.SelectedItem as Financiranje;
            Zahtjev zahtjev = new Zahtjev
            {
                klasa = txtKlasa.Text.ToString(),
                ubroj = txtUBroj.Text.ToString(),
                idzaposlenik = odabraniZaposlenik.Id,
                opis = txtOpis.Text.ToString(),
                ponuditelj = txtPonuditelj.Text.ToString(),
                cijenaBezPDV = float.Parse(txtCijenaBezPDV.Text.ToString()),
                cijenaSaPDV = float.Parse(txtCijenaSaPDV.Text.ToString()),
                idfinanciranje = odabranoFinanciranje.idfinanciranje
            };
            RepozitorijZahtjeva.UnesiPodatke(zahtjev);
            PostojeciZahtjevFrm postojeciFrm = new PostojeciZahtjevFrm();
            Hide();
            postojeciFrm.ShowDialog();
            Close();

        }
    }
}
