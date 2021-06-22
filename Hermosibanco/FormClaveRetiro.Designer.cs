
namespace Hermosibanco
{
    partial class FormClaveRetiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClaveRetiro));
            this.lblParte1 = new System.Windows.Forms.Label();
            this.lblParte2 = new System.Windows.Forms.Label();
            this.lblParte3 = new System.Windows.Forms.Label();
            this.lblParte4 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParte1
            // 
            this.lblParte1.AutoSize = true;
            this.lblParte1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte1.Location = new System.Drawing.Point(15, 29);
            this.lblParte1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParte1.Name = "lblParte1";
            this.lblParte1.Size = new System.Drawing.Size(77, 37);
            this.lblParte1.TabIndex = 0;
            this.lblParte1.Text = "0000";
            // 
            // lblParte2
            // 
            this.lblParte2.AutoSize = true;
            this.lblParte2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte2.Location = new System.Drawing.Point(104, 29);
            this.lblParte2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParte2.Name = "lblParte2";
            this.lblParte2.Size = new System.Drawing.Size(77, 37);
            this.lblParte2.TabIndex = 1;
            this.lblParte2.Text = "0000";
            // 
            // lblParte3
            // 
            this.lblParte3.AutoSize = true;
            this.lblParte3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte3.Location = new System.Drawing.Point(193, 29);
            this.lblParte3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParte3.Name = "lblParte3";
            this.lblParte3.Size = new System.Drawing.Size(77, 37);
            this.lblParte3.TabIndex = 2;
            this.lblParte3.Text = "0000";
            // 
            // lblParte4
            // 
            this.lblParte4.AutoSize = true;
            this.lblParte4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte4.Location = new System.Drawing.Point(283, 29);
            this.lblParte4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParte4.Name = "lblParte4";
            this.lblParte4.Size = new System.Drawing.Size(77, 37);
            this.lblParte4.TabIndex = 3;
            this.lblParte4.Text = "0000";
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(350, 2);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(41, 20);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 4;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // FormClaveRetiro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 90);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblParte4);
            this.Controls.Add(this.lblParte3);
            this.Controls.Add(this.lblParte2);
            this.Controls.Add(this.lblParte1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormClaveRetiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clave";
            this.Load += new System.EventHandler(this.FormClaveRetiro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormClaveRetiro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParte1;
        private System.Windows.Forms.Label lblParte2;
        private System.Windows.Forms.Label lblParte3;
        private System.Windows.Forms.Label lblParte4;
        private System.Windows.Forms.PictureBox pbClose;
    }
}