
namespace Hermosibanco
{
    partial class FormTransferir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransferir));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.cbbMisCuentas = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(16, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(269, 28);
            this.txtNombre.TabIndex = 0;
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTransferir.Enabled = false;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransferir.Location = new System.Drawing.Point(16, 230);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(271, 28);
            this.btnTransferir.TabIndex = 1;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // cbbMisCuentas
            // 
            this.cbbMisCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMisCuentas.FormattingEnabled = true;
            this.cbbMisCuentas.Location = new System.Drawing.Point(16, 26);
            this.cbbMisCuentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbMisCuentas.Name = "cbbMisCuentas";
            this.cbbMisCuentas.Size = new System.Drawing.Size(269, 29);
            this.cbbMisCuentas.TabIndex = 2;
            this.cbbMisCuentas.SelectedIndexChanged += new System.EventHandler(this.cbbMisCuentas_SelectedIndexChanged);
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.White;
            this.txtCuenta.Location = new System.Drawing.Point(16, 87);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(160, 28);
            this.txtCuenta.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(17, 183);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtMonto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(160, 28);
            this.txtMonto.TabIndex = 4;
            this.txtMonto.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtMonto.ValueChanged += new System.EventHandler(this.txtMonto_ValueChanged);
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mis cuentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cuenta receptora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnValidar.Location = new System.Drawing.Point(185, 183);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(103, 28);
            this.btnValidar.TabIndex = 8;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(265, -3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 22);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 9;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // FormTransferir
            // 
            this.AcceptButton = this.btnTransferir;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(303, 273);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.cbbMisCuentas);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.txtNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTransferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.Load += new System.EventHandler(this.FormTransferir_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTransferir_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.ComboBox cbbMisCuentas;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox pbClose;
    }
}