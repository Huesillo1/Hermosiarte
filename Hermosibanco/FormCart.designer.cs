
namespace Hermosibanco
{
    partial class FormCart
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
            this.precioLabel = new System.Windows.Forms.Label();
            this.buyCart = new System.Windows.Forms.Button();
            this.deleteCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeCart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio total de la compra:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precioLabel
            // 
            this.precioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioLabel.ForeColor = System.Drawing.Color.Orange;
            this.precioLabel.Location = new System.Drawing.Point(97, 100);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(177, 36);
            this.precioLabel.TabIndex = 1;
            this.precioLabel.Text = "Carrito vacío";
            this.precioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buyCart
            // 
            this.buyCart.BackColor = System.Drawing.Color.Black;
            this.buyCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyCart.ForeColor = System.Drawing.Color.Orange;
            this.buyCart.Location = new System.Drawing.Point(207, 180);
            this.buyCart.Name = "buyCart";
            this.buyCart.Size = new System.Drawing.Size(88, 23);
            this.buyCart.TabIndex = 2;
            this.buyCart.Text = "Comprar";
            this.buyCart.UseVisualStyleBackColor = false;
            this.buyCart.Click += new System.EventHandler(this.buyCart_Click);
            // 
            // deleteCart
            // 
            this.deleteCart.BackColor = System.Drawing.Color.Black;
            this.deleteCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCart.ForeColor = System.Drawing.Color.Orange;
            this.deleteCart.Location = new System.Drawing.Point(77, 180);
            this.deleteCart.Name = "deleteCart";
            this.deleteCart.Size = new System.Drawing.Size(88, 23);
            this.deleteCart.TabIndex = 3;
            this.deleteCart.Text = "Vaciar carrito";
            this.deleteCart.UseVisualStyleBackColor = false;
            this.deleteCart.Click += new System.EventHandler(this.deleteCart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.closeCart);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 31);
            this.panel1.TabIndex = 4;
            // 
            // closeCart
            // 
            this.closeCart.BackgroundImage = global::Hermosibanco.Properties.Resources.icons8_cancelar_30;
            this.closeCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeCart.FlatAppearance.BorderSize = 0;
            this.closeCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeCart.Location = new System.Drawing.Point(354, 3);
            this.closeCart.Name = "closeCart";
            this.closeCart.Size = new System.Drawing.Size(23, 23);
            this.closeCart.TabIndex = 0;
            this.closeCart.UseVisualStyleBackColor = true;
            this.closeCart.Click += new System.EventHandler(this.closeCart_Click);
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(379, 229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteCart);
            this.Controls.Add(this.buyCart);
            this.Controls.Add(this.precioLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCart";
            this.Load += new System.EventHandler(this.FormCart_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Button buyCart;
        private System.Windows.Forms.Button deleteCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeCart;
    }
}