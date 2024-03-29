﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RRHH.BL;

namespace RRHHPlanilla
{
    public partial class FormLogin : Form

    {
        SeguridadBL _seguridad;

        public bool UsuarioAutenticado { get; set; }
        public bool Cancelar { get; set; }

        public bool u { get; set; }
        public bool c { get; set; }

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region BOTONES   
        private void button2_Click(object sender, EventArgs e)
        {         
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                //UsuarioAutenticado = Cancelar;
                Application.Exit();               
            }

            if (result == DialogResult.No)
            {

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = alphaBlendTextBox1.Text;
            contrasena = alphaBlendTextBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado != null)
            {
                c = u;
                Program.usuario = resultado;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
                alphaBlendTextBox1.Clear();
                alphaBlendTextBox2.Clear();
            }
        }
        #endregion

        private void FormLogin_Load(object sender, EventArgs e)
        {
            UsuarioAutenticado =! Cancelar;
            c =! u;
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "0000")
            {               
                c = u;
                this.Close();
            }
        }

        #region Hora y Fecha
        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }
        #endregion
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        #region Eventos

        private void alphaBlendTextBox1_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "USUARIO")
            {
                alphaBlendTextBox1.Text = "";
                
            }
        }

        private void alphaBlendTextBox1_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "")
            {
                alphaBlendTextBox1.Text = "USUARIO";
                
            }
        }

        private void alphaBlendTextBox2_Enter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "CONTRASEÑA")
            {
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void alphaBlendTextBox2_Leave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "")
            {
                alphaBlendTextBox2.Text = "CONTRASEÑA";
                alphaBlendTextBox2.UseSystemPasswordChar = false;
            }
        }


        #endregion
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void alphaBlendTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                string usuario;
                string contrasena;

                usuario = alphaBlendTextBox1.Text;
                contrasena = alphaBlendTextBox2.Text;

                var resultado = _seguridad.Autorizar(usuario, contrasena);

                if (resultado != null)
                {
                    c = u;
                    Program.usuario = resultado;
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }

        private void alphaBlendTextBox2_MouseEnter(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "CONTRASEÑA")
            {
                alphaBlendTextBox2.Text = "";
                alphaBlendTextBox2.UseSystemPasswordChar = true;
            }
        }

        private void alphaBlendTextBox2_MouseLeave(object sender, EventArgs e)
        {
            if (alphaBlendTextBox2.Text == "")
            {
                alphaBlendTextBox2.Text = "CONTRASEÑA";
                alphaBlendTextBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
