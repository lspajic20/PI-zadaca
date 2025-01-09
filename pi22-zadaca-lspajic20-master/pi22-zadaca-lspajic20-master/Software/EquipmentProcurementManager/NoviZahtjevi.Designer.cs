namespace EquipmentProcurementManager
{
    partial class NoviZahtjevi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKlasa = new System.Windows.Forms.TextBox();
            this.txtUBroj = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtPonuditelj = new System.Windows.Forms.TextBox();
            this.txtCijenaSaPDV = new System.Windows.Forms.TextBox();
            this.txtCijenaBezPDV = new System.Windows.Forms.TextBox();
            this.cboZaposlenici = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lspajic20_DBDataSet = new EquipmentProcurementManager.lspajic20_DBDataSet();
            this.cboFinanciranje = new System.Windows.Forms.ComboBox();
            this.financiranjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financiranjeTableAdapter = new EquipmentProcurementManager.lspajic20_DBDataSetTableAdapters.financiranjeTableAdapter();
            this.zaposleniciTableAdapter = new EquipmentProcurementManager.lspajic20_DBDataSetTableAdapters.zaposleniciTableAdapter();
            this.btnSpremiPodatke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lspajic20_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financiranjeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubroj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zaposlenik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opis predmeta nabave:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ponuditelj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cijena sa PDV-om:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ciejna bez PDV-a:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Izvor financiranja:";
            // 
            // txtKlasa
            // 
            this.txtKlasa.Location = new System.Drawing.Point(71, 17);
            this.txtKlasa.Name = "txtKlasa";
            this.txtKlasa.Size = new System.Drawing.Size(100, 22);
            this.txtKlasa.TabIndex = 10;
            // 
            // txtUBroj
            // 
            this.txtUBroj.Location = new System.Drawing.Point(71, 55);
            this.txtUBroj.Name = "txtUBroj";
            this.txtUBroj.Size = new System.Drawing.Size(100, 22);
            this.txtUBroj.TabIndex = 11;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(175, 192);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(100, 22);
            this.txtOpis.TabIndex = 13;
            // 
            // txtPonuditelj
            // 
            this.txtPonuditelj.Location = new System.Drawing.Point(175, 230);
            this.txtPonuditelj.Name = "txtPonuditelj";
            this.txtPonuditelj.Size = new System.Drawing.Size(100, 22);
            this.txtPonuditelj.TabIndex = 14;
            // 
            // txtCijenaSaPDV
            // 
            this.txtCijenaSaPDV.Location = new System.Drawing.Point(175, 304);
            this.txtCijenaSaPDV.Name = "txtCijenaSaPDV";
            this.txtCijenaSaPDV.Size = new System.Drawing.Size(100, 22);
            this.txtCijenaSaPDV.TabIndex = 16;
            // 
            // txtCijenaBezPDV
            // 
            this.txtCijenaBezPDV.Location = new System.Drawing.Point(175, 270);
            this.txtCijenaBezPDV.Name = "txtCijenaBezPDV";
            this.txtCijenaBezPDV.Size = new System.Drawing.Size(100, 22);
            this.txtCijenaBezPDV.TabIndex = 17;
            // 
            // cboZaposlenici
            // 
            this.cboZaposlenici.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zaposleniciBindingSource, "idzaposlenik", true));
            this.cboZaposlenici.DataSource = this.zaposleniciBindingSource;
            this.cboZaposlenici.DisplayMember = "korisnickoime";
            this.cboZaposlenici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZaposlenici.FormattingEnabled = true;
            this.cboZaposlenici.Location = new System.Drawing.Point(113, 144);
            this.cboZaposlenici.Name = "cboZaposlenici";
            this.cboZaposlenici.Size = new System.Drawing.Size(121, 24);
            this.cboZaposlenici.TabIndex = 19;
            this.cboZaposlenici.ValueMember = "idzaposlenik";
            // 
            // zaposleniciBindingSource
            // 
            this.zaposleniciBindingSource.DataMember = "zaposlenici";
            this.zaposleniciBindingSource.DataSource = this.lspajic20_DBDataSet;
            // 
            // lspajic20_DBDataSet
            // 
            this.lspajic20_DBDataSet.DataSetName = "lspajic20_DBDataSet";
            this.lspajic20_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboFinanciranje
            // 
            this.cboFinanciranje.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.financiranjeBindingSource, "idfinanciranje", true));
            this.cboFinanciranje.DataSource = this.financiranjeBindingSource;
            this.cboFinanciranje.DisplayMember = "nazivfinanc";
            this.cboFinanciranje.FormattingEnabled = true;
            this.cboFinanciranje.Location = new System.Drawing.Point(154, 377);
            this.cboFinanciranje.Name = "cboFinanciranje";
            this.cboFinanciranje.Size = new System.Drawing.Size(573, 24);
            this.cboFinanciranje.TabIndex = 20;
            this.cboFinanciranje.ValueMember = "idfinanciranje";
            // 
            // financiranjeBindingSource
            // 
            this.financiranjeBindingSource.DataMember = "financiranje";
            this.financiranjeBindingSource.DataSource = this.lspajic20_DBDataSet;
            // 
            // financiranjeTableAdapter
            // 
            this.financiranjeTableAdapter.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // btnSpremiPodatke
            // 
            this.btnSpremiPodatke.Location = new System.Drawing.Point(626, 410);
            this.btnSpremiPodatke.Name = "btnSpremiPodatke";
            this.btnSpremiPodatke.Size = new System.Drawing.Size(162, 37);
            this.btnSpremiPodatke.TabIndex = 21;
            this.btnSpremiPodatke.Text = "Spremi podatke";
            this.btnSpremiPodatke.UseVisualStyleBackColor = true;
            this.btnSpremiPodatke.Click += new System.EventHandler(this.btnSpremiPodatke_Click);
            // 
            // NoviZahtjevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.btnSpremiPodatke);
            this.Controls.Add(this.cboFinanciranje);
            this.Controls.Add(this.cboZaposlenici);
            this.Controls.Add(this.txtCijenaBezPDV);
            this.Controls.Add(this.txtCijenaSaPDV);
            this.Controls.Add(this.txtPonuditelj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtUBroj);
            this.Controls.Add(this.txtKlasa);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoviZahtjevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje novog zahtjeva";
            this.Load += new System.EventHandler(this.NoviZahtjevi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lspajic20_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financiranjeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKlasa;
        private System.Windows.Forms.TextBox txtUBroj;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtPonuditelj;
        private System.Windows.Forms.TextBox txtCijenaSaPDV;
        private System.Windows.Forms.TextBox txtCijenaBezPDV;
        private System.Windows.Forms.ComboBox cboZaposlenici;
        private System.Windows.Forms.ComboBox cboFinanciranje;
        private lspajic20_DBDataSet lspajic20_DBDataSet;
        private System.Windows.Forms.BindingSource financiranjeBindingSource;
        private lspajic20_DBDataSetTableAdapters.financiranjeTableAdapter financiranjeTableAdapter;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private lspajic20_DBDataSetTableAdapters.zaposleniciTableAdapter zaposleniciTableAdapter;
        private System.Windows.Forms.Button btnSpremiPodatke;
    }
}