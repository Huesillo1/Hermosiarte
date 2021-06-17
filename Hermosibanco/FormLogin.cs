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
    public partial class FormLogin : Form
    {
        BasedeDatos bd = new BasedeDatos();

        public FormLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private bool fieldsEmpty()
        {
            if (txtUser.Text == String.Empty || txtPass.Text == String.Empty)
                return true;
            return false;
        }

        private void auth()
        {
            DataSet ds;
            ds = bd.consult("id", "usuarios", "usuario = '" + txtUser.Text + "' and password = '" + txtPass.Text + "'", "SI");
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.Hide();
                FormInicioAux formInicioAux = new FormInicioAux();
                Properties.Settings.Default.idUsuario = ds.Tables[0].Rows[0]["id"].ToString();
                formInicioAux.ShowDialog();
                this.Show();
                txtPass.Text = "";
                txtPass.Focus();
            }
            else
            {
                txtPass.Text = "";
                txtPass.Focus();
                MessageBox.Show("Usuario o contraseña incorrectos", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (fieldsEmpty())
                MessageBox.Show("Debe de rellenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                auth();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txtPass.Focus();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
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

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackColor = Color.Orange;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackColor = this.BackColor;
        }
    }
}

