using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Video_Windows_Forms
{
    public partial class Form_Login : Form
    {
        private Form_Login loginForm;

        public Form_Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form_Login formlog = new Form_Login();

            if (textBox_User.Text == "teste" && textBox_Password.Text == "123")
            {
                Form_Vids form = new Form_Vids();
                FormAmpulheta formAmpulheta = new FormAmpulheta();

                Hide();
                form.Show();
                formAmpulheta.ShowDialog();
                    
                    


            }
            else
            {
                // Instancia a fonte desejada
                Font font = new Font("Arial", 12, FontStyle.Bold);

                // Exibe uma mensagem com a fonte desejada
                MessageBox.Show("Senha inválida", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                font.Dispose();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
