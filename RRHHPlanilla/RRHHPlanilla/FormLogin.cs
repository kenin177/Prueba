﻿using System;
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
    public partial class FormLogin : Form

    {
        public bool UsuarioAutenticado { get; set; }
        public bool Cancelar { get; set; }

        public bool u { get; set; }
        public bool c { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }
            
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

            if (usuario == "admin1" && contrasena == "12345" || 
                usuario == "supervisor1" && contrasena == "1234")
            {
               
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            UsuarioAutenticado =! Cancelar;
            c =! u;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.F1)
            {
                MessageBox.Show("funciono");
            }
        }

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (alphaBlendTextBox1.Text == "0000")
            {
                c = u;
                this.Close();
            }
        }
    }
}
