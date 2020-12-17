namespace pekseg
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.list_peksegPekaru = new System.Windows.Forms.ListBox();
            this.list_pekseg = new System.Windows.Forms.ListBox();
            this.list_pekaru = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_peksegNev = new System.Windows.Forms.TextBox();
            this.bttn_peksegPekaruHozz = new System.Windows.Forms.Button();
            this.bttn_pekaruTorol = new System.Windows.Forms.Button();
            this.bttn_peksegHozz = new System.Windows.Forms.Button();
            this.checkBox_Laktoz = new System.Windows.Forms.CheckBox();
            this.bttn_pekaruHozza = new System.Windows.Forms.Button();
            this.num_ar = new System.Windows.Forms.NumericUpDown();
            this.txt_pekaruNev = new System.Windows.Forms.TextBox();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.list_statisztika = new System.Windows.Forms.ListBox();
            this.label_peksegNev = new System.Windows.Forms.Label();
            this.label_alapitas = new System.Windows.Forms.Label();
            this.label_pekaruk = new System.Windows.Forms.Label();
            this.label_atlagosAr = new System.Windows.Forms.Label();
            this.label_legolcsobb = new System.Windows.Forms.Label();
            this.label_legdragabb = new System.Windows.Forms.Label();
            this.label_laktoz = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).BeginInit();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 409);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.list_peksegPekaru);
            this.tab1.Controls.Add(this.list_pekseg);
            this.tab1.Controls.Add(this.list_pekaru);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.txt_peksegNev);
            this.tab1.Controls.Add(this.bttn_peksegPekaruHozz);
            this.tab1.Controls.Add(this.bttn_pekaruTorol);
            this.tab1.Controls.Add(this.bttn_peksegHozz);
            this.tab1.Controls.Add(this.checkBox_Laktoz);
            this.tab1.Controls.Add(this.bttn_pekaruHozza);
            this.tab1.Controls.Add(this.num_ar);
            this.tab1.Controls.Add(this.txt_pekaruNev);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(767, 383);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Adatok";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // list_peksegPekaru
            // 
            this.list_peksegPekaru.FormattingEnabled = true;
            this.list_peksegPekaru.Location = new System.Drawing.Point(400, 197);
            this.list_peksegPekaru.Name = "list_peksegPekaru";
            this.list_peksegPekaru.Size = new System.Drawing.Size(269, 95);
            this.list_peksegPekaru.TabIndex = 16;
            // 
            // list_pekseg
            // 
            this.list_pekseg.FormattingEnabled = true;
            this.list_pekseg.Location = new System.Drawing.Point(222, 197);
            this.list_pekseg.Name = "list_pekseg";
            this.list_pekseg.Size = new System.Drawing.Size(172, 173);
            this.list_pekseg.TabIndex = 15;
            this.list_pekseg.SelectedIndexChanged += new System.EventHandler(this.list_pekseg_SelectedIndexChanged);
            // 
            // list_pekaru
            // 
            this.list_pekaru.FormattingEnabled = true;
            this.list_pekaru.Location = new System.Drawing.Point(323, 20);
            this.list_pekaru.Name = "list_pekaru";
            this.list_pekaru.Size = new System.Drawing.Size(384, 95);
            this.list_pekaru.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pékségek";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pékáruk";
            // 
            // txt_peksegNev
            // 
            this.txt_peksegNev.Location = new System.Drawing.Point(4, 197);
            this.txt_peksegNev.Name = "txt_peksegNev";
            this.txt_peksegNev.Size = new System.Drawing.Size(120, 20);
            this.txt_peksegNev.TabIndex = 11;
            // 
            // bttn_peksegPekaruHozz
            // 
            this.bttn_peksegPekaruHozz.Location = new System.Drawing.Point(675, 224);
            this.bttn_peksegPekaruHozz.Name = "bttn_peksegPekaruHozz";
            this.bttn_peksegPekaruHozz.Size = new System.Drawing.Size(75, 58);
            this.bttn_peksegPekaruHozz.TabIndex = 10;
            this.bttn_peksegPekaruHozz.Text = "+";
            this.bttn_peksegPekaruHozz.UseVisualStyleBackColor = true;
            this.bttn_peksegPekaruHozz.Click += new System.EventHandler(this.bttn_peksegPekaruHozz_Click);
            // 
            // bttn_pekaruTorol
            // 
            this.bttn_pekaruTorol.Location = new System.Drawing.Point(222, 43);
            this.bttn_pekaruTorol.Name = "bttn_pekaruTorol";
            this.bttn_pekaruTorol.Size = new System.Drawing.Size(75, 46);
            this.bttn_pekaruTorol.TabIndex = 8;
            this.bttn_pekaruTorol.Text = "Törlés";
            this.bttn_pekaruTorol.UseVisualStyleBackColor = true;
            this.bttn_pekaruTorol.Click += new System.EventHandler(this.bttn_pekaruTorol_Click);
            // 
            // bttn_peksegHozz
            // 
            this.bttn_peksegHozz.Location = new System.Drawing.Point(4, 224);
            this.bttn_peksegHozz.Name = "bttn_peksegHozz";
            this.bttn_peksegHozz.Size = new System.Drawing.Size(120, 23);
            this.bttn_peksegHozz.TabIndex = 7;
            this.bttn_peksegHozz.Text = "Hozzáadás";
            this.bttn_peksegHozz.UseVisualStyleBackColor = true;
            this.bttn_peksegHozz.Click += new System.EventHandler(this.bttn_peksegHozz_Click);
            // 
            // checkBox_Laktoz
            // 
            this.checkBox_Laktoz.AutoSize = true;
            this.checkBox_Laktoz.Location = new System.Drawing.Point(10, 72);
            this.checkBox_Laktoz.Name = "checkBox_Laktoz";
            this.checkBox_Laktoz.Size = new System.Drawing.Size(92, 17);
            this.checkBox_Laktoz.TabIndex = 3;
            this.checkBox_Laktoz.Text = "Laktózmentes";
            this.checkBox_Laktoz.UseVisualStyleBackColor = true;
            // 
            // bttn_pekaruHozza
            // 
            this.bttn_pekaruHozza.Location = new System.Drawing.Point(4, 95);
            this.bttn_pekaruHozza.Name = "bttn_pekaruHozza";
            this.bttn_pekaruHozza.Size = new System.Drawing.Size(120, 23);
            this.bttn_pekaruHozza.TabIndex = 2;
            this.bttn_pekaruHozza.Text = "Hozzáadás";
            this.bttn_pekaruHozza.UseVisualStyleBackColor = true;
            this.bttn_pekaruHozza.Click += new System.EventHandler(this.bttn_pekaruHozza_Click);
            // 
            // num_ar
            // 
            this.num_ar.Location = new System.Drawing.Point(4, 43);
            this.num_ar.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.num_ar.Name = "num_ar";
            this.num_ar.Size = new System.Drawing.Size(120, 20);
            this.num_ar.TabIndex = 1;
            // 
            // txt_pekaruNev
            // 
            this.txt_pekaruNev.Location = new System.Drawing.Point(4, 20);
            this.txt_pekaruNev.Name = "txt_pekaruNev";
            this.txt_pekaruNev.Size = new System.Drawing.Size(120, 20);
            this.txt_pekaruNev.TabIndex = 0;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.label_laktoz);
            this.tab2.Controls.Add(this.label_legdragabb);
            this.tab2.Controls.Add(this.label_legolcsobb);
            this.tab2.Controls.Add(this.label_atlagosAr);
            this.tab2.Controls.Add(this.label_pekaruk);
            this.tab2.Controls.Add(this.label_alapitas);
            this.tab2.Controls.Add(this.label_peksegNev);
            this.tab2.Controls.Add(this.list_statisztika);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(767, 383);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Statisztika";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // list_statisztika
            // 
            this.list_statisztika.FormattingEnabled = true;
            this.list_statisztika.Location = new System.Drawing.Point(7, 7);
            this.list_statisztika.Name = "list_statisztika";
            this.list_statisztika.Size = new System.Drawing.Size(164, 160);
            this.list_statisztika.TabIndex = 0;
            this.list_statisztika.SelectedIndexChanged += new System.EventHandler(this.list_statisztika_SelectedIndexChanged);
            // 
            // label_peksegNev
            // 
            this.label_peksegNev.AutoSize = true;
            this.label_peksegNev.Location = new System.Drawing.Point(177, 7);
            this.label_peksegNev.Name = "label_peksegNev";
            this.label_peksegNev.Size = new System.Drawing.Size(76, 13);
            this.label_peksegNev.TabIndex = 1;
            this.label_peksegNev.Text = "Pékség neve: ";
            // 
            // label_alapitas
            // 
            this.label_alapitas.AutoSize = true;
            this.label_alapitas.Location = new System.Drawing.Point(177, 20);
            this.label_alapitas.Name = "label_alapitas";
            this.label_alapitas.Size = new System.Drawing.Size(53, 13);
            this.label_alapitas.TabIndex = 2;
            this.label_alapitas.Text = "Alapítva: ";
            // 
            // label_pekaruk
            // 
            this.label_pekaruk.AutoSize = true;
            this.label_pekaruk.Location = new System.Drawing.Point(177, 66);
            this.label_pekaruk.Name = "label_pekaruk";
            this.label_pekaruk.Size = new System.Drawing.Size(53, 13);
            this.label_pekaruk.TabIndex = 3;
            this.label_pekaruk.Text = "Pékáruk: ";
            // 
            // label_atlagosAr
            // 
            this.label_atlagosAr.AutoSize = true;
            this.label_atlagosAr.Location = new System.Drawing.Point(177, 88);
            this.label_atlagosAr.Name = "label_atlagosAr";
            this.label_atlagosAr.Size = new System.Drawing.Size(60, 13);
            this.label_atlagosAr.TabIndex = 4;
            this.label_atlagosAr.Text = "Átlagos ár: ";
            // 
            // label_legolcsobb
            // 
            this.label_legolcsobb.AutoSize = true;
            this.label_legolcsobb.Location = new System.Drawing.Point(177, 110);
            this.label_legolcsobb.Name = "label_legolcsobb";
            this.label_legolcsobb.Size = new System.Drawing.Size(103, 13);
            this.label_legolcsobb.TabIndex = 5;
            this.label_legolcsobb.Text = "Legolcsóbb termék: ";
            // 
            // label_legdragabb
            // 
            this.label_legdragabb.AutoSize = true;
            this.label_legdragabb.Location = new System.Drawing.Point(177, 132);
            this.label_legdragabb.Name = "label_legdragabb";
            this.label_legdragabb.Size = new System.Drawing.Size(105, 13);
            this.label_legdragabb.TabIndex = 6;
            this.label_legdragabb.Text = "Legdrágább termék: ";
            // 
            // label_laktoz
            // 
            this.label_laktoz.AutoSize = true;
            this.label_laktoz.Location = new System.Drawing.Point(177, 154);
            this.label_laktoz.Name = "label_laktoz";
            this.label_laktoz.Size = new System.Drawing.Size(114, 13);
            this.label_laktoz.TabIndex = 7;
            this.label_laktoz.Text = "Laktózmentes termék: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ar)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.TextBox txt_peksegNev;
        private System.Windows.Forms.Button bttn_peksegPekaruHozz;
        private System.Windows.Forms.Button bttn_pekaruTorol;
        private System.Windows.Forms.Button bttn_peksegHozz;
        private System.Windows.Forms.CheckBox checkBox_Laktoz;
        private System.Windows.Forms.Button bttn_pekaruHozza;
        private System.Windows.Forms.NumericUpDown num_ar;
        private System.Windows.Forms.TextBox txt_pekaruNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_pekaru;
        private System.Windows.Forms.ListBox list_peksegPekaru;
        private System.Windows.Forms.ListBox list_pekseg;
        private System.Windows.Forms.Label label_laktoz;
        private System.Windows.Forms.Label label_legdragabb;
        private System.Windows.Forms.Label label_legolcsobb;
        private System.Windows.Forms.Label label_atlagosAr;
        private System.Windows.Forms.Label label_pekaruk;
        private System.Windows.Forms.Label label_alapitas;
        private System.Windows.Forms.Label label_peksegNev;
        private System.Windows.Forms.ListBox list_statisztika;
    }
}

