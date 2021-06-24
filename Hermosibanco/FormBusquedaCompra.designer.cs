
namespace Hermosibanco
{
    partial class FormBusquedaCompra
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Label();
            this.DatosGridView = new System.Windows.Forms.DataGridView();
            this.ID_CARRITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.entregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID del Carrito";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.IDTextBox.ForeColor = System.Drawing.Color.Orange;
            this.IDTextBox.Location = new System.Drawing.Point(108, 72);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.Orange;
            this.a.Location = new System.Drawing.Point(22, 33);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(220, 31);
            this.a.TabIndex = 5;
            this.a.Text = "Busqueda Por ID";
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // DatosGridView
            // 
            this.DatosGridView.AllowUserToAddRows = false;
            this.DatosGridView.AllowUserToDeleteRows = false;
            this.DatosGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CARRITO,
            this.TOTAL,
            this.FECHA_CREACION,
            this.STATUS});
            this.DatosGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.DatosGridView.Location = new System.Drawing.Point(22, 109);
            this.DatosGridView.MultiSelect = false;
            this.DatosGridView.Name = "DatosGridView";
            this.DatosGridView.ReadOnly = true;
            this.DatosGridView.Size = new System.Drawing.Size(528, 295);
            this.DatosGridView.TabIndex = 9;
            this.DatosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosGridView_CellContentClick);
            this.DatosGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosGridView_CellContentDoubleClick);
            this.DatosGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosGridView_CellDoubleClick);
            // 
            // ID_CARRITO
            // 
            this.ID_CARRITO.HeaderText = "ID CARRITO";
            this.ID_CARRITO.Name = "ID_CARRITO";
            this.ID_CARRITO.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // FECHA_CREACION
            // 
            this.FECHA_CREACION.HeaderText = "FECHA DE CREACION";
            this.FECHA_CREACION.Name = "FECHA_CREACION";
            this.FECHA_CREACION.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(334, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Filtrar Por Fecha";
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FiltroFecha.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.FiltroFecha.CalendarTitleForeColor = System.Drawing.Color.Orange;
            this.FiltroFecha.CustomFormat = "dd-MM-yyyy";
            this.FiltroFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FiltroFecha.Location = new System.Drawing.Point(340, 70);
            this.FiltroFecha.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(101, 23);
            this.FiltroFecha.TabIndex = 11;
            this.FiltroFecha.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(71, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "**Doble clic sobre el ID del carrito para mostrar mas informacion";
            this.label3.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entregarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // entregarToolStripMenuItem
            // 
            this.entregarToolStripMenuItem.Name = "entregarToolStripMenuItem";
            this.entregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entregarToolStripMenuItem.Text = "Entregar";
            this.entregarToolStripMenuItem.Click += new System.EventHandler(this.entregarToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // FormBusquedaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(564, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FiltroFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatosGridView);
            this.Controls.Add(this.a);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormBusquedaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revisar Compras";
            this.Load += new System.EventHandler(this.FormBusquedaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DataGridView DatosGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FiltroFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CARRITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
    }
}