namespace BMI_Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_title = new System.Windows.Forms.Label();
            this.bt_berechnen = new System.Windows.Forms.Button();
            this.tb_groesse = new System.Windows.Forms.TextBox();
            this.tb_masse = new System.Windows.Forms.TextBox();
            this.label_gewicht = new System.Windows.Forms.Label();
            this.label_groeße = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ergebnistitle = new System.Windows.Forms.Label();
            this.label_kg = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.tb_ergebnis = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_arrow1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_arrow1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(50, 27);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(143, 24);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "BMI - Rechner";
            // 
            // bt_berechnen
            // 
            this.bt_berechnen.Location = new System.Drawing.Point(150, 131);
            this.bt_berechnen.Name = "bt_berechnen";
            this.bt_berechnen.Size = new System.Drawing.Size(75, 23);
            this.bt_berechnen.TabIndex = 3;
            this.bt_berechnen.Text = "Berechnen";
            this.bt_berechnen.UseVisualStyleBackColor = true;
            this.bt_berechnen.Click += new System.EventHandler(this.Bt_Calculate_Click);
            // 
            // tb_groesse
            // 
            this.tb_groesse.Location = new System.Drawing.Point(105, 105);
            this.tb_groesse.Name = "tb_groesse";
            this.tb_groesse.Size = new System.Drawing.Size(100, 20);
            this.tb_groesse.TabIndex = 2;
            // 
            // tb_masse
            // 
            this.tb_masse.Location = new System.Drawing.Point(105, 78);
            this.tb_masse.Name = "tb_masse";
            this.tb_masse.Size = new System.Drawing.Size(100, 20);
            this.tb_masse.TabIndex = 1;
            // 
            // label_gewicht
            // 
            this.label_gewicht.AutoSize = true;
            this.label_gewicht.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gewicht.Location = new System.Drawing.Point(12, 78);
            this.label_gewicht.Name = "label_gewicht";
            this.label_gewicht.Size = new System.Drawing.Size(62, 19);
            this.label_gewicht.TabIndex = 5;
            this.label_gewicht.Text = "Gewicht:";
            // 
            // label_groeße
            // 
            this.label_groeße.AutoSize = true;
            this.label_groeße.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_groeße.Location = new System.Drawing.Point(12, 106);
            this.label_groeße.Name = "label_groeße";
            this.label_groeße.Size = new System.Drawing.Size(92, 19);
            this.label_groeße.TabIndex = 6;
            this.label_groeße.Text = "Körpergröße:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 7;
            // 
            // label_ergebnistitle
            // 
            this.label_ergebnistitle.AutoSize = true;
            this.label_ergebnistitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ergebnistitle.Location = new System.Drawing.Point(12, 195);
            this.label_ergebnistitle.Name = "label_ergebnistitle";
            this.label_ergebnistitle.Size = new System.Drawing.Size(71, 19);
            this.label_ergebnistitle.TabIndex = 10;
            this.label_ergebnistitle.Text = "Ihr BMI:";
            // 
            // label_kg
            // 
            this.label_kg.AutoSize = true;
            this.label_kg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kg.Location = new System.Drawing.Point(205, 79);
            this.label_kg.Name = "label_kg";
            this.label_kg.Size = new System.Drawing.Size(24, 19);
            this.label_kg.TabIndex = 11;
            this.label_kg.Text = "kg";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_m.Location = new System.Drawing.Point(205, 106);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(20, 19);
            this.label_m.TabIndex = 12;
            this.label_m.Text = "m";
            // 
            // tb_ergebnis
            // 
            this.tb_ergebnis.Location = new System.Drawing.Point(105, 194);
            this.tb_ergebnis.Name = "tb_ergebnis";
            this.tb_ergebnis.Size = new System.Drawing.Size(100, 20);
            this.tb_ergebnis.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMI_Rechner.Properties.Resources.BMI;
            this.pictureBox1.Location = new System.Drawing.Point(276, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pb_arrow1
            // 
            this.pb_arrow1.Image = ((System.Drawing.Image)(resources.GetObject("pb_arrow1.Image")));
            this.pb_arrow1.Location = new System.Drawing.Point(256, 42);
            this.pb_arrow1.Name = "pb_arrow1";
            this.pb_arrow1.Size = new System.Drawing.Size(24, 20);
            this.pb_arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_arrow1.TabIndex = 17;
            this.pb_arrow1.TabStop = false;
            this.pb_arrow1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 242);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_ergebnis);
            this.Controls.Add(this.label_m);
            this.Controls.Add(this.label_kg);
            this.Controls.Add(this.label_ergebnistitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_groeße);
            this.Controls.Add(this.label_gewicht);
            this.Controls.Add(this.tb_masse);
            this.Controls.Add(this.tb_groesse);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.pb_arrow1);
            this.Controls.Add(this.bt_berechnen);
            this.Name = "Form1";
            this.Text = "BMI Rechner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_arrow1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button bt_berechnen;
        private System.Windows.Forms.TextBox tb_groesse;
        private System.Windows.Forms.TextBox tb_masse;
        private System.Windows.Forms.Label label_gewicht;
        private System.Windows.Forms.Label label_groeße;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ergebnistitle;
        private System.Windows.Forms.Label label_kg;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.TextBox tb_ergebnis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_arrow1;
    }
}

