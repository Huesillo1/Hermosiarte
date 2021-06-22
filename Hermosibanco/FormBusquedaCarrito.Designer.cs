
namespace Hermosibanco
{
    partial class FormBusquedaCarrito
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
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
=======
<<<<<<< HEAD
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            this.DatosGridView = new System.Windows.Forms.DataGridView();
            this.ID_CARRITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREACION_FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosGridView
            // 
<<<<<<< HEAD
=======
            this.DatosGridView.AllowUserToAddRows = false;
            this.DatosGridView.AllowUserToDeleteRows = false;
            this.DatosGridView.AllowUserToOrderColumns = true;
            this.DatosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DatosGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DatosGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DatosGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatosGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatosGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
=======
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            this.DatosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CARRITO,
            this.TOTAL,
            this.CREACION_FECHA,
            this.STATUS});
<<<<<<< HEAD
            this.DatosGridView.Location = new System.Drawing.Point(37, 12);
            this.DatosGridView.Name = "DatosGridView";
            this.DatosGridView.Size = new System.Drawing.Size(446, 210);
=======
            this.DatosGridView.EnableHeadersVisualStyles = false;
            this.DatosGridView.Location = new System.Drawing.Point(3, 105);
            this.DatosGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DatosGridView.Name = "DatosGridView";
            this.DatosGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DatosGridView.RowHeadersWidth = 51;
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DatosGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DatosGridView.Size = new System.Drawing.Size(693, 401);
=======
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DatosGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DatosGridView.Size = new System.Drawing.Size(1062, 403);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            this.DatosGridView.TabIndex = 0;
            this.DatosGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosGridView_CellDoubleClick);
            // 
            // ID_CARRITO
            // 
            this.ID_CARRITO.HeaderText = "ID CARRITO";
<<<<<<< HEAD
            this.ID_CARRITO.Name = "ID_CARRITO";
            this.ID_CARRITO.ReadOnly = true;
=======
            this.ID_CARRITO.MinimumWidth = 6;
            this.ID_CARRITO.Name = "ID_CARRITO";
            this.ID_CARRITO.ReadOnly = true;
            this.ID_CARRITO.Width = 119;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
<<<<<<< HEAD
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
=======
            this.TOTAL.MinimumWidth = 6;
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 84;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // CREACION_FECHA
            // 
            this.CREACION_FECHA.HeaderText = "FECHA DE CREACION";
<<<<<<< HEAD
            this.CREACION_FECHA.Name = "CREACION_FECHA";
            this.CREACION_FECHA.ReadOnly = true;
=======
            this.CREACION_FECHA.MinimumWidth = 6;
            this.CREACION_FECHA.Name = "CREACION_FECHA";
            this.CREACION_FECHA.ReadOnly = true;
            this.CREACION_FECHA.Width = 193;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
<<<<<<< HEAD
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
=======
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 91;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< HEAD
            this.label1.Location = new System.Drawing.Point(37, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
=======
            this.label1.Location = new System.Drawing.Point(11, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 17);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.label1.TabIndex = 1;
            this.label1.Text = "**Doble clic sobre el ID del carrito para mostrar mas informacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busqueda Por ID";
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busqueda por ID";
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtrar Por Fecha";
=======
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtrar por fecha";
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            // 
            // label4
            // 
            this.label4.AutoSize = true;
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(50, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
=======
            this.label4.Location = new System.Drawing.Point(16, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.label4.TabIndex = 4;
            this.label4.Text = "Id del Carrito";
            // 
            // IDTextBox
            // 
<<<<<<< HEAD
            this.IDTextBox.Location = new System.Drawing.Point(122, 282);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
=======
            this.IDTextBox.Location = new System.Drawing.Point(112, 42);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(132, 22);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.IDTextBox.TabIndex = 5;
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(88, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(265, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.CustomFormat = "dd-MM-yyyy";
            this.FiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            this.FiltroFecha.Location = new System.Drawing.Point(403, 42);
            this.FiltroFecha.Margin = new System.Windows.Forms.Padding(4);
=======
<<<<<<< HEAD
            this.FiltroFecha.Location = new System.Drawing.Point(280, 285);
            this.FiltroFecha.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(101, 23);
=======
            this.FiltroFecha.Location = new System.Drawing.Point(432, 37);
            this.FiltroFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            this.FiltroFecha.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(133, 27);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.FiltroFecha.TabIndex = 7;
            this.FiltroFecha.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // button2
            // 
<<<<<<< HEAD
            this.button2.Location = new System.Drawing.Point(393, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
=======
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(558, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = false;
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBusquedaCarrito
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 365);
=======
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            this.ClientSize = new System.Drawing.Size(697, 510);
=======
            this.ClientSize = new System.Drawing.Size(1067, 510);
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FiltroFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatosGridView);
<<<<<<< HEAD
            this.Name = "FormBusquedaCompra";
            this.Text = "FormBusquedaCompra";
=======
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
<<<<<<< HEAD:Hermosibanco/FormBusquedaCarrito.Designer.cs
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBusquedaCarrito";
            this.Text = "Carritos";
=======
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBusquedaCompra";
            this.Text = "Compras";
>>>>>>> beb03d0e90b9290b6cf1f92b1c7423ae2eea8548
>>>>>>> aa4f97d8db71d227f61d457a87833dc7782d9f5d:Hermosibanco/FormBusquedaCompra.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARRITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREACION_FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FiltroFecha;
        private System.Windows.Forms.Button button2;
    }
}