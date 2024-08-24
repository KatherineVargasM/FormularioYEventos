using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using _05FormulariosyEventos.views.Dashboard;

namespace _05FormulariosyEventos
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "" || txt_Contrasenia.Text == "")
            {
                lbl_Mensajes.Text = "Llene las cajas de texto con la informacion requerida";
                lbl_Mensajes.Visible = true;
                ControlTamanioFormulario();
                return;
            }

            if (ValidarEmail(txt_Usuario.Text))
            {
                if (txt_Usuario.Text == "katherinevargas@gmail.com" && txt_Contrasenia.Text == "12345")
                {
                    Dashboard dahsboard = new Dashboard();
                    dahsboard.Show();
                    lbl_Mensajes.Text = "";
                    lbl_Mensajes.Visible = false;
                    this.Hide();
                }
                else
                {
                    lbl_Mensajes.Text = "El usuario o la contraseña son incorrectos";
                    lbl_Mensajes.Visible = true;
                    ControlTamanioFormulario();
                }
            }
            else
            {
                lbl_Mensajes.Text = "El correo electronico no posee el formato correcto";
                lbl_Mensajes.Visible = true;
                ControlTamanioFormulario();
            }
        }

        public bool ValidarEmail(string email)
        {
            string validacion = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, validacion);
        }

        public void ControlTamanioFormulario()
        {
            decimal alto = frm_login.ActiveForm.Height;
            decimal ancho = frm_login.ActiveForm.Width;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Contrasenia.Text = "";
            txt_Usuario.Text = "";
        }
    }
}
