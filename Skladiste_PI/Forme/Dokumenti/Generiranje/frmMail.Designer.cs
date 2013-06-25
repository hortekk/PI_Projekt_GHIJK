namespace Skladiste_PI
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picMailNo = new System.Windows.Forms.PictureBox();
            this.picLozNo = new System.Windows.Forms.PictureBox();
            this.picMailYes = new System.Windows.Forms.PictureBox();
            this.picLozYes = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMailNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMailYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozYes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.picMailNo);
            this.panel1.Controls.Add(this.picLozNo);
            this.panel1.Controls.Add(this.picMailYes);
            this.panel1.Controls.Add(this.picLozYes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 435);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // picMailNo
            // 
            this.picMailNo.Image = global::Skladiste_PI.Properties.Resources.no;
            this.picMailNo.Location = new System.Drawing.Point(447, 94);
            this.picMailNo.Name = "picMailNo";
            this.picMailNo.Size = new System.Drawing.Size(22, 20);
            this.picMailNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMailNo.TabIndex = 12;
            this.picMailNo.TabStop = false;
            this.picMailNo.Visible = false;
            // 
            // picLozNo
            // 
            this.picLozNo.Image = global::Skladiste_PI.Properties.Resources.no;
            this.picLozNo.Location = new System.Drawing.Point(447, 68);
            this.picLozNo.Name = "picLozNo";
            this.picLozNo.Size = new System.Drawing.Size(22, 20);
            this.picLozNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLozNo.TabIndex = 11;
            this.picLozNo.TabStop = false;
            this.picLozNo.Visible = false;
            // 
            // picMailYes
            // 
            this.picMailYes.Image = global::Skladiste_PI.Properties.Resources.yes;
            this.picMailYes.Location = new System.Drawing.Point(447, 94);
            this.picMailYes.Name = "picMailYes";
            this.picMailYes.Size = new System.Drawing.Size(22, 20);
            this.picMailYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMailYes.TabIndex = 10;
            this.picMailYes.TabStop = false;
            this.picMailYes.Visible = false;
            // 
            // picLozYes
            // 
            this.picLozYes.Image = global::Skladiste_PI.Properties.Resources.yes;
            this.picLozYes.Location = new System.Drawing.Point(447, 68);
            this.picLozYes.Name = "picLozYes";
            this.picLozYes.Size = new System.Drawing.Size(22, 20);
            this.picLozYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLozYes.TabIndex = 9;
            this.picLozYes.TabStop = false;
            this.picLozYes.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(151, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lozinka maila:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Location = new System.Drawing.Point(539, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pošalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tekst narudžbenice:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox3.Location = new System.Drawing.Point(14, 153);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(600, 232);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(222, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "NARUDŽBENICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail primatelja:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(243, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "pi.ghijk@gmail.com";
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 459);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(667, 497);
            this.Name = "frmMail";
            this.ShowInTaskbar = false;
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMailNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMailYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLozYes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picLozYes;
        private System.Windows.Forms.PictureBox picLozNo;
        private System.Windows.Forms.PictureBox picMailYes;
        private System.Windows.Forms.PictureBox picMailNo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}