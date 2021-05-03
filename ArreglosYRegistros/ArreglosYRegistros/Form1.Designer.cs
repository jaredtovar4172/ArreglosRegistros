namespace ArreglosYRegistros
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreDelProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porExistenciaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaParToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.agregarDatosToolStripMenuItem.Text = "Agregar datos";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreDelProductosToolStripMenuItem,
            this.porPrecioDeProductosToolStripMenuItem,
            this.porExistenciaDeProductosToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar datos";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.todosLosDatosToolStripMenuItem.Text = "Todos los datos";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // porNombreDelProductosToolStripMenuItem
            // 
            this.porNombreDelProductosToolStripMenuItem.Name = "porNombreDelProductosToolStripMenuItem";
            this.porNombreDelProductosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.porNombreDelProductosToolStripMenuItem.Text = "Por nombre del productos";
            this.porNombreDelProductosToolStripMenuItem.Click += new System.EventHandler(this.porNombreDelProductosToolStripMenuItem_Click);
            // 
            // porPrecioDeProductosToolStripMenuItem
            // 
            this.porPrecioDeProductosToolStripMenuItem.Name = "porPrecioDeProductosToolStripMenuItem";
            this.porPrecioDeProductosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.porPrecioDeProductosToolStripMenuItem.Text = "Por precio de productos";
            this.porPrecioDeProductosToolStripMenuItem.Click += new System.EventHandler(this.porPrecioDeProductosToolStripMenuItem_Click);
            // 
            // porExistenciaDeProductosToolStripMenuItem
            // 
            this.porExistenciaDeProductosToolStripMenuItem.Name = "porExistenciaDeProductosToolStripMenuItem";
            this.porExistenciaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.porExistenciaDeProductosToolStripMenuItem.Text = "Por existencia de productos";
            this.porExistenciaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.porExistenciaDeProductosToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar datos";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.modificarDatosToolStripMenuItem.Text = "Modificar datos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarLosProductosConExistenciaParToolStripMenuItem,
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem,
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem,
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem1,
            this.mostrarElProductoToolStripMenuItem,
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem,
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mostrarLosProductosConExistenciaParToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Name = "mostrarLosProductosConExistenciaParToolStripMenuItem";
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Text = "Mostrar los productos con existencia par";
            this.mostrarLosProductosConExistenciaParToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosConExistenciaParToolStripMenuItem_Click);
            // 
            // mostrarLosProductosConExistenciaImparToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Name = "mostrarLosProductosConExistenciaImparToolStripMenuItem";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Text = "Mostrar los productos con existencia impar";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosConExistenciaImparToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMayorPrecioToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Name = "mostrarElProductoDeMayorPrecioToolStripMenuItem";
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Text = "Mostrar el producto de mayor precio";
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoDeMayorPrecioToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMayorPrecioToolStripMenuItem1
            // 
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem1.Name = "mostrarElProductoDeMayorPrecioToolStripMenuItem1";
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem1.Size = new System.Drawing.Size(465, 26);
            this.mostrarElProductoDeMayorPrecioToolStripMenuItem1.Text = "Mostrar el producto de menor precio";
            // 
            // mostrarElProductoToolStripMenuItem
            // 
            this.mostrarElProductoToolStripMenuItem.Name = "mostrarElProductoToolStripMenuItem";
            this.mostrarElProductoToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarElProductoToolStripMenuItem.Text = "Mostrar la suma y promedio del precio de los productos";
            this.mostrarElProductoToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMayorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMayorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Text = "Mostrar el producto de mayor existencia";
            // 
            // mostrarElProductoDeMenorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMenorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(465, 26);
            this.mostrarElProductoDeMenorExistenciaToolStripMenuItem.Text = "Mostrar el producto de menor existencia";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(58, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(665, 237);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del producto";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio del producto";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Existencia del producto";
            this.columnHeader4.Width = 157;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreDelProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porExistenciaDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaParToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaImparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorPrecioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMenorExistenciaToolStripMenuItem;
    }
}

