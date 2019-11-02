using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTrabajadores = new Trabajadores();
            formTrabajadores.MdiParent = this;
            formTrabajadores.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var prestamos = new Prestamos();
            prestamos.MdiParent = this;
            prestamos.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
            Panel1.Height = 25;
            Panel2.Height = 25;
            Panel3.Height = 25;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Panel1.Height = 150;
            Panel2.Height = 25;
            Panel3.Height = 25;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Panel1.Height = 25;
            Panel2.Height = 150;
            Panel3.Height = 25;
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Panel1.Height = 25;
            Panel2.Height = 25;
            Panel3.Height = 150;
        }

        private void Label1_DoubleClick(object sender, EventArgs e)
        {
            Panel1.Height = 25;
        }

        private void Label2_DoubleClick(object sender, EventArgs e)
        {
            Panel2.Height = 25;
        }

        private void Label3_DoubleClick(object sender, EventArgs e)
        {
            Panel3.Height = 25;
        }

        private void Label1_MouseEnter(object sender, EventArgs e)
        {
            Label1.BackColor = Color.AntiqueWhite;
        }

        private void Label1_MouseLeave(object sender, EventArgs e)
        {
            Label1.BackColor = Color.Silver;
        }

        private void Label4_MouseEnter(object sender, EventArgs e)
        {
            Label4.BackColor = Color.AntiqueWhite;
        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            Label4.BackColor = Color.Transparent;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.AntiqueWhite;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
