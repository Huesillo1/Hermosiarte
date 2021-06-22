
namespace Hermosibanco
{
    partial class FormDetalleCompra
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
            this.InfoCompraGrid = new System.Windows.Forms.DataGridView();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InfoCompraGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoCompraGrid
            // 
            this.InfoCompraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoCompraGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPCION,
            this.FECHA_COMPRA,
            this.CANTIDAD,
            this.PRECIO_UNITARIO,
            this.TOTAL});
            this.InfoCompraGrid.Location = new System.Drawing.Point(12, 12);
            this.InfoCompraGrid.Name = "InfoCompraGrid";
            this.InfoCompraGrid.Size = new System.Drawing.Size(550, 121);
            this.InfoCompraGrid.TabIndex = 0;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // FECHA_COMPRA
            // 
            this.FECHA_COMPRA.HeaderText = "FECHA DE COMPRA";
            this.FECHA_COMPRA.Name = "FECHA_COMPRA";
            this.FECHA_COMPRA.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // FormDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 140);
            this.Controls.Add(this.InfoCompraGrid);
            this.Name = "FormDetalleCompra";
            this.Text = "FormDetalleCompra";
            ((System.ComponentModel.ISupportInitialize)(this.InfoCompraGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView InfoCompraGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}