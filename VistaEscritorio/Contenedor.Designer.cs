namespace VistaEscritorio
{
    partial class Contenedor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntoDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasLasSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasConPrecioMayorA1000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasConPrecioMenorA1000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basesDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.funcionesToolStripMenuItem});
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentaToolStripMenuItem,
            this.registrosDeVentasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clientesToolStripMenuItem.Text = "Venta ";
            // 
            // puntoDeVentaToolStripMenuItem
            // 
            this.puntoDeVentaToolStripMenuItem.Name = "puntoDeVentaToolStripMenuItem";
            this.puntoDeVentaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.puntoDeVentaToolStripMenuItem.Text = "Punto de venta";
            this.puntoDeVentaToolStripMenuItem.Click += new System.EventHandler(this.puntoDeVentaToolStripMenuItem_Click);
            // 
            // registrosDeVentasToolStripMenuItem
            // 
            this.registrosDeVentasToolStripMenuItem.Name = "registrosDeVentasToolStripMenuItem";
            this.registrosDeVentasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registrosDeVentasToolStripMenuItem.Text = "Registros de ventas";
            this.registrosDeVentasToolStripMenuItem.Click += new System.EventHandler(this.registrosDeVentasToolStripMenuItem_Click);
            // 
            // funcionesToolStripMenuItem
            // 
            this.funcionesToolStripMenuItem.Name = "funcionesToolStripMenuItem";
            this.funcionesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.funcionesToolStripMenuItem.Text = "Muebles";
            this.funcionesToolStripMenuItem.Click += new System.EventHandler(this.funcionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salasToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salasToolStripMenuItem
            // 
            this.salasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasSalasToolStripMenuItem,
            this.salasConPrecioMayorA1000ToolStripMenuItem,
            this.salasConPrecioMenorA1000ToolStripMenuItem});
            this.salasToolStripMenuItem.Name = "salasToolStripMenuItem";
            this.salasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salasToolStripMenuItem.Text = "Inventario";
            // 
            // todasLasSalasToolStripMenuItem
            // 
            this.todasLasSalasToolStripMenuItem.Name = "todasLasSalasToolStripMenuItem";
            this.todasLasSalasToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.todasLasSalasToolStripMenuItem.Text = "Todas las salas";
            this.todasLasSalasToolStripMenuItem.Click += new System.EventHandler(this.todasLasSalasToolStripMenuItem_Click);
            // 
            // salasConPrecioMayorA1000ToolStripMenuItem
            // 
            this.salasConPrecioMayorA1000ToolStripMenuItem.Name = "salasConPrecioMayorA1000ToolStripMenuItem";
            this.salasConPrecioMayorA1000ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.salasConPrecioMayorA1000ToolStripMenuItem.Text = "Salas con precio mayor a $1000";
            this.salasConPrecioMayorA1000ToolStripMenuItem.Click += new System.EventHandler(this.salasConPrecioMayorA1000ToolStripMenuItem_Click);
            // 
            // salasConPrecioMenorA1000ToolStripMenuItem
            // 
            this.salasConPrecioMenorA1000ToolStripMenuItem.Name = "salasConPrecioMenorA1000ToolStripMenuItem";
            this.salasConPrecioMenorA1000ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.salasConPrecioMenorA1000ToolStripMenuItem.Text = "Salas con precio menor a $1000";
            this.salasConPrecioMenorA1000ToolStripMenuItem.Click += new System.EventHandler(this.salasConPrecioMenorA1000ToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basesDeDatosToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // basesDeDatosToolStripMenuItem
            // 
            this.basesDeDatosToolStripMenuItem.Name = "basesDeDatosToolStripMenuItem";
            this.basesDeDatosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.basesDeDatosToolStripMenuItem.Text = "Bases de datos";
            this.basesDeDatosToolStripMenuItem.Click += new System.EventHandler(this.basesDeDatosToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Contenedor";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasSalasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasConPrecioMayorA1000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasConPrecioMenorA1000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basesDeDatosToolStripMenuItem;
    }
}

