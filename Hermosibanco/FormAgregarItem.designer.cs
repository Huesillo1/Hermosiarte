
namespace Hermosibanco
{
    partial class FormAgregarItem
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.CantidadLabel = new System.Windows.Forms.Label();
            this.CantidadUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.DisponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtURLImagen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.ForeColor = System.Drawing.Color.Orange;
            this.TituloLabel.Location = new System.Drawing.Point(12, 9);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(226, 37);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Nuevo Articulo";
            this.TituloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.ForeColor = System.Drawing.Color.Orange;
            this.NombreLabel.Location = new System.Drawing.Point(14, 73);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(114, 25);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Descripcion";
            this.NombreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.NombreTextBox.ForeColor = System.Drawing.Color.Orange;
            this.NombreTextBox.Location = new System.Drawing.Point(134, 78);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(233, 20);
            this.NombreTextBox.TabIndex = 2;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.ForeColor = System.Drawing.Color.Orange;
            this.CantidadLabel.Location = new System.Drawing.Point(37, 113);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(91, 25);
            this.CantidadLabel.TabIndex = 5;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CantidadUpDown
            // 
            this.CantidadUpDown.BackColor = System.Drawing.SystemColors.ControlText;
            this.CantidadUpDown.ForeColor = System.Drawing.Color.Orange;
            this.CantidadUpDown.Location = new System.Drawing.Point(134, 113);
            this.CantidadUpDown.Name = "CantidadUpDown";
            this.CantidadUpDown.Size = new System.Drawing.Size(39, 20);
            this.CantidadUpDown.TabIndex = 6;
            // 
            // PrecioUpDown
            // 
            this.PrecioUpDown.BackColor = System.Drawing.SystemColors.ControlText;
            this.PrecioUpDown.DecimalPlaces = 2;
            this.PrecioUpDown.ForeColor = System.Drawing.Color.Orange;
            this.PrecioUpDown.Location = new System.Drawing.Point(317, 113);
            this.PrecioUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.PrecioUpDown.Name = "PrecioUpDown";
            this.PrecioUpDown.Size = new System.Drawing.Size(50, 20);
            this.PrecioUpDown.TabIndex = 8;
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.ForeColor = System.Drawing.Color.Orange;
            this.PrecioLabel.Location = new System.Drawing.Point(209, 113);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(88, 25);
            this.PrecioLabel.TabIndex = 7;
            this.PrecioLabel.Text = "Precio  $";
            // 
            // DisponibleCheckBox
            // 
            this.DisponibleCheckBox.AutoSize = true;
            this.DisponibleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisponibleCheckBox.ForeColor = System.Drawing.Color.Orange;
            this.DisponibleCheckBox.Location = new System.Drawing.Point(134, 191);
            this.DisponibleCheckBox.Name = "DisponibleCheckBox";
            this.DisponibleCheckBox.Size = new System.Drawing.Size(122, 29);
            this.DisponibleCheckBox.TabIndex = 9;
            this.DisponibleCheckBox.Text = "Disponible";
            this.DisponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtURLImagen
            // 
            this.txtURLImagen.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtURLImagen.ForeColor = System.Drawing.Color.Orange;
            this.txtURLImagen.Location = new System.Drawing.Point(134, 153);
            this.txtURLImagen.Name = "txtURLImagen";
            this.txtURLImagen.Size = new System.Drawing.Size(233, 20);
            this.txtURLImagen.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(14, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "URL imagen";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Orange;
            this.btnGuardar.Image = global::Hermosibanco.Properties.Resources.icons8_save_30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(134, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 51);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAgregarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(389, 298);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtURLImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisponibleCheckBox);
            this.Controls.Add(this.PrecioUpDown);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.CantidadUpDown);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.TituloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAgregarItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.Load += new System.EventHandler(this.FormAgregarItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label CantidadLabel;
        private System.Windows.Forms.NumericUpDown CantidadUpDown;
        private System.Windows.Forms.NumericUpDown PrecioUpDown;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.CheckBox DisponibleCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtURLImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
    }
}