namespace Hesap_Makinesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sifir = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.cikar = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.sifirTusu = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.alti = new System.Windows.Forms.Button();
            this.dokuz = new System.Windows.Forms.Button();
            this.iki = new System.Windows.Forms.Button();
            this.bes = new System.Windows.Forms.Button();
            this.bir = new System.Windows.Forms.Button();
            this.dort = new System.Windows.Forms.Button();
            this.sekiz = new System.Windows.Forms.Button();
            this.yedi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sifir
            // 
            this.sifir.Interval = 10;
            this.sifir.Tick += new System.EventHandler(this.sifir_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(131, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bol.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bol.ForeColor = System.Drawing.Color.Black;
            this.bol.Location = new System.Drawing.Point(183, 67);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(46, 45);
            this.bol.TabIndex = 5;
            this.bol.Text = "/";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // cikar
            // 
            this.cikar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cikar.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikar.ForeColor = System.Drawing.Color.Black;
            this.cikar.Location = new System.Drawing.Point(183, 169);
            this.cikar.Name = "cikar";
            this.cikar.Size = new System.Drawing.Size(46, 44);
            this.cikar.TabIndex = 8;
            this.cikar.Text = "-";
            this.cikar.UseVisualStyleBackColor = false;
            this.cikar.Click += new System.EventHandler(this.cikar_Click);
            // 
            // esittir
            // 
            this.esittir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.esittir.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esittir.ForeColor = System.Drawing.Color.Black;
            this.esittir.Location = new System.Drawing.Point(131, 269);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(98, 38);
            this.esittir.TabIndex = 9;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = false;
            this.esittir.Click += new System.EventHandler(this.esittir_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.carp.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carp.ForeColor = System.Drawing.Color.Black;
            this.carp.Location = new System.Drawing.Point(183, 118);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(46, 45);
            this.carp.TabIndex = 7;
            this.carp.Text = "*";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.topla.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topla.ForeColor = System.Drawing.Color.Black;
            this.topla.Location = new System.Drawing.Point(183, 219);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(46, 44);
            this.topla.TabIndex = 6;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sifirTusu
            // 
            this.sifirTusu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sifirTusu.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifirTusu.ForeColor = System.Drawing.Color.Black;
            this.sifirTusu.Location = new System.Drawing.Point(27, 269);
            this.sifirTusu.Name = "sifirTusu";
            this.sifirTusu.Size = new System.Drawing.Size(98, 38);
            this.sifirTusu.TabIndex = 4;
            this.sifirTusu.Text = "0";
            this.sifirTusu.UseVisualStyleBackColor = false;
            this.sifirTusu.Click += new System.EventHandler(this.sifirTusu_Click);
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uc.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc.ForeColor = System.Drawing.Color.Black;
            this.uc.Location = new System.Drawing.Point(131, 219);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(46, 44);
            this.uc.TabIndex = 3;
            this.uc.Text = "3";
            this.uc.UseVisualStyleBackColor = false;
            this.uc.Click += new System.EventHandler(this.uc_Click);
            // 
            // alti
            // 
            this.alti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.alti.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alti.ForeColor = System.Drawing.Color.Black;
            this.alti.Location = new System.Drawing.Point(131, 169);
            this.alti.Name = "alti";
            this.alti.Size = new System.Drawing.Size(46, 44);
            this.alti.TabIndex = 3;
            this.alti.Text = "6";
            this.alti.UseVisualStyleBackColor = false;
            this.alti.Click += new System.EventHandler(this.alti_Click);
            // 
            // dokuz
            // 
            this.dokuz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dokuz.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokuz.ForeColor = System.Drawing.Color.Black;
            this.dokuz.Location = new System.Drawing.Point(131, 118);
            this.dokuz.Name = "dokuz";
            this.dokuz.Size = new System.Drawing.Size(46, 45);
            this.dokuz.TabIndex = 3;
            this.dokuz.Text = "9";
            this.dokuz.UseVisualStyleBackColor = false;
            this.dokuz.Click += new System.EventHandler(this.dokuz_Click);
            // 
            // iki
            // 
            this.iki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iki.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iki.ForeColor = System.Drawing.Color.Black;
            this.iki.Location = new System.Drawing.Point(79, 219);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(46, 44);
            this.iki.TabIndex = 3;
            this.iki.Text = "2";
            this.iki.UseVisualStyleBackColor = false;
            this.iki.Click += new System.EventHandler(this.iki_Click);
            // 
            // bes
            // 
            this.bes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bes.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bes.ForeColor = System.Drawing.Color.Black;
            this.bes.Location = new System.Drawing.Point(79, 169);
            this.bes.Name = "bes";
            this.bes.Size = new System.Drawing.Size(46, 44);
            this.bes.TabIndex = 3;
            this.bes.Text = "5";
            this.bes.UseVisualStyleBackColor = false;
            this.bes.Click += new System.EventHandler(this.bes_Click);
            // 
            // bir
            // 
            this.bir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bir.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bir.ForeColor = System.Drawing.Color.Black;
            this.bir.Location = new System.Drawing.Point(27, 219);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(46, 44);
            this.bir.TabIndex = 3;
            this.bir.Text = "1";
            this.bir.UseVisualStyleBackColor = false;
            this.bir.Click += new System.EventHandler(this.bir_Click);
            // 
            // dort
            // 
            this.dort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dort.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dort.ForeColor = System.Drawing.Color.Black;
            this.dort.Location = new System.Drawing.Point(27, 169);
            this.dort.Name = "dort";
            this.dort.Size = new System.Drawing.Size(46, 44);
            this.dort.TabIndex = 3;
            this.dort.Text = "4";
            this.dort.UseVisualStyleBackColor = false;
            this.dort.Click += new System.EventHandler(this.dort_Click);
            // 
            // sekiz
            // 
            this.sekiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sekiz.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekiz.ForeColor = System.Drawing.Color.Black;
            this.sekiz.Location = new System.Drawing.Point(79, 118);
            this.sekiz.Name = "sekiz";
            this.sekiz.Size = new System.Drawing.Size(46, 45);
            this.sekiz.TabIndex = 3;
            this.sekiz.Text = "8";
            this.sekiz.UseVisualStyleBackColor = false;
            this.sekiz.Click += new System.EventHandler(this.sekiz_Click);
            // 
            // yedi
            // 
            this.yedi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yedi.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yedi.ForeColor = System.Drawing.Color.Black;
            this.yedi.Location = new System.Drawing.Point(27, 118);
            this.yedi.Name = "yedi";
            this.yedi.Size = new System.Drawing.Size(46, 45);
            this.yedi.TabIndex = 3;
            this.yedi.Text = "7";
            this.yedi.UseVisualStyleBackColor = false;
            this.yedi.Click += new System.EventHandler(this.yedi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Hesap_Makinesi.Properties.Resources.backspace;
            this.button1.Location = new System.Drawing.Point(27, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(262, 317);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.cikar);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.sifirTusu);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.alti);
            this.Controls.Add(this.dokuz);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.bes);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.dort);
            this.Controls.Add(this.sekiz);
            this.Controls.Add(this.yedi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer sifir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button yedi;
        private System.Windows.Forms.Button sekiz;
        private System.Windows.Forms.Button dokuz;
        private System.Windows.Forms.Button dort;
        private System.Windows.Forms.Button bes;
        private System.Windows.Forms.Button alti;
        private System.Windows.Forms.Button bir;
        private System.Windows.Forms.Button iki;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.Button sifirTusu;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button cikar;
        private System.Windows.Forms.Button esittir;
    }
}

