
namespace Hermosibanco
{
    partial class Product
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.addCart = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.cantCart = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addCart
            // 
            this.addCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCart.ForeColor = System.Drawing.Color.Orange;
            this.addCart.Location = new System.Drawing.Point(105, 217);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(91, 23);
            this.addCart.TabIndex = 1;
            this.addCart.Text = "Añadir al carrito";
            this.addCart.UseVisualStyleBackColor = false;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Orange;
            this.description.Location = new System.Drawing.Point(10, 138);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(183, 23);
            this.description.TabIndex = 2;
            this.description.Text = "Name";
            this.description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Orange;
            this.price.Location = new System.Drawing.Point(10, 161);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(183, 25);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            this.price.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cantCart
            // 
            this.cantCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cantCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cantCart.ForeColor = System.Drawing.Color.Orange;
            this.cantCart.Location = new System.Drawing.Point(13, 220);
            this.cantCart.Name = "cantCart";
            this.cantCart.Size = new System.Drawing.Size(86, 16);
            this.cantCart.TabIndex = 4;
            this.cantCart.ValueChanged += new System.EventHandler(this.cantCart_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cant
            // 
            this.cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cant.ForeColor = System.Drawing.Color.Orange;
            this.cant.Location = new System.Drawing.Point(10, 186);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(183, 23);
            this.cant.TabIndex = 5;
            this.cant.Text = "Disponibles:";
            this.cant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cant);
            this.Controls.Add(this.cantCart);
            this.Controls.Add(this.price);
            this.Controls.Add(this.description);
            this.Controls.Add(this.addCart);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "Product";
            this.Size = new System.Drawing.Size(210, 256);
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.NumericUpDown cantCart;
        private System.Windows.Forms.Label cant;
    }
}
