using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;

namespace EquipmentProcurementManager
{
    public partial class LoginFrm : Form
    {
        string korime = "zaposlenik";
        string lozinka = "test";

        public LoginFrm()
        {
            InitializeComponent();
        }



        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (txtKorIme.Text == korime && txtLozinka.Text == lozinka)
                {
                    PostojeciZahtjevFrm postojeciFrm = new PostojeciZahtjevFrm();
                    Hide();
                    postojeciFrm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci, pokušajte ponovo!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
