﻿
namespace Hermosibanco
{
    partial class FormUsuarios
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dgvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.depositarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.dgvMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.ContextMenuStrip = this.dgvMenu;
            this.dgvData.Location = new System.Drawing.Point(-1, 74);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(776, 285);
            this.dgvData.TabIndex = 1;
            // 
            // dgvMenu
            // 
            this.dgvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.toolStripSeparator1,
            this.depositarToolStripMenuItem});
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.Size = new System.Drawing.Size(181, 120);
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar Usuario";
            this.eliminarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // depositarToolStripMenuItem
            // 
            this.depositarToolStripMenuItem.Name = "depositarToolStripMenuItem";
            this.depositarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depositarToolStripMenuItem.Text = "Depositar";
            this.depositarToolStripMenuItem.Click += new System.EventHandler(this.depositarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbbStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ACTIVO",
            "INACTIVO"});
            this.cbbStatus.Location = new System.Drawing.Point(296, 39);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(122, 23);
            this.cbbStatus.TabIndex = 2;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cuenta";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(192, 39);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(98, 23);
            this.txtCuenta.TabIndex = 1;
            this.txtCuenta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            this.txtCuenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuenta_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Hermosibanco.Properties.Resources.icons8_update_file_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(121, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Hermosibanco.Properties.Resources.icons8_new_contact_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-1, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.dgvMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip dgvMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem depositarToolStripMenuItem;
    }
}