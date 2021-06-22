﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.NombreLabel.Location = new System.Drawing.Point(72, 46);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(114, 25);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Descripcion";
            this.NombreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(43, 74);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(163, 20);
            this.NombreTextBox.TabIndex = 2;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // CantidadLabel
            // 
            this.CantidadLabel.AutoSize = true;
            this.CantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadLabel.Location = new System.Drawing.Point(59, 105);
            this.CantidadLabel.Name = "CantidadLabel";
            this.CantidadLabel.Size = new System.Drawing.Size(91, 25);
            this.CantidadLabel.TabIndex = 5;
            this.CantidadLabel.Text = "Cantidad";
            this.CantidadLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // CantidadUpDown
            // 
            this.CantidadUpDown.Location = new System.Drawing.Point(167, 105);
            this.CantidadUpDown.Name = "CantidadUpDown";
            this.CantidadUpDown.Size = new System.Drawing.Size(39, 20);
            this.CantidadUpDown.TabIndex = 6;
            // 
            // PrecioUpDown
            // 
            this.PrecioUpDown.DecimalPlaces = 2;
            this.PrecioUpDown.Location = new System.Drawing.Point(167, 138);
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
            this.PrecioLabel.Location = new System.Drawing.Point(59, 138);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(88, 25);
            this.PrecioLabel.TabIndex = 7;
            this.PrecioLabel.Text = "Precio  $";
            // 
            // DisponibleCheckBox
            // 
            this.DisponibleCheckBox.AutoSize = true;
            this.DisponibleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisponibleCheckBox.Location = new System.Drawing.Point(64, 166);
            this.DisponibleCheckBox.Name = "DisponibleCheckBox";
            this.DisponibleCheckBox.Size = new System.Drawing.Size(122, 29);
            this.DisponibleCheckBox.TabIndex = 9;
            this.DisponibleCheckBox.Text = "Disponible";
            this.DisponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAgregarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisponibleCheckBox);
            this.Controls.Add(this.PrecioUpDown);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.CantidadUpDown);
            this.Controls.Add(this.CantidadLabel);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "FormAgregarItem";
            this.Text = "FormAgregarItem";
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
    }
}