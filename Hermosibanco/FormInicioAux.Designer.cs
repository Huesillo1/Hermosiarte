
namespace Hermosibanco
{
    partial class FormInicioAux
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizarRetiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Location = new System.Drawing.Point(12, 64);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(775, 414);
            this.pnlContenedor.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCuentaToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.transferirToolStripMenuItem,
            this.retirarToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.misComprasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miCuentaToolStripMenuItem.Text = "Mi &Cuenta";
            this.miCuentaToolStripMenuItem.Click += new System.EventHandler(this.miCuentaToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientosToolStripMenuItem.Text = "&Movimientos";
            this.movimientosToolStripMenuItem.Click += new System.EventHandler(this.movimientosToolStripMenuItem_Click);
            // 
            // transferirToolStripMenuItem
            // 
            this.transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            this.transferirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.transferirToolStripMenuItem.Text = "&Transferir";
            this.transferirToolStripMenuItem.Click += new System.EventHandler(this.transferirToolStripMenuItem_Click);
            // 
            // retirarToolStripMenuItem
            // 
            this.retirarToolStripMenuItem.Name = "retirarToolStripMenuItem";
            this.retirarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retirarToolStripMenuItem.Text = "Retirar";
            this.retirarToolStripMenuItem.Click += new System.EventHandler(this.retirarToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            this.tiendaToolStripMenuItem.Click += new System.EventHandler(this.tiendaToolStripMenuItem_Click);
            // 
            // misComprasToolStripMenuItem
            // 
            this.misComprasToolStripMenuItem.Name = "misComprasToolStripMenuItem";
            this.misComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.misComprasToolStripMenuItem.Text = "Mis Compras";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodoToolStripMenuItem,
            this.agregarUsuarioToolStripMenuItem,
            this.autorizarRetiroToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verTodoToolStripMenuItem.Text = "&Ver todo";
            this.verTodoToolStripMenuItem.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "&Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // autorizarRetiroToolStripMenuItem
            // 
            this.autorizarRetiroToolStripMenuItem.Name = "autorizarRetiroToolStripMenuItem";
            this.autorizarRetiroToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.autorizarRetiroToolStripMenuItem.Text = "Autorizar Retiro";
            this.autorizarRetiroToolStripMenuItem.Click += new System.EventHandler(this.autorizarRetiroToolStripMenuItem_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Orange;
            this.lblNombre.Location = new System.Drawing.Point(12, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 37);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Hola, ";
            // 
            // FormInicioAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(801, 492);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInicioAux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicioAux_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizarRetiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misComprasToolStripMenuItem;
    }
}