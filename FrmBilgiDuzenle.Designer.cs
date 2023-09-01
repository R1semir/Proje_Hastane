namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.btnbilgigüncelle = new System.Windows.Forms.Button();
            this.cmcinsiyet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msktelno = new System.Windows.Forms.MaskedTextBox();
            this.txAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txsifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgigüncelle
            // 
            this.btnbilgigüncelle.BackColor = System.Drawing.Color.Lime;
            this.btnbilgigüncelle.Location = new System.Drawing.Point(136, 300);
            this.btnbilgigüncelle.Name = "btnbilgigüncelle";
            this.btnbilgigüncelle.Size = new System.Drawing.Size(121, 35);
            this.btnbilgigüncelle.TabIndex = 31;
            this.btnbilgigüncelle.Text = "Güncelle";
            this.btnbilgigüncelle.UseVisualStyleBackColor = false;
            this.btnbilgigüncelle.Click += new System.EventHandler(this.btnbilgigüncelle_Click);
            // 
            // cmcinsiyet
            // 
            this.cmcinsiyet.FormattingEnabled = true;
            this.cmcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmcinsiyet.Location = new System.Drawing.Point(136, 254);
            this.cmcinsiyet.Name = "cmcinsiyet";
            this.cmcinsiyet.Size = new System.Drawing.Size(121, 27);
            this.cmcinsiyet.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cinsiyet:";
            // 
            // msktelno
            // 
            this.msktelno.Location = new System.Drawing.Point(136, 164);
            this.msktelno.Mask = "(999) 000-0000";
            this.msktelno.Name = "msktelno";
            this.msktelno.Size = new System.Drawing.Size(121, 27);
            this.msktelno.TabIndex = 4;
            // 
            // txAd
            // 
            this.txAd.Location = new System.Drawing.Point(136, 10);
            this.txAd.Name = "txAd";
            this.txAd.Size = new System.Drawing.Size(121, 27);
            this.txAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad:";
            // 
            // TxSoyad
            // 
            this.TxSoyad.Location = new System.Drawing.Point(136, 60);
            this.TxSoyad.Name = "TxSoyad";
            this.TxSoyad.Size = new System.Drawing.Size(121, 27);
            this.TxSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Soyad:";
            // 
            // txsifre
            // 
            this.txsifre.Location = new System.Drawing.Point(136, 210);
            this.txsifre.Name = "txsifre";
            this.txsifre.Size = new System.Drawing.Size(121, 27);
            this.txsifre.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Şifre:";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(136, 110);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(121, 27);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(344, 360);
            this.Controls.Add(this.btnbilgigüncelle);
            this.Controls.Add(this.cmcinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.msktelno);
            this.Controls.Add(this.txAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgigüncelle;
        private System.Windows.Forms.ComboBox cmcinsiyet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox msktelno;
        private System.Windows.Forms.TextBox txAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txsifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}