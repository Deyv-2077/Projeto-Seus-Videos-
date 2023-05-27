using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Video_Windows_Forms
{
    public partial class Form_Vid4 : Form
    {
        public Form_Vid4()
        {
            InitializeComponent();
        }

        private void Form_Vid4_Load(object sender, EventArgs e)
        {
            webBrowser4_4.ScriptErrorsSuppressed = true;


            //Atribuindo o link do Google Drive para a variável videoUrl.
            string videoUrl4 = "https://drive.google.com/file/d/1X5XYNPzu_1mOxbBXnSmHo6tvXCs99O4M/preview";

            //Criando o código HTML para que o vídeo seja executado dentro do form.
            string html = $@"
        <!DOCTYPE html>
        <html>
        <body>
            <video width='640' height='360' controls>
                <source src='{videoUrl4}' type='video/mp4'>
            </video>
        </body>
        </html>
    ";
            //Indicando para o webBrowser a variável que contém o link a ser acessado.
            webBrowser4_4.Navigate(videoUrl4);



        }
    }
}
