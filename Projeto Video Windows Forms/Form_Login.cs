using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private bool isPasswordClicked = false;

        public Form_Login()
        {
            
            InitializeComponent();
            textBox_Password.UseSystemPasswordChar = true;
           // textBox_Password.Text = "123";
           /* if (textBox_Password.Text == "123")
            {
                textBox_Password.Enter += TextBox_Password_Enter;
            }
           */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

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
                // Exibe uma mensagem 
                MessageBox.Show("   Senha inválida \n \"Usuário = teste\" \n \"Senha = 123\"", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


            }

        }

        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            
        }

        private void TextBox_Password_GotFocus(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Form_Login formlog = new Form_Login();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_User_Enter(object sender, EventArgs e)
        {

            if (textBox_User.Text == "teste")
            {
                textBox_User.Text = "";
                textBox_User.ForeColor = Color.Black;

            }
        }



        private void textBox_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_Enter(object sender, EventArgs e)
        {

           

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void textBox_Password_Click(object sender, EventArgs e)
        {

            if (!isPasswordClicked)
            {
                textBox_Password.Text = "";
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.UseSystemPasswordChar = false;


            }

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {

            label3.Hide();
            pictureBox2.Visible = true;
            pictureBox2.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {

        }
        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            
        }

     
    }
}
