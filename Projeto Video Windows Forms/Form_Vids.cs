using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Video_Windows_Forms
{
    public partial class Form_Vids : Form
    {
        private bool videoClicked, video2Clicked, video3Clicked, video4Clicked, video5Clicked, video6Cliked = false; // Variável para controlar se o vídeo foi clicado
        private bool webBrowserLoaded = false; // Variável para controlar se o WebBrowser foi carregado
        private string originalVideoUrl; // URL original do vídeo
        Form_Login loginForm = new Form_Login();



        public Form_Vids()
        {

            InitializeComponent();
        }

        //public Form_Vids()
        //{
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            void webBrowserUm()
            {

                string videoUrl = "https://drive.google.com/file/d/1UKjhSHmsXzb4svd_QKWx7acDtSGHcMB0/preview";

                webBrowser1.ScriptErrorsSuppressed = true;


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
                webBrowser1.Navigate(videoUrl);

                webBrowser1.DocumentCompleted += (sender1, eventArgs) =>
                {
                    webBrowserLoaded = true;

                    // Adicione o manipulador de eventos apenas uma vez
                    if (!videoClicked)
                    {
                        webBrowser1.Document.Click += WebBrowserDocument_Click;
                    }
                };

            }

            void webBrowserDois()
            {
                string videoUrl2 = "https://drive.google.com/file/d/1WwOvCeHCDrC-NPhPQXIhHigS4vRnBJg_/preview";

                webBrowser2.ScriptErrorsSuppressed = true;


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
                webBrowser2.Navigate(videoUrl2);

                webBrowser2.DocumentCompleted += (sender2, eventArgs) =>
                {
                    webBrowserLoaded = true;

                    // Adicione o manipulador de eventos apenas uma vez
                    if (!video2Clicked)
                    {
                        webBrowser2.Document.Click += WebBrowser2Document_Click;
                    }
                };

            }

            void webBrowserTres()
            {
                string videoUrl3 = "https://drive.google.com/file/d/1X0j3CJNS96Y4BI4A35AdcLWE_FkhLUBI/preview";

                webBrowser3.ScriptErrorsSuppressed = true;

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
                webBrowser3.Navigate(videoUrl3);

                webBrowser3.DocumentCompleted += (sender2, eventArgs) =>
                {
                    webBrowserLoaded = true;

                    // Adicione o manipulador de eventos apenas uma vez
                    if (!video3Clicked)
                    {
                        webBrowser3.Document.Click += WebBrowser3Document_Click;
                    }
                };

            }

            void webBrowserQuatro()
            {
                string videoUrl4 = "https://drive.google.com/file/d/1X5XYNPzu_1mOxbBXnSmHo6tvXCs99O4M/preview";

                webBrowser4.ScriptErrorsSuppressed = true;


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
                webBrowser4.Navigate(videoUrl4);

                webBrowser4.DocumentCompleted += (sender2, eventArgs) =>
                {
                    webBrowserLoaded = true;

                    // Adicione o manipulador de eventos apenas uma vez
                    if (!video4Clicked)
                    {
                        webBrowser4.Document.Click += WebBrowser4Document_Click;
                    }
                };

            }
            
            webBrowserUm();
            webBrowserDois();
            webBrowserTres();
            webBrowserQuatro();

        }
        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }


        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
       {

            webBrowserLoaded = true;

            // Verifica se o manipulador de eventos já foi adicionado
            if (!videoClicked)
            {
                // Adicione o manipulador de eventos para o clique no vídeo no WebBrowser
                webBrowser1.Document.Click += WebBrowserDocument_Click;

                // Define a variável videoClicked como true para que o manipulador de eventos seja adicionado apenas uma vez
                videoClicked = true;
            }

            //Adicione um manipulador de eventos para o clique no vídeo no WebBrowser
            //webBrowser1.Document.Click += WebBrowserDocument_Click;
        }

        private void webBrowser2_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Adicione um manipulador de eventos para o clique no vídeo no WebBrowser
            //webBrowser2.Document.Click += WebBrowserDocument_Click;
            webBrowserLoaded = true;


            if (!video2Clicked)
            {
                // Adicione o manipulador de eventos para o clique no vídeo no WebBrowser
                webBrowser2.Document.Click += WebBrowser2Document_Click;

                // Define a variável videoClicked como true para que o manipulador de eventos seja adicionado apenas uma vez
                video2Clicked = true;
            }

        }
        // private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        // {

        //}
        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Adicione um manipulador de eventos para o clique no vídeo no WebBrowser
            //webBrowser2.Document.Click += WebBrowserDocument_Click;
            webBrowserLoaded = true;


            if (!video3Clicked)
            {
                // Adicione o manipulador de eventos para o clique no vídeo no WebBrowser
                webBrowser3.Document.Click += WebBrowser3Document_Click;

                // Define a variável videoClicked como true para que o manipulador de eventos seja adicionado apenas uma vez
                video3Clicked = true;
            }
        }

      /*  private void webBrowser4_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
      */

        // private void webBrowser3_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{


        //        }

        private void WebBrowserDocument_Click(object sender, HtmlElementEventArgs e)
        {
            label1.Visible = true;

            if (webBrowserLoaded)
            {

                videoClicked = true; // Define a variável videoClicked como true

                // Torna a "armadilha invisível" (neste caso, um Label) invisível

                webBrowser1.Url = new Uri("about:blank");

                originalVideoUrl = webBrowser1.Url.ToString();

                Form_Video1 form = new Form_Video1();
                form.Show();

                webBrowser1.Url = new Uri(originalVideoUrl);

            }
           
        }

        private void WebBrowser2Document_Click(object sender, HtmlElementEventArgs e)
        {
             label2.Visible = true;

            if (webBrowserLoaded)
            {

                video2Clicked = true; // Define a variável videoClicked como true

                // Torna a "armadilha invisível" (neste caso, um Label) invisível

                webBrowser2.Url = new Uri("about:blank");

                originalVideoUrl = webBrowser2.Url.ToString();

                Form_Vid2 form2 = new Form_Vid2();
                form2.Show();
                
                webBrowser2.Url = new Uri(originalVideoUrl);

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
            loginForm.Close();
            Form_Vids2 formVids2 = new Form_Vids2();
            formVids2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Vids2 formVids2 = new Form_Vids2();
            formVids2.Show();
            FormAmpulheta formAmpulheta = new FormAmpulheta("Tempo reduzido");
            formAmpulheta.ShowDialog();
        }

        private void webBrowser4_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //Adicione um manipulador de eventos para o clique no vídeo no WebBrowser
            //webBrowser2.Document.Click += WebBrowserDocument_Click;
            webBrowserLoaded = true;


            if (!video4Clicked)
            {
                // Adicione o manipulador de eventos para o clique no vídeo no WebBrowser
                webBrowser4.Document.Click += WebBrowser4Document_Click;

                // Define a variável videoClicked como true para que o manipulador de eventos seja adicionado apenas uma vez
                video4Clicked = true;
            }

        }


        private void WebBrowser3Document_Click(object sender, HtmlElementEventArgs e)
        {
            labelPT2.Visible = true;

            if (webBrowserLoaded)
            {

                video3Clicked = true; // Define a variável videoClicked como true

                // Torna a "armadilha invisível" (neste caso, um Label) invisível

                webBrowser3.Url = new Uri("about:blank");

                originalVideoUrl = webBrowser3.Url.ToString();

                Form_Vid3 form3 = new Form_Vid3();
                form3.Show();

                webBrowser3.Url = new Uri(originalVideoUrl);

            }

        }

        private void WebBrowser4Document_Click(object sender, HtmlElementEventArgs e)
        {
            labelPT2.Visible = true;

            if (webBrowserLoaded)
            {

                video4Clicked = true; // Define a variável videoClicked como true

                // Torna a "armadilha invisível" (neste caso, um Label) invisível

                webBrowser4.Url = new Uri("about:blank");

                originalVideoUrl = webBrowser4.Url.ToString();

                Form_Vid4 form4 = new Form_Vid4();
                form4.Show();

                webBrowser4.Url = new Uri(originalVideoUrl);

            }

        }

        // Evento Paint do Label para desenhar a "armadilha invisível" quando a propriedade Visible for true
        /* private void Label1_Paint(object sender1, PaintEventArgs e)
         {
             if (!videoClicked)
             {
                 // Desenha a "armadilha invisível" somente se o vídeo não tiver sido clicado
                 e.Graphics.Clear(BackColor);
             }
         }*/

        private void Label2_Paint(object sender2, PaintEventArgs e)
        {
            if (!video2Clicked)
            {
                // Desenha a "armadilha invisível" somente se o vídeo não tiver sido clicado
                e.Graphics.Clear(BackColor);
            }
        }

        private void labelPT2_Paint(object sender, PaintEventArgs e)
        {
            if (!videoClicked)
            {
                // Desenha a "armadilha invisível" somente se o vídeo não tiver sido clicado
                e.Graphics.Clear(BackColor);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
