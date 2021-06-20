
namespace Hermosibanco
{
    partial class FormAgregarItems
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.LinkTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CantidadUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioUpDown = new System.Windows.Forms.NumericUpDown();
            this.DisponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(18, 88);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(185, 20);
            this.DescripcionTextBox.TabIndex = 2;
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(18, 150);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(185, 42);
            this.LinkTextBox.TabIndex = 3;
            this.LinkTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Link Imagen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio";
            // 
            // CantidadUpDown
            // 
            this.CantidadUpDown.Location = new System.Drawing.Point(111, 211);
            this.CantidadUpDown.Name = "CantidadUpDown";
            this.CantidadUpDown.Size = new System.Drawing.Size(51, 20);
            this.CantidadUpDown.TabIndex = 7;
            // 
            // PrecioUpDown
            // 
            this.PrecioUpDown.DecimalPlaces = 2;
            this.PrecioUpDown.Location = new System.Drawing.Point(111, 247);
            this.PrecioUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PrecioUpDown.Name = "PrecioUpDown";
            this.PrecioUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecioUpDown.TabIndex = 8;
            // 
            // DisponibleCheckBox
            // 
            this.DisponibleCheckBox.AutoSize = true;
            this.DisponibleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisponibleCheckBox.Location = new System.Drawing.Point(18, 273);
            this.DisponibleCheckBox.Name = "DisponibleCheckBox";
            this.DisponibleCheckBox.Size = new System.Drawing.Size(122, 29);
            this.DisponibleCheckBox.TabIndex = 10;
            this.DisponibleCheckBox.Text = "Disponible";
            this.DisponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(87, 308);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 11;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // FormAgregarItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 336);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.DisponibleCheckBox);
            this.Controls.Add(this.PrecioUpDown);
            this.Controls.Add(this.CantidadUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarItems";
            this.Text = "FormAgregarItems";
            ((System.ComponentModel.ISupportInitialize)(this.CantidadUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.RichTextBox LinkTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CantidadUpDown;
        private System.Windows.Forms.NumericUpDown PrecioUpDown;
        private System.Windows.Forms.CheckBox DisponibleCheckBox;
        private System.Windows.Forms.Button AgregarButton;
    }
}