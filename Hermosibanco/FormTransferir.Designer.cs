
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbbMisCuentas = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Black;
            this.txtNombre.ForeColor = System.Drawing.Color.Orange;
            this.txtNombre.Location = new System.Drawing.Point(12, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(203, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // cbbMisCuentas
            // 
            this.cbbMisCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMisCuentas.FormattingEnabled = true;
            this.cbbMisCuentas.Location = new System.Drawing.Point(12, 21);
            this.cbbMisCuentas.Name = "cbbMisCuentas";
            this.cbbMisCuentas.Size = new System.Drawing.Size(203, 21);
            this.cbbMisCuentas.TabIndex = 2;
            this.cbbMisCuentas.SelectedIndexChanged += new System.EventHandler(this.cbbMisCuentas_SelectedIndexChanged);
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.Color.Black;
            this.txtCuenta.ForeColor = System.Drawing.Color.Orange;
            this.txtCuenta.Location = new System.Drawing.Point(12, 71);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.ReadOnly = true;
            this.txtCuenta.Size = new System.Drawing.Size(121, 20);
            this.txtCuenta.TabIndex = 3;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Black;
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.ForeColor = System.Drawing.Color.Orange;
            this.txtMonto.Location = new System.Drawing.Point(13, 149);
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
            this.txtMonto.Size = new System.Drawing.Size(120, 20);
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
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mis cuentas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cuenta receptora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(10, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto";
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.Black;
            this.btnTransferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTransferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferir.ForeColor = System.Drawing.Color.Orange;
            this.btnTransferir.Location = new System.Drawing.Point(12, 187);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(202, 23);
            this.btnTransferir.TabIndex = 9;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Black;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.ForeColor = System.Drawing.Color.Orange;
            this.btnValidar.Location = new System.Drawing.Point(139, 146);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(76, 23);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormTransferir
            // 
            this.AcceptButton = this.btnTransferir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(227, 222);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.cbbMisCuentas);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTransferir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferir";
            this.Load += new System.EventHandler(this.FormTransferir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbbMisCuentas;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnValidar;
    }
}