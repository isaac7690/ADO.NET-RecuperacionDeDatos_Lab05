namespace pjLaboratorio05_Consultas
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresPorDistritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasPorVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasPorRangoDeFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.vendedorPorInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoGeneralToolStripMenuItem,
            this.vendedoresPorDistritoToolStripMenuItem,
            this.vendedorPorInicialToolStripMenuItem,
            this.facturasPorVendedorToolStripMenuItem,
            this.facturasPorRangoDeFechaToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadoGeneralToolStripMenuItem
            // 
            this.listadoGeneralToolStripMenuItem.Name = "listadoGeneralToolStripMenuItem";
            this.listadoGeneralToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.listadoGeneralToolStripMenuItem.Text = "listado General";
            this.listadoGeneralToolStripMenuItem.Click += new System.EventHandler(this.listadoGeneralToolStripMenuItem_Click);
            // 
            // vendedoresPorDistritoToolStripMenuItem
            // 
            this.vendedoresPorDistritoToolStripMenuItem.Name = "vendedoresPorDistritoToolStripMenuItem";
            this.vendedoresPorDistritoToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.vendedoresPorDistritoToolStripMenuItem.Text = "Vendedores por Distrito";
            this.vendedoresPorDistritoToolStripMenuItem.Click += new System.EventHandler(this.vendedoresPorDistritoToolStripMenuItem_Click);
            // 
            // facturasPorVendedorToolStripMenuItem
            // 
            this.facturasPorVendedorToolStripMenuItem.Name = "facturasPorVendedorToolStripMenuItem";
            this.facturasPorVendedorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.facturasPorVendedorToolStripMenuItem.Text = "Facturas por Vendedor";
            this.facturasPorVendedorToolStripMenuItem.Click += new System.EventHandler(this.facturasPorVendedorToolStripMenuItem_Click);
            // 
            // facturasPorRangoDeFechaToolStripMenuItem
            // 
            this.facturasPorRangoDeFechaToolStripMenuItem.Name = "facturasPorRangoDeFechaToolStripMenuItem";
            this.facturasPorRangoDeFechaToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.facturasPorRangoDeFechaToolStripMenuItem.Text = "Facturas por rango de fecha";
            this.facturasPorRangoDeFechaToolStripMenuItem.Click += new System.EventHandler(this.facturasPorRangoDeFechaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // vendedorPorInicialToolStripMenuItem
            // 
            this.vendedorPorInicialToolStripMenuItem.Name = "vendedorPorInicialToolStripMenuItem";
            this.vendedorPorInicialToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.vendedorPorInicialToolStripMenuItem.Text = "vendedor por inicial";
            this.vendedorPorInicialToolStripMenuItem.Click += new System.EventHandler(this.vendedorPorInicialToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresPorDistritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasPorVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasPorRangoDeFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorPorInicialToolStripMenuItem;
    }
}



