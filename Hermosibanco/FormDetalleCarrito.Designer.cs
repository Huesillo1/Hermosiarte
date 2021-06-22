
namespace Hermosibanco
{
    partial class FormDetalleCarrito
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
<<<<<<< HEAD:Hermosibanco/FormDetalleCarrito.Designer.cs
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleCarrito));
=======
<<<<<<< HEAD
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleCompra));
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormDetalleCompra.Designer.cs
            this.InfoCompraGrid = new System.Windows.Forms.DataGridView();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.InfoCompraGrid)).BeginInit();
=======
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InfoCompraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.SuspendLayout();
            // 
            // InfoCompraGrid
            // 
<<<<<<< HEAD
=======
            this.InfoCompraGrid.AllowUserToAddRows = false;
            this.InfoCompraGrid.AllowUserToDeleteRows = false;
            this.InfoCompraGrid.AllowUserToOrderColumns = true;
            this.InfoCompraGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InfoCompraGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InfoCompraGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InfoCompraGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoCompraGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InfoCompraGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
<<<<<<< HEAD:Hermosibanco/FormDetalleCarrito.Designer.cs
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoCompraGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoCompraGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormDetalleCompra.Designer.cs
            this.InfoCompraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoCompraGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCRIPCION,
            this.FECHA_COMPRA,
            this.CANTIDAD,
            this.PRECIO_UNITARIO,
            this.TOTAL});
<<<<<<< HEAD
            this.InfoCompraGrid.Location = new System.Drawing.Point(12, 12);
            this.InfoCompraGrid.Name = "InfoCompraGrid";
            this.InfoCompraGrid.Size = new System.Drawing.Size(550, 121);
=======
            this.InfoCompraGrid.EnableHeadersVisualStyles = false;
            this.InfoCompraGrid.Location = new System.Drawing.Point(3, 42);
            this.InfoCompraGrid.Margin = new System.Windows.Forms.Padding(4);
            this.InfoCompraGrid.Name = "InfoCompraGrid";
            this.InfoCompraGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoCompraGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.InfoCompraGrid.RowHeadersWidth = 51;
<<<<<<< HEAD:Hermosibanco/FormDetalleCarrito.Designer.cs
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.InfoCompraGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.InfoCompraGrid.Size = new System.Drawing.Size(769, 286);
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.InfoCompraGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.InfoCompraGrid.Size = new System.Drawing.Size(767, 286);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormDetalleCompra.Designer.cs
            this.InfoCompraGrid.TabIndex = 0;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
<<<<<<< HEAD
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
=======
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 149;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // FECHA_COMPRA
            // 
            this.FECHA_COMPRA.HeaderText = "FECHA DE COMPRA";
<<<<<<< HEAD
            this.FECHA_COMPRA.Name = "FECHA_COMPRA";
            this.FECHA_COMPRA.ReadOnly = true;
=======
            this.FECHA_COMPRA.MinimumWidth = 6;
            this.FECHA_COMPRA.Name = "FECHA_COMPRA";
            this.FECHA_COMPRA.ReadOnly = true;
            this.FECHA_COMPRA.Width = 179;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
<<<<<<< HEAD
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
=======
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 124;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "PRECIO UNITARIO";
<<<<<<< HEAD
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
=======
            this.PRECIO_UNITARIO.MinimumWidth = 6;
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.ReadOnly = true;
            this.PRECIO_UNITARIO.Width = 163;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
<<<<<<< HEAD
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
=======
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 84;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(731, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(41, 31);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 7;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Detalles";
            // 
            // FormDetalleCarrito
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(773, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.InfoCompraGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDetalleCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetalleCarrito";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDetalleCompra_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.InfoCompraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548

        }

        #endregion

        private System.Windows.Forms.DataGridView InfoCompraGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
<<<<<<< HEAD
=======
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
    }
}