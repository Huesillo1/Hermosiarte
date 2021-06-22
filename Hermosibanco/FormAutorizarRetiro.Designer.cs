
namespace Hermosibanco
{
    partial class FormAutorizarRetiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.mnuAutoriza = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniAutorizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRechazar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniObservaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.txtClave = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.dtAnio = new System.Windows.Forms.DateTimePicker();
            this.rbAnio = new System.Windows.Forms.RadioButton();
            this.dtMes = new System.Windows.Forms.DateTimePicker();
            this.rbMes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.mnuAutoriza.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.mnuAutoriza;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(1, 97);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.Size = new System.Drawing.Size(1031, 413);
            this.dgvData.TabIndex = 5;
            this.dgvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // mnuAutoriza
            // 
            this.mnuAutoriza.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAutoriza.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAutorizar,
            this.mniRechazar,
            this.mniObservaciones});
            this.mnuAutoriza.Name = "mnuAutoriza";
            this.mnuAutoriza.Size = new System.Drawing.Size(175, 76);
            this.mnuAutoriza.Opening += new System.ComponentModel.CancelEventHandler(this.mnuAutoriza_Opening);
            // 
            // mniAutorizar
            // 
            this.mniAutorizar.Name = "mniAutorizar";
            this.mniAutorizar.Size = new System.Drawing.Size(174, 24);
            this.mniAutorizar.Text = "Autorizar";
            this.mniAutorizar.Click += new System.EventHandler(this.autorizarToolStripMenuItem_Click);
            // 
            // mniRechazar
            // 
            this.mniRechazar.Name = "mniRechazar";
            this.mniRechazar.Size = new System.Drawing.Size(174, 24);
            this.mniRechazar.Text = "Rechazar";
            this.mniRechazar.Click += new System.EventHandler(this.rechazarToolStripMenuItem_Click);
            // 
            // mniObservaciones
            // 
            this.mniObservaciones.Name = "mniObservaciones";
            this.mniObservaciones.Size = new System.Drawing.Size(174, 24);
            this.mniObservaciones.Text = "Observaciones";
            this.mniObservaciones.Click += new System.EventHandler(this.observacionesToolStripMenuItem_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(588, 32);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Mask = "####-####-####-####";
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(209, 30);
            this.txtClave.TabIndex = 12;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(802, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estatus";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "TODOS",
            "CANCELADO",
            "PENDIENTE",
            "APROBADO"});
            this.cbbStatus.Location = new System.Drawing.Point(806, 34);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(160, 28);
            this.cbbStatus.TabIndex = 8;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // dtAnio
            // 
            this.dtAnio.CustomFormat = "yyyy";
            this.dtAnio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAnio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAnio.Location = new System.Drawing.Point(504, 34);
            this.dtAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtAnio.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtAnio.Name = "dtAnio";
            this.dtAnio.ShowUpDown = true;
            this.dtAnio.Size = new System.Drawing.Size(75, 27);
            this.dtAnio.TabIndex = 7;
            this.dtAnio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbAnio
            // 
            this.rbAnio.AutoSize = true;
            this.rbAnio.Location = new System.Drawing.Point(504, 6);
            this.rbAnio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAnio.Name = "rbAnio";
            this.rbAnio.Size = new System.Drawing.Size(59, 21);
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
            this.dtMes.Location = new System.Drawing.Point(320, 34);
            this.dtMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtMes.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtMes.Name = "dtMes";
            this.dtMes.ShowUpDown = true;
            this.dtMes.Size = new System.Drawing.Size(175, 27);
            this.dtMes.TabIndex = 5;
            this.dtMes.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbMes
            // 
            this.rbMes.AutoSize = true;
            this.rbMes.Location = new System.Drawing.Point(320, 6);
            this.rbMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMes.Name = "rbMes";
            this.rbMes.Size = new System.Drawing.Size(58, 21);
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
            this.label1.Location = new System.Drawing.Point(150, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.CustomFormat = "dd-MM-yyyy";
            this.dtFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFin.Location = new System.Drawing.Point(177, 34);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaFin.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(133, 27);
            this.dtFechaFin.TabIndex = 2;
            this.dtFechaFin.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(13, 34);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtFechaInicio.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(133, 27);
            this.dtFechaInicio.TabIndex = 1;
            this.dtFechaInicio.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtFechaInicio.ValueChanged += new System.EventHandler(this.dtFechaInicio_ValueChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(13, 6);
            this.rbFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(74, 21);
            this.rbFecha.TabIndex = 0;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "FECHA";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // FormAutorizarRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1033, 510);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.dtAnio);
            this.Controls.Add(this.rbFecha);
            this.Controls.Add(this.rbAnio);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(this.dtMes);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.rbMes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAutorizarRetiro";
            this.Text = "Autorizar Retiro";
            this.Load += new System.EventHandler(this.FormAutorizarRetiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.mnuAutoriza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.DateTimePicker dtAnio;
        private System.Windows.Forms.RadioButton rbAnio;
        private System.Windows.Forms.DateTimePicker dtMes;
        private System.Windows.Forms.RadioButton rbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.ContextMenuStrip mnuAutoriza;
        private System.Windows.Forms.ToolStripMenuItem mniAutorizar;
        private System.Windows.Forms.ToolStripMenuItem mniRechazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtClave;
        private System.Windows.Forms.ToolStripMenuItem mniObservaciones;
    }
}