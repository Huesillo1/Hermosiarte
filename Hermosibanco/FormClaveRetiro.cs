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
    public partial class FormClaveRetiro : Form
    {
        private string clave_retiro;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void setClaveRetiro(string clave)
        {
            clave_retiro = clave;
        }

        public string getClaveRetiro()
        {
            return clave_retiro;
        }

        private void limpiarLabels()
        {
            lblParte1.Text = "";
            lblParte2.Text = "";
            lblParte3.Text = "";
            lblParte4.Text = "";
        }

        private void cargarClaveALabel()
        {
            char[] claveChar = new char[clave_retiro.Length];
            claveChar = clave_retiro.ToCharArray();
            for (int i = 0; i < 4; i++)
                lblParte1.Text += claveChar[i];
            for (int i = 4; i < 8; i++)
                lblParte2.Text += claveChar[i];
            for (int i = 8; i < 12; i++)
                lblParte3.Text += claveChar[i];
            for (int i = 12; i < 16; i++)
                lblParte4.Text += claveChar[i];
        }

        public FormClaveRetiro()
        {
            InitializeComponent();
        }

        private void FormClaveRetiro_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(clave_retiro))
            {
                limpiarLabels();
                cargarClaveALabel();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = Color.Orange;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = this.BackColor;
        }

        private void FormClaveRetiro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
