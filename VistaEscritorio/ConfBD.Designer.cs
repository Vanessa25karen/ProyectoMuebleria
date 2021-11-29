namespace VistaEscritorio
{
    partial class ConfBD
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
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.txtCadCon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEsquema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsCadCon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(64, 223);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(75, 23);
            this.btnConfigurar.TabIndex = 19;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // txtCadCon
            // 
            this.txtCadCon.BackColor = System.Drawing.Color.White;
            this.txtCadCon.Location = new System.Drawing.Point(12, 280);
            this.txtCadCon.Multiline = true;
            this.txtCadCon.Name = "txtCadCon";
            this.txtCadCon.ReadOnly = true;
            this.txtCadCon.Size = new System.Drawing.Size(200, 47);
            this.txtCadCon.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cadena de conexión:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEsquema);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServidor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 141);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cofiguración";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(83, 101);
            this.txtContraseña.MaxLength = 100;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(83, 75);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // txtEsquema
            // 
            this.txtEsquema.Location = new System.Drawing.Point(83, 49);
            this.txtEsquema.Name = "txtEsquema";
            this.txtEsquema.Size = new System.Drawing.Size(100, 20);
            this.txtEsquema.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Esquema:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(83, 23);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(100, 20);
            this.txtServidor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servidor:";
            // 
            // lsCadCon
            // 
            this.lsCadCon.FormattingEnabled = true;
            this.lsCadCon.Location = new System.Drawing.Point(12, 32);
            this.lsCadCon.Name = "lsCadCon";
            this.lsCadCon.Size = new System.Drawing.Size(200, 17);
            this.lsCadCon.TabIndex = 15;
            this.lsCadCon.SelectedIndexChanged += new System.EventHandler(this.lsCadCon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadenas de conexión disponibles:";
            // 
            // ConfBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 339);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.txtCadCon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsCadCon);
            this.Controls.Add(this.label1);
            this.Name = "ConfBD";
            this.Text = "ConfBD";
            this.Load += new System.EventHandler(this.ConfBD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.TextBox txtCadCon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEsquema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsCadCon;
        private System.Windows.Forms.Label label1;
    }
}