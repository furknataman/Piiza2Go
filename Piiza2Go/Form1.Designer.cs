
namespace Piiza2Go
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioInce = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoyut = new System.Windows.Forms.ComboBox();
            this.chkMantar = new System.Windows.Forms.CheckBox();
            this.chkTursu = new System.Windows.Forms.CheckBox();
            this.chkSucuk = new System.Windows.Forms.CheckBox();
            this.chkMisir = new System.Windows.Forms.CheckBox();
            this.chkPastirma = new System.Windows.Forms.CheckBox();
            this.chkMozeralla = new System.Windows.Forms.CheckBox();
            this.trcSosSeviyesi = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.radioOrta = new System.Windows.Forms.RadioButton();
            this.radioKalin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lstBoxSiparis = new System.Windows.Forms.ListBox();
            this.lstBoxTezgah = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstBoxMalzemeler = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trcSosSeviyesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hamur Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Boyut seçiniz";
            // 
            // radioInce
            // 
            this.radioInce.AutoSize = true;
            this.radioInce.Location = new System.Drawing.Point(26, 284);
            this.radioInce.Name = "radioInce";
            this.radioInce.Size = new System.Drawing.Size(47, 19);
            this.radioInce.TabIndex = 3;
            this.radioInce.TabStop = true;
            this.radioInce.Tag = "0";
            this.radioInce.Text = "İnce";
            this.radioInce.UseVisualStyleBackColor = true;
            this.radioInce.CheckedChanged += new System.EventHandler(this.hamurradio_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Malzeme Seçiniz";
            // 
            // cmbBoyut
            // 
            this.cmbBoyut.FormattingEnabled = true;
            this.cmbBoyut.Items.AddRange(new object[] {
            "Küçük",
            "Normal",
            "Büyük"});
            this.cmbBoyut.Location = new System.Drawing.Point(26, 358);
            this.cmbBoyut.Name = "cmbBoyut";
            this.cmbBoyut.Size = new System.Drawing.Size(121, 23);
            this.cmbBoyut.TabIndex = 5;
            this.cmbBoyut.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkMantar
            // 
            this.chkMantar.AutoSize = true;
            this.chkMantar.Location = new System.Drawing.Point(26, 97);
            this.chkMantar.Name = "chkMantar";
            this.chkMantar.Size = new System.Drawing.Size(64, 19);
            this.chkMantar.TabIndex = 6;
            this.chkMantar.Tag = "3";
            this.chkMantar.Text = "Mantar";
            this.chkMantar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMantar.UseVisualStyleBackColor = true;
            this.chkMantar.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // chkTursu
            // 
            this.chkTursu.AutoSize = true;
            this.chkTursu.Location = new System.Drawing.Point(26, 122);
            this.chkTursu.Name = "chkTursu";
            this.chkTursu.Size = new System.Drawing.Size(55, 19);
            this.chkTursu.TabIndex = 7;
            this.chkTursu.Tag = "5";
            this.chkTursu.Text = "Turşu";
            this.chkTursu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTursu.UseVisualStyleBackColor = true;
            this.chkTursu.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // chkSucuk
            // 
            this.chkSucuk.AutoSize = true;
            this.chkSucuk.Location = new System.Drawing.Point(125, 72);
            this.chkSucuk.Name = "chkSucuk";
            this.chkSucuk.Size = new System.Drawing.Size(58, 19);
            this.chkSucuk.TabIndex = 8;
            this.chkSucuk.Tag = "1";
            this.chkSucuk.Text = "Sucuk";
            this.chkSucuk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkSucuk.UseVisualStyleBackColor = true;
            this.chkSucuk.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // chkMisir
            // 
            this.chkMisir.AutoSize = true;
            this.chkMisir.Location = new System.Drawing.Point(125, 97);
            this.chkMisir.Name = "chkMisir";
            this.chkMisir.Size = new System.Drawing.Size(52, 19);
            this.chkMisir.TabIndex = 9;
            this.chkMisir.Tag = "4";
            this.chkMisir.Text = "Mısır";
            this.chkMisir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMisir.UseVisualStyleBackColor = true;
            this.chkMisir.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // chkPastirma
            // 
            this.chkPastirma.AutoSize = true;
            this.chkPastirma.Location = new System.Drawing.Point(125, 122);
            this.chkPastirma.Name = "chkPastirma";
            this.chkPastirma.Size = new System.Drawing.Size(72, 19);
            this.chkPastirma.TabIndex = 9;
            this.chkPastirma.Tag = "6";
            this.chkPastirma.Text = "Pastırma";
            this.chkPastirma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkPastirma.UseVisualStyleBackColor = true;
            this.chkPastirma.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // chkMozeralla
            // 
            this.chkMozeralla.AutoSize = true;
            this.chkMozeralla.Checked = true;
            this.chkMozeralla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMozeralla.Location = new System.Drawing.Point(26, 72);
            this.chkMozeralla.Name = "chkMozeralla";
            this.chkMozeralla.Size = new System.Drawing.Size(77, 19);
            this.chkMozeralla.TabIndex = 6;
            this.chkMozeralla.Tag = "9";
            this.chkMozeralla.Text = "Mozeralla";
            this.chkMozeralla.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMozeralla.UseVisualStyleBackColor = true;
            this.chkMozeralla.CheckedChanged += new System.EventHandler(this.chkMalzeme_CheckedChanged);
            // 
            // trcSosSeviyesi
            // 
            this.trcSosSeviyesi.Location = new System.Drawing.Point(26, 191);
            this.trcSosSeviyesi.Maximum = 3;
            this.trcSosSeviyesi.Minimum = 1;
            this.trcSosSeviyesi.Name = "trcSosSeviyesi";
            this.trcSosSeviyesi.Size = new System.Drawing.Size(171, 45);
            this.trcSosSeviyesi.TabIndex = 10;
            this.trcSosSeviyesi.Value = 1;
            this.trcSosSeviyesi.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sos seviyesini seçiniz:";
            // 
            // radioOrta
            // 
            this.radioOrta.AutoSize = true;
            this.radioOrta.Location = new System.Drawing.Point(79, 284);
            this.radioOrta.Name = "radioOrta";
            this.radioOrta.Size = new System.Drawing.Size(48, 19);
            this.radioOrta.TabIndex = 3;
            this.radioOrta.TabStop = true;
            this.radioOrta.Tag = "1";
            this.radioOrta.Text = "Orta";
            this.radioOrta.UseVisualStyleBackColor = true;
            this.radioOrta.CheckedChanged += new System.EventHandler(this.hamurradio_CheckedChanged);
            // 
            // radioKalin
            // 
            this.radioKalin.AutoSize = true;
            this.radioKalin.Location = new System.Drawing.Point(133, 284);
            this.radioKalin.Name = "radioKalin";
            this.radioKalin.Size = new System.Drawing.Size(51, 19);
            this.radioKalin.TabIndex = 3;
            this.radioKalin.TabStop = true;
            this.radioKalin.Tag = "2";
            this.radioKalin.Text = "Kalın";
            this.radioKalin.UseVisualStyleBackColor = true;
            this.radioKalin.CheckedChanged += new System.EventHandler(this.hamurradio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam:";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(160, 494);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblToplam.Size = new System.Drawing.Size(37, 45);
            this.lblToplam.TabIndex = 12;
            this.lblToplam.Text = "5";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(26, 567);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(171, 37);
            this.btnSiparisVer.TabIndex = 13;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // lstBoxSiparis
            // 
            this.lstBoxSiparis.FormattingEnabled = true;
            this.lstBoxSiparis.ItemHeight = 15;
            this.lstBoxSiparis.Location = new System.Drawing.Point(514, 72);
            this.lstBoxSiparis.Name = "lstBoxSiparis";
            this.lstBoxSiparis.Size = new System.Drawing.Size(199, 544);
            this.lstBoxSiparis.TabIndex = 14;
            this.lstBoxSiparis.SelectedIndexChanged += new System.EventHandler(this.lstBoxSiparis_SelectedIndexChanged);
            // 
            // lstBoxTezgah
            // 
            this.lstBoxTezgah.FormattingEnabled = true;
            this.lstBoxTezgah.ItemHeight = 15;
            this.lstBoxTezgah.Location = new System.Drawing.Point(784, 72);
            this.lstBoxTezgah.Name = "lstBoxTezgah";
            this.lstBoxTezgah.Size = new System.Drawing.Size(190, 544);
            this.lstBoxTezgah.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sipariş Tablosu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tezgah";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(719, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 62);
            this.label8.TabIndex = 16;
            this.label8.Text = ">";
            // 
            // lstBoxMalzemeler
            // 
            this.lstBoxMalzemeler.FormattingEnabled = true;
            this.lstBoxMalzemeler.ItemHeight = 15;
            this.lstBoxMalzemeler.Location = new System.Drawing.Point(231, 72);
            this.lstBoxMalzemeler.Name = "lstBoxMalzemeler";
            this.lstBoxMalzemeler.Size = new System.Drawing.Size(199, 544);
            this.lstBoxMalzemeler.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(231, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Aktif Malzelemer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(815, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Saat:";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(878, 18);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(34, 15);
            this.lblsaat.TabIndex = 19;
            this.lblsaat.Text = "00:00";
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 638);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstBoxTezgah);
            this.Controls.Add(this.lstBoxMalzemeler);
            this.Controls.Add(this.lstBoxSiparis);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trcSosSeviyesi);
            this.Controls.Add(this.chkPastirma);
            this.Controls.Add(this.chkMisir);
            this.Controls.Add(this.chkSucuk);
            this.Controls.Add(this.chkTursu);
            this.Controls.Add(this.chkMozeralla);
            this.Controls.Add(this.chkMantar);
            this.Controls.Add(this.cmbBoyut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioKalin);
            this.Controls.Add(this.radioOrta);
            this.Controls.Add(this.radioInce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trcSosSeviyesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioInce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBoyut;
        private System.Windows.Forms.CheckBox chkMantar;
        private System.Windows.Forms.CheckBox chkTursu;
        private System.Windows.Forms.CheckBox chkSucuk;
        private System.Windows.Forms.CheckBox chkMisir;
        private System.Windows.Forms.CheckBox chkPastirma;
        private System.Windows.Forms.CheckBox chkMozeralla;
        private System.Windows.Forms.TrackBar trcSosSeviyesi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioOrta;
        private System.Windows.Forms.RadioButton radioKalin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.ListBox lstBoxSiparis;
        private System.Windows.Forms.ListBox lstBoxTezgah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstBoxMalzemeler;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer tmrZaman;
    }
}

