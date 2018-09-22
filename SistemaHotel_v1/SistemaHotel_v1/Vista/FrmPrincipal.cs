using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel_v1.Vista
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

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
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel10.Height = btnIni.Height;
            panel10.Top = btnIni.Top;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            panel10.Height = btnCheckIn.Height;
            panel10.Top = btnCheckIn.Top;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panel10.Height = btnCheckOut.Height;
            panel10.Top = btnCheckOut.Top;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panel10.Height = btnReservas.Height;
            panel10.Top = btnReservas.Top;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panel10.Height = btnVentas.Height;
            panel10.Top = btnVentas.Top;
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            panel10.Height = btnClientes.Height;
            panel10.Top = btnClientes.Top;
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            panel10.Height = btnAdministrar.Height;
            panel10.Top = btnAdministrar.Top;
        }


    }
}
