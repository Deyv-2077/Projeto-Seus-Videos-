using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto_Video_Windows_Forms
{
    public partial class Form_Vids2 : Form
    {

        private bool videoClicked, video2Clicked, video3Clicked, video4Clicked, video5Clicked, video6Cliked = false; // Variável para controlar se o vídeo foi clicado
        private bool webBrowserLoaded = false; // Variável para controlar se o WebBrowser foi carregado

       

        private string originalVideoUrl; // URL original do vídeo

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form_Vids formVids = new Form_Vids();
            formVids.Show();
            FormAmpulheta formAmpulheta = new FormAmpulheta("Tempo reduzido");
            formAmpulheta.ShowDialog();
        }

        Form_Login loginForm = new Form_Login();
        public Form_Vids2()
        {
            InitializeComponent();
        }

        private void Form_Vids2_Load(object sender, EventArgs e)
        {
            void webBrowserCinco()
            {
                string videoUrl = "https://drive.google.com/file/d/1WvYgolUPReMftvllBe8d_pCYIK0yshEE/preview";

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
                webBrowser5.Navigate(videoUrl);

                webBrowser5.DocumentCompleted += (sender1, eventArgs) =>
                {
                    webBrowserLoaded = true;

                    // Adicione o manipulador de eventos apenas uma vez
                    if (!video5Clicked)
                    {
                        webBrowser5.Document.Click += WebBrowser5Document_Click;
                    }
                };

            }

            webBrowserCinco();
        }

        private void WebBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowserLoaded = true;

            // Verifica se o manipulador de eventos já foi adicionado
            if (!video5Clicked)
            {
                // Adicione o manipulador de eventos para o clique no vídeo no WebBrowser
                webBrowser5.Document.Click += WebBrowser5Document_Click;

                // Define a variável videoClicked como true para que o manipulador de eventos seja adicionado apenas uma vez
                video5Clicked = true;
            }

            //Adicione um manipulador de eventos para o clique no vídeo no WebBrowser
            //webBrowser1.Document.Click += WebBrowserDocument_Click;


        }


        private void WebBrowser5Document_Click(object sender, HtmlElementEventArgs e)
        {

            if (webBrowserLoaded)
            {

                video5Clicked = true; // Define a variável videoClicked como true

                // Torna a "armadilha invisível" (neste caso, um Label) invisível

                webBrowser5.Url = new Uri("about:blank");

                originalVideoUrl = webBrowser5.Url.ToString();

                Form_Vid5 form5 = new Form_Vid5();
                form5.Show();

                webBrowser5.Url = new Uri(originalVideoUrl);

            }

        }
    }

}
