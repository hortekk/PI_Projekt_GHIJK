namespace Skladiste_PI
{
    partial class frmUnosPrijemnice
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.txtDobavljac = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUnesiOtpremincu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(66, 30);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 0;
            this.lblDatum.Text = "Datum";
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(66, 56);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(55, 13);
            this.lblDobavljac.TabIndex = 1;
            this.lblDobavljac.Text = "Dobavljac";
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(66, 84);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(59, 13);
            this.lblZaposlenik.TabIndex = 2;
            this.lblZaposlenik.Text = "Zaposlenik";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(159, 84);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(200, 20);
            this.txtZaposlenik.TabIndex = 4;
            // 
            // txtDobavljac
            // 
            this.txtDobavljac.Location = new System.Drawing.Point(159, 56);
            this.txtDobavljac.Name = "txtDobavljac";
            this.txtDobavljac.Size = new System.Drawing.Size(200, 20);
            this.txtDobavljac.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 157);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnUnesiOtpremincu
            // 
            this.btnUnesiOtpremincu.Location = new System.Drawing.Point(229, 320);
            this.btnUnesiOtpremincu.Name = "btnUnesiOtpremincu";
            this.btnUnesiOtpremincu.Size = new System.Drawing.Size(75, 23);
            this.btnUnesiOtpremincu.TabIndex = 7;
            this.btnUnesiOtpremincu.Text = "Unesi";
            this.btnUnesiOtpremincu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // frmUnosOtpremnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 408);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnUnesiOtpremincu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDobavljac);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.lblDatum);
            this.Name = "frmUnosPrijemnice";
            this.Text = "Unos prijemnice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.TextBox txtDobavljac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUnesiOtpremincu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}