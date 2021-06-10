
namespace Hermosibanco
{
    partial class FormTransferencias
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCuentaEmisora = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCuentaReceptora = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuTransferencias = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniTransferir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnValidar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.menuTransferencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCuentaEmisora);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta Emisora";
            // 
            // cbbCuentaEmisora
            // 
            this.cbbCuentaEmisora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCuentaEmisora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCuentaEmisora.FormattingEnabled = true;
            this.cbbCuentaEmisora.Location = new System.Drawing.Point(6, 19);
            this.cbbCuentaEmisora.Name = "cbbCuentaEmisora";
            this.cbbCuentaEmisora.Size = new System.Drawing.Size(319, 23);
            this.cbbCuentaEmisora.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCuentaReceptora);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 49);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta Receptora";
            // 
            // txtCuentaReceptora
            // 
            this.txtCuentaReceptora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaReceptora.Location = new System.Drawing.Point(6, 19);
            this.txtCuentaReceptora.Name = "txtCuentaReceptora";
            this.txtCuentaReceptora.Size = new System.Drawing.Size(316, 23);
            this.txtCuentaReceptora.TabIndex = 0;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.menuTransferencias;
            this.dgvData.Location = new System.Drawing.Point(12, 67);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(751, 335);
            this.dgvData.TabIndex = 2;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // menuTransferencias
            // 
            this.menuTransferencias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTransferir});
            this.menuTransferencias.Name = "menuTransferencias";
            this.menuTransferencias.Size = new System.Drawing.Size(181, 48);
            this.menuTransferencias.Opening += new System.ComponentModel.CancelEventHandler(this.menuTransferencias_Opening);
            // 
            // mniTransferir
            // 
            this.mniTransferir.Name = "mniTransferir";
            this.mniTransferir.Size = new System.Drawing.Size(180, 22);
            this.mniTransferir.Text = "Transferir";
            this.mniTransferir.Click += new System.EventHandler(this.transferirToolStripMenuItem_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(688, 31);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 3;
            this.btnValidar.Text = "Agregar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // FormTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTransferencias";
            this.Text = "FormTransferencias";
            this.Load += new System.EventHandler(this.FormTransferencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.menuTransferencias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCuentaEmisora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCuentaReceptora;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ContextMenuStrip menuTransferencias;
        private System.Windows.Forms.ToolStripMenuItem mniTransferir;
    }
}