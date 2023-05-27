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
    public partial class Form_Vid3 : Form
    {
        public Form_Vid3()
        {
            InitializeComponent();
        }

        private void Form_Vid3_Load(object sender, EventArgs e)
        {
            //Atribuindo o link do Google Drive para a variável videoUrl.
            string videoUrl3 = "https://drive.google.com/file/d/1X0j3CJNS96Y4BI4A35AdcLWE_FkhLUBI/preview";

            webBrowser3_3.ScriptErrorsSuppressed = true;

            //Criando o código HTML para que o vídeo seja executado dentro do form.
            string html = $@"
        <!DOCTYPE html>
        <html>
        <body>
            <video width='640' height='360' controls>
                <source src='{videoUrl3}' type='video/mp4'>
            </video>
        </body>
        </html>
    ";
            //Indicando para o webBrowser a variável que contém o link a ser acessado.
            webBrowser3_3.Navigate(videoUrl3);


        }
        private void webBrowser3_3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        
    }
}
