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

namespace SistemaHotel_v1.Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();            
        }

        //Código para poder mover la ventana presionando la barra de título con el botón izquierdo del mouse
        /*
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wnsg, int wparam, int lparam);
        */

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (MessageBox.Show("¿Seguro que desea cerrar la aplicación?", "Alerta!!!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MoverPanelDeBotones(btnIni);
            Inicio ini = new Inicio();
            AddControlsToPanel(ini);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MoverPanelDeBotones(btnCheckIn);
            AbrirFormularioEnPanel(new FrmCheckIn());
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MoverPanelDeBotones(btnCheckOut);
        }

       
        private void btnVentas_Click(object sender, EventArgs e)
        {
            MoverPanelDeBotones(btnVentas);
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            panel10.Height = btnClientes.Height;
            panel10.Top = btnClientes.Top;     
            AbrirFormularioEnPanel(new FrmClientes());
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            MoverPanelDeBotones(btnFacturas);
        }

        private void MoverPanelDeBotones(Button b)
        {
            panel10.Height = b.Height;
            panel10.Top = b.Top;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(c);
        }

        private void AbrirFormularioEnPanel(object fhijo)
        {
            if (this.panelContenedor.Controls.Count>0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            Form fh= fhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0X112, 0x012, 0);
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmEmpleados());
        }
    }
}
