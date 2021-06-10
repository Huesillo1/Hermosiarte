using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermosibanco
{
    public partial class FormInicioAux : Form
    {
        BasedeDatos bd = new BasedeDatos();

        public FormInicioAux()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void FormInicioAux_Load(object sender, EventArgs e)
        {
            DataSet ds = bd.consult("nombre, apellido_paterno,apellido_materno", "usuarios", "id = " + Properties.Settings.Default.idUsuario, "SI");
            if (ds.Tables[0].Rows.Count > 0)
                lblNombre.Text = "Hola, " + ds.Tables[0].Rows[0]["nombre"].ToString() + " " + ds.Tables[0].Rows[0]["apellido_paterno"].ToString() + " " + ds.Tables[0].Rows[0]["apellido_materno"].ToString();
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
    }
}
