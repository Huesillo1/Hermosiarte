
namespace Hermosibanco
{
    partial class FormMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.dtAnio = new System.Windows.Forms.DateTimePicker();
            this.rbAnio = new System.Windows.Forms.RadioButton();
            this.dtMes = new System.Windows.Forms.DateTimePicker();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTipo);
            this.groupBox1.Controls.Add(this.dtAnio);
            this.groupBox1.Controls.Add(this.rbAnio);
            this.groupBox1.Controls.Add(this.dtMes);
            this.groupBox1.Controls.Add(this.rbMes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(469, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo";
            // 
            // cbbTipo
            // 
            this.cbbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Items.AddRange(new object[] {
            "TODOS",
            "DEPOSITO",
            "TRANSFERENCIA",
            "RETIRO"});
            this.cbbTipo.Location = new System.Drawing.Point(472, 45);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 23);
            this.cbbTipo.TabIndex = 8;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.cbbTipo_SelectedIndexChanged);
            // 
            // dtAnio
            // 
            this.dtAnio.CustomFormat = "yyyy";
            this.dtAnio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAnio.Location = new System.Drawing.Point(399, 45);
            this.dtAnio.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtAnio.Name = "dtAnio";
            this.dtAnio.ShowUpDown = true;
            this.dtAnio.Size = new System.Drawing.Size(57, 23);
            this.dtAnio.TabIndex = 7;
            this.dtAnio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbAnio
            // 
            this.rbAnio.AutoSize = true;
            this.rbAnio.ForeColor = System.Drawing.Color.Orange;
            this.rbAnio.Location = new System.Drawing.Point(399, 22);
            this.rbAnio.Name = "rbAnio";
            this.rbAnio.Size = new System.Drawing.Size(48, 17);
            this.rbAnio.TabIndex = 6;
            this.rbAnio.TabStop = true;
            this.rbAnio.Text = "AÑO";
            this.rbAnio.UseVisualStyleBackColor = true;
            this.rbAnio.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // dtMes
            // 
            this.dtMes.CustomFormat = "MMMM-yyyy";
            this.dtMes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMes.Location = new System.Drawing.Point(251, 45);
            this.dtMes.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtMes.Name = "dtMes";
            this.dtMes.ShowUpDown = true;
            this.dtMes.Size = new System.Drawing.Size(132, 23);
            this.dtMes.TabIndex = 5;
            this.dtMes.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.ForeColor = System.Drawing.Color.Orange;
            this.rbMes.Location = new System.Drawing.Point(251, 22);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(48, 17);
            this.rbMes.TabIndex = 4;
            this.rbMes.TabStop = true;
            this.rbMes.Text = "MES";
            this.rbMes.UseVisualStyleBackColor = true;
            this.rbMes.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(113, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(134, 45);
            this.dtFechaFin.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(101, 23);
            this.dtFechaFin.TabIndex = 2;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(6, 45);
            this.dtFechaInicio.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(101, 23);
            this.dtFechaInicio.TabIndex = 1;
            this.dtFechaInicio.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.ForeColor = System.Drawing.Color.Orange;
            this.rbFecha.Location = new System.Drawing.Point(6, 22);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(60, 17);
            this.rbFecha.TabIndex = 0;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "FECHA";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(-2, 108);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(774, 304);
            this.dgvData.TabIndex = 10;
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientos";
            this.Text = "FormMovimientos";
            this.Load += new System.EventHandler(this.FormMovimientos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.DateTimePicker dtAnio;
        private System.Windows.Forms.RadioButton rbAnio;
        private System.Windows.Forms.DateTimePicker dtMes;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.DataGridView dgvData;
    }
}