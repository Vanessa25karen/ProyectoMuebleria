namespace VistaEscritorio
{
    partial class Muebles
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
            this.label10 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.BuscarCodigoSala = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SalasMenor = new System.Windows.Forms.CheckBox();
            this.BtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.TxtCodigoSala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMostrarSalas = new System.Windows.Forms.Button();
            this.DGVSalas = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.ToolStrip();
            this.TxtPrecioSillon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.TxtDescSala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNombreSala = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalas)).BeginInit();
            this.BtnGuardar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 17);
            this.label10.TabIndex = 75;
            this.label10.Text = "Salas con precio menor a $1000:";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Image = global::VistaEscritorio.Properties.Resources.eliminar;
            this.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(73, 22);
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = global::VistaEscritorio.Properties.Resources.lupa;
            this.BtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(67, 22);
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BuscarCodigoSala
            // 
            this.BuscarCodigoSala.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuscarCodigoSala.Name = "BuscarCodigoSala";
            this.BuscarCodigoSala.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 22);
            this.toolStripLabel1.Text = "Codigo de sala:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::VistaEscritorio.Properties.Resources.error;
            this.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(83, 22);
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Image = global::VistaEscritorio.Properties.Resources.actualizar;
            this.BtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(84, 22);
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.Image = global::VistaEscritorio.Properties.Resources.opcion_de_guardar_archivo;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton2.Text = "Guardar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SalasMenor
            // 
            this.SalasMenor.AutoSize = true;
            this.SalasMenor.Location = new System.Drawing.Point(237, 276);
            this.SalasMenor.Name = "SalasMenor";
            this.SalasMenor.Size = new System.Drawing.Size(15, 14);
            this.SalasMenor.TabIndex = 76;
            this.SalasMenor.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Image = global::VistaEscritorio.Properties.Resources.agregar_archivo;
            this.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(67, 22);
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtCodigoSala
            // 
            this.TxtCodigoSala.Location = new System.Drawing.Point(155, 95);
            this.TxtCodigoSala.Name = "TxtCodigoSala";
            this.TxtCodigoSala.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoSala.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Codigo de sala:";
            // 
            // BtnMostrarSalas
            // 
            this.BtnMostrarSalas.Location = new System.Drawing.Point(146, 20);
            this.BtnMostrarSalas.Name = "BtnMostrarSalas";
            this.BtnMostrarSalas.Size = new System.Drawing.Size(144, 23);
            this.BtnMostrarSalas.TabIndex = 12;
            this.BtnMostrarSalas.Text = "Mostrar salas:";
            this.BtnMostrarSalas.UseVisualStyleBackColor = true;
            this.BtnMostrarSalas.Click += new System.EventHandler(this.BtnMostrarSalas_Click);
            // 
            // DGVSalas
            // 
            this.DGVSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSalas.Location = new System.Drawing.Point(6, 57);
            this.DGVSalas.Name = "DGVSalas";
            this.DGVSalas.Size = new System.Drawing.Size(554, 222);
            this.DGVSalas.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNuevo,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.BtnModificar,
            this.toolStripSeparator2,
            this.BtnCancelar,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.BuscarCodigoSala,
            this.BtnBuscar,
            this.toolStripSeparator4,
            this.BtnEliminar});
            this.BtnGuardar.Location = new System.Drawing.Point(0, 0);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(858, 25);
            this.BtnGuardar.TabIndex = 63;
            this.BtnGuardar.Text = "toolStrip1";
            // 
            // TxtPrecioSillon
            // 
            this.TxtPrecioSillon.Location = new System.Drawing.Point(155, 312);
            this.TxtPrecioSillon.Name = "TxtPrecioSillon";
            this.TxtPrecioSillon.Size = new System.Drawing.Size(100, 20);
            this.TxtPrecioSillon.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Precio de sala:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 23);
            this.label11.TabIndex = 72;
            this.label11.Text = "Muebles";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(74, 98);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 71;
            // 
            // TxtDescSala
            // 
            this.TxtDescSala.Location = new System.Drawing.Point(155, 189);
            this.TxtDescSala.Multiline = true;
            this.TxtDescSala.Name = "TxtDescSala";
            this.TxtDescSala.Size = new System.Drawing.Size(100, 62);
            this.TxtDescSala.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Descripción de sala:";
            // 
            // TxtNombreSala
            // 
            this.TxtNombreSala.Location = new System.Drawing.Point(155, 141);
            this.TxtNombreSala.Name = "TxtNombreSala";
            this.TxtNombreSala.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreSala.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Nombre de sala:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMostrarSalas);
            this.groupBox1.Controls.Add(this.DGVSalas);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 285);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muebles";
            // 
            // Muebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 359);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SalasMenor);
            this.Controls.Add(this.TxtCodigoSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtPrecioSillon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TxtDescSala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNombreSala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Muebles";
            this.Text = "Muebles";
            this.Load += new System.EventHandler(this.Muebles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalas)).EndInit();
            this.BtnGuardar.ResumeLayout(false);
            this.BtnGuardar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripButton BtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.ToolStripTextBox BuscarCodigoSala;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.CheckBox SalasMenor;
        private System.Windows.Forms.ToolStripButton BtnNuevo;
        private System.Windows.Forms.TextBox TxtCodigoSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMostrarSalas;
        private System.Windows.Forms.DataGridView DGVSalas;
        private System.Windows.Forms.ToolStrip BtnGuardar;
        private System.Windows.Forms.TextBox TxtPrecioSillon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox TxtDescSala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNombreSala;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}