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
    public partial class Form_Vid5 : Form
    {
        public Form_Vid5()
        {
            InitializeComponent();
        }

        private void Form_Vid5_Load(object sender, EventArgs e)
        {

            //Atribuindo o link do Google Drive para a variável videoUrl.
            string videoUrl5 = "https://drive.google.com/file/d/1XEB56ipsUEddhzf3v78Z-L6DjZ0ldzYN/preview";

            //Criando o código HTML para que o vídeo seja executado dentro do form.
            string html = $@"
        <!DOCTYPE html>
        <html>
        <body>
            <video width='640' height='360' controls>
                <source src='{videoUrl5}' type='video/mp4'>
            </video>
        </body>
        </html>
    ";
            //Indicando para o webBrowser a variável que contém o link a ser acessado.
            webBrowser5_5.Navigate(videoUrl5);

        


        }
    }
}
