namespace NutriManager
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
            tabulkaSurovin = new DataGridView();
            txtNazev = new TextBox();
            txtKalorie = new TextBox();
            txtBilkoviny = new TextBox();
            txtSacharidy = new TextBox();
            txtTuky = new TextBox();
            txtVlaknina = new TextBox();
            txtAlergeny = new TextBox();
            cmbKategorie = new ComboBox();
            tlacitkoPridat = new Button();
            tlacitkoUpravit = new Button();
            tlacitkoSmazat = new Button();
            tlacitkoVycistit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabulkaSurovin).BeginInit();
            SuspendLayout();
            // 
            // tabulkaSurovin
            // 
            tabulkaSurovin.AllowUserToAddRows = false;
            tabulkaSurovin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabulkaSurovin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabulkaSurovin.Location = new Point(14, 16);
            tabulkaSurovin.MultiSelect = false;
            tabulkaSurovin.Name = "tabulkaSurovin";
            tabulkaSurovin.ReadOnly = true;
            tabulkaSurovin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabulkaSurovin.Size = new Size(1148, 463);
            tabulkaSurovin.TabIndex = 0;
            // 
            // txtNazev
            // 
            txtNazev.Location = new Point(120, 485);
            txtNazev.Name = "txtNazev";
            txtNazev.Size = new Size(148, 23);
            txtNazev.TabIndex = 1;
            // 
            // txtKalorie
            // 
            txtKalorie.Location = new Point(120, 514);
            txtKalorie.Name = "txtKalorie";
            txtKalorie.Size = new Size(148, 23);
            txtKalorie.TabIndex = 2;
            // 
            // txtBilkoviny
            // 
            txtBilkoviny.Location = new Point(120, 543);
            txtBilkoviny.Name = "txtBilkoviny";
            txtBilkoviny.Size = new Size(148, 23);
            txtBilkoviny.TabIndex = 3;
            // 
            // txtSacharidy
            // 
            txtSacharidy.Location = new Point(120, 572);
            txtSacharidy.Name = "txtSacharidy";
            txtSacharidy.Size = new Size(148, 23);
            txtSacharidy.TabIndex = 4;
            // 
            // txtTuky
            // 
            txtTuky.Location = new Point(385, 485);
            txtTuky.Name = "txtTuky";
            txtTuky.Size = new Size(148, 23);
            txtTuky.TabIndex = 5;
            // 
            // txtVlaknina
            // 
            txtVlaknina.Location = new Point(385, 514);
            txtVlaknina.Name = "txtVlaknina";
            txtVlaknina.Size = new Size(148, 23);
            txtVlaknina.TabIndex = 6;
            // 
            // txtAlergeny
            // 
            txtAlergeny.Location = new Point(385, 543);
            txtAlergeny.Name = "txtAlergeny";
            txtAlergeny.Size = new Size(148, 23);
            txtAlergeny.TabIndex = 7;
            // 
            // cmbKategorie
            // 
            cmbKategorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategorie.FormattingEnabled = true;
            cmbKategorie.Location = new Point(385, 572);
            cmbKategorie.Name = "cmbKategorie";
            cmbKategorie.Size = new Size(148, 23);
            cmbKategorie.TabIndex = 8;
            // 
            // tlacitkoPridat
            // 
            tlacitkoPridat.Location = new Point(690, 485);
            tlacitkoPridat.Name = "tlacitkoPridat";
            tlacitkoPridat.Size = new Size(146, 23);
            tlacitkoPridat.TabIndex = 9;
            tlacitkoPridat.Text = "Přidat surovinu";
            tlacitkoPridat.UseVisualStyleBackColor = true;
            tlacitkoPridat.Click += tlacitkoPridat_Click;
            // 
            // tlacitkoUpravit
            // 
            tlacitkoUpravit.Location = new Point(690, 514);
            tlacitkoUpravit.Name = "tlacitkoUpravit";
            tlacitkoUpravit.Size = new Size(146, 23);
            tlacitkoUpravit.TabIndex = 10;
            tlacitkoUpravit.Text = "Uložit změny";
            tlacitkoUpravit.UseVisualStyleBackColor = true;
            tlacitkoUpravit.Click += tlacitkoUpravit_Click;
            // 
            // tlacitkoSmazat
            // 
            tlacitkoSmazat.Location = new Point(690, 543);
            tlacitkoSmazat.Name = "tlacitkoSmazat";
            tlacitkoSmazat.Size = new Size(146, 23);
            tlacitkoSmazat.TabIndex = 11;
            tlacitkoSmazat.Text = "Smazat surovinu";
            tlacitkoSmazat.UseVisualStyleBackColor = true;
            tlacitkoSmazat.Click += tlacitkoSmazat_Click;
            // 
            // tlacitkoVycistit
            // 
            tlacitkoVycistit.Location = new Point(690, 572);
            tlacitkoVycistit.Name = "tlacitkoVycistit";
            tlacitkoVycistit.Size = new Size(146, 23);
            tlacitkoVycistit.TabIndex = 12;
            tlacitkoVycistit.Text = "Vyčistit formulář";
            tlacitkoVycistit.UseVisualStyleBackColor = true;
            tlacitkoVycistit.Click += tlacitkoVycistit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 489);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Název:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 518);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 14;
            label2.Text = "Kalorie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 547);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 15;
            label3.Text = "Bílkoviny:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 576);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 16;
            label4.Text = "Sacharidy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 493);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 17;
            label5.Text = "Tuky:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 521);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 18;
            label6.Text = "Vláknina:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 550);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 19;
            label7.Text = "Alergeny:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(320, 579);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 20;
            label8.Text = "Kategorie:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 648);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tlacitkoVycistit);
            Controls.Add(tlacitkoSmazat);
            Controls.Add(tlacitkoUpravit);
            Controls.Add(tlacitkoPridat);
            Controls.Add(cmbKategorie);
            Controls.Add(txtAlergeny);
            Controls.Add(txtVlaknina);
            Controls.Add(txtTuky);
            Controls.Add(txtSacharidy);
            Controls.Add(txtBilkoviny);
            Controls.Add(txtKalorie);
            Controls.Add(txtNazev);
            Controls.Add(tabulkaSurovin);
            Name = "Form1";
            Text = "Správce výživy a surovin";
            ((System.ComponentModel.ISupportInitialize)tabulkaSurovin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tabulkaSurovin;
        private TextBox txtNazev;
        private TextBox txtKalorie;
        private TextBox txtBilkoviny;
        private TextBox txtSacharidy;
        private TextBox txtTuky;
        private TextBox txtVlaknina;
        private TextBox txtAlergeny;
        private ComboBox cmbKategorie;
        private Button tlacitkoPridat;
        private Button tlacitkoUpravit;
        private Button tlacitkoSmazat;
        private Button tlacitkoVycistit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
