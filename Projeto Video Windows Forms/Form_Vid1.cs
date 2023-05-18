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
    public partial class Form_Video1 : Form
    {

        public Form_Video1()
        {
            InitializeComponent();
        }

        private void Form_Video1_Load(object sender, EventArgs e)
        {
            //Atribuindo o link do Google Drive para a variável videoUrl.
            string videoUrl = "https://drive.google.com/file/d/1UKjhSHmsXzb4svd_QKWx7acDtSGHcMB0/preview";

            //Criando o código HTML para que o vídeo seja executado dentro do form.
            string html = $@"
        <!DOCTYPE html>
        <html>
        <body>
            <video width='640' height='360' controls>
                <source src='{videoUrl}' type='video/mp4'>
            </video>
        </body>
        </html>
    ";
            //Indicando para o webBrowser a variável que contém o link a ser acessado.
            webBrowser1_1.Navigate(videoUrl);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

      
    }
}