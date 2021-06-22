using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hermosibanco
{
    public partial class FormInicioAux : Form
    {
        BasedeDatos bd = new BasedeDatos();

        public FormInicioAux()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            label1.Text = fh.Text;
            fh.Show();
        }

        private void FormInicioAux_Load(object sender, EventArgs e)
        {
            //DataSet ds = bd.consult("nombre, apellido_paterno,apellido_materno", "usuarios", "id = " + Properties.Settings.Default.idUsuario, "SI");
            //if (ds.Tables[0].Rows.Count > 0)
            //    lblNombre.Text = "Hola, " + ds.Tables[0].Rows[0]["nombre"].ToString() + " " + ds.Tables[0].Rows[0]["apellido_paterno"].ToString() + " " + ds.Tables[0].Rows[0]["apellido_materno"].ToString();
            AbrirFormEnPanel(new FormMiCuenta());
        }

        private void miCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMiCuenta());
        }

        private void verTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormUsuarios());
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormMovimientos());
        }

        private void transferirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormTransferencias());
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarUsuario formAgregarUsuario = new FormAgregarUsuario();
            formAgregarUsuario.ShowDialog();
        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRetiros());
        }

        private void autorizarRetiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormAutorizarRetiro());
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Orange;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = this.BackColor;
        }

        private void pbMinimized_MouseEnter(object sender, EventArgs e)
        {
            pbMinimized.BackColor = Color.Orange;
        }

        private void pbMinimized_MouseLeave(object sender, EventArgs e)
        {
            pbMinimized.BackColor = this.BackColor;
        }
        private void FormInicioAux_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormHistorialCompras());
        }
    }
}
