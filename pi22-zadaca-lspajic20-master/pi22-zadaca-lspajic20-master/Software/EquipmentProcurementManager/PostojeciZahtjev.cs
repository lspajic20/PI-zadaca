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
    public partial class PostojeciZahtjevFrm : Form
    {
     
        public PostojeciZahtjevFrm()
        {
            InitializeComponent();
        }

        private void PostojeciZahtjevFrm_Load(object sender, EventArgs e)
        {
            PrikazPodataka();
        }

        private void PrikazPodataka()
        {
             
            List<Zahtjev> zahtjevi = RepozitorijZahtjeva.DohvatiZahtjev();
            dgvPostZahtjev.DataSource = zahtjevi;
        }

        private void btnKreirajNoviZahtjev_Click(object sender, EventArgs e)
        {
            NoviZahtjevi noviFrm = new NoviZahtjevi();
            Hide();
            noviFrm.ShowDialog();
            Close();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var idPretraga = int.Parse(txtPretraga.Text);
            var zahtjev = RepozitorijZahtjeva.PretragaZahtjeva(idPretraga);
            dgvPostZahtjev.DataSource = zahtjev;
        }

      private void btnBrisanje_Click(object sender, EventArgs e)
        {
            Zahtjev zahtjevi = dgvPostZahtjev.CurrentRow.DataBoundItem as Zahtjev;
            var idZahtjev = zahtjevi.idzahtjeva;
            RepozitorijZahtjeva.BrisanjeZahtjeva(idZahtjev);
            PrikazPodataka();
        }

      
    }
}
