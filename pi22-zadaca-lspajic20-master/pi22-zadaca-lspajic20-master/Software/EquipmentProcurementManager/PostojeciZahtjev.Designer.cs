namespace EquipmentProcurementManager
{
    partial class PostojeciZahtjevFrm
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
            this.dgvPostZahtjev = new System.Windows.Forms.DataGridView();
            this.btnKreirajNoviZahtjev = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnBrisanje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostZahtjev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPostZahtjev
            // 
            this.dgvPostZahtjev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostZahtjev.Location = new System.Drawing.Point(12, 73);
            this.dgvPostZahtjev.Name = "dgvPostZahtjev";
            this.dgvPostZahtjev.RowHeadersWidth = 51;
            this.dgvPostZahtjev.RowTemplate.Height = 24;
            this.dgvPostZahtjev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostZahtjev.Size = new System.Drawing.Size(776, 314);
            this.dgvPostZahtjev.TabIndex = 0;
            // 
            // btnKreirajNoviZahtjev
            // 
            this.btnKreirajNoviZahtjev.Location = new System.Drawing.Point(660, 393);
            this.btnKreirajNoviZahtjev.Name = "btnKreirajNoviZahtjev";
            this.btnKreirajNoviZahtjev.Size = new System.Drawing.Size(128, 53);
            this.btnKreirajNoviZahtjev.TabIndex = 1;
            this.btnKreirajNoviZahtjev.Text = "Kreiraj novi zahtjev";
            this.btnKreirajNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnKreirajNoviZahtjev.Click += new System.EventHandler(this.btnKreirajNoviZahtjev_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(360, 23);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(117, 22);
            this.txtPretraga.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(500, 23);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(82, 24);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(503, 393);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(128, 53);
            this.btnBrisanje.TabIndex = 4;
            this.btnBrisanje.Text = "Obriši redak";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje zahtjeva prema rednom broju zahtjeva:";
            // 
            // PostojeciZahtjevFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnKreirajNoviZahtjev);
            this.Controls.Add(this.dgvPostZahtjev);
            this.Name = "PostojeciZahtjevFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis postojećih zahtjeva";
            this.Load += new System.EventHandler(this.PostojeciZahtjevFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostZahtjev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostZahtjev;
        private System.Windows.Forms.Button btnKreirajNoviZahtjev;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnBrisanje;
        private System.Windows.Forms.Label label1;
    }
}