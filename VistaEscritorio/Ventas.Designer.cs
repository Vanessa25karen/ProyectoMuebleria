namespace VistaEscritorio
{
    partial class Ventas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar2 = new System.Windows.Forms.Button();
            this.TxtBuscarVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVSalas = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtBuscarMueble = new System.Windows.Forms.ToolStripTextBox();
            this.BtnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMostrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalas)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar2);
            this.groupBox1.Controls.Add(this.TxtBuscarVenta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DGVSalas);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 337);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // BtnBuscar2
            // 
            this.BtnBuscar2.Location = new System.Drawing.Point(316, 32);
            this.BtnBuscar2.Name = "BtnBuscar2";
            this.BtnBuscar2.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar2.TabIndex = 9;
            this.BtnBuscar2.Text = "Buscar";
            this.BtnBuscar2.UseVisualStyleBackColor = true;
            this.BtnBuscar2.Click += new System.EventHandler(this.BtnBuscar2_Click);
            // 
            // TxtBuscarVenta
            // 
            this.TxtBuscarVenta.Location = new System.Drawing.Point(152, 33);
            this.TxtBuscarVenta.Name = "TxtBuscarVenta";
            this.TxtBuscarVenta.Size = new System.Drawing.Size(133, 21);
            this.TxtBuscarVenta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Codigo de venta:";
            // 
            // DGVSalas
            // 
            this.DGVSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSalas.Location = new System.Drawing.Point(6, 71);
            this.DGVSalas.Name = "DGVSalas";
            this.DGVSalas.Size = new System.Drawing.Size(755, 251);
            this.DGVSalas.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCancelar,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.TxtBuscarMueble,
            this.BtnBuscar,
            this.toolStripSeparator1,
            this.BtnMostrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 25);
            this.toolStrip1.TabIndex = 57;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(103, 22);
            this.toolStripLabel1.Text = "Codigo Mueble:";
            // 
            // TxtBuscarMueble
            // 
            this.TxtBuscarMueble.Name = "TxtBuscarMueble";
            this.TxtBuscarMueble.Size = new System.Drawing.Size(100, 25);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Image = global::VistaEscritorio.Properties.Resources.tabla_de_datos;
            this.BtnMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(113, 22);
            this.BtnMostrar.Text = "Mostrar Ventas";
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalas)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBuscar2;
        private System.Windows.Forms.TextBox TxtBuscarVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVSalas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtBuscarMueble;
        private System.Windows.Forms.ToolStripButton BtnBuscar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnMostrar;
    }
}