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
    public partial class Form_Vid2 : Form
    {
        public Form_Vid2()
        {
            InitializeComponent();
        }

        private void Form_Vid2_Load(object sender, EventArgs e)
        {

            //Atribuindo o link do Google Drive para a variável videoUrl.
            string videoUrl2 = "https://drive.google.com/file/d/1WwOvCeHCDrC-NPhPQXIhHigS4vRnBJg_/preview";


            webBrowser2_2.ScriptErrorsSuppressed = true;


            //Criando o código HTML para que o vídeo seja executado dentro do form.
            string html = $@"
        <!DOCTYPE html>
        <html>
        <body>
            <video width='640' height='360' controls>
                <source src='{videoUrl2}' type='video/mp4'>
            </video>
        </body>
        </html>
    ";
            //Indicando para o webBrowser a variável que contém o link a ser acessado.
            webBrowser2_2.Navigate(videoUrl2);
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        

    }
}





