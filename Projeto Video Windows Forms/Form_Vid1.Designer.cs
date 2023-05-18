
namespace Projeto_Video_Windows_Forms
{
    partial class Form_Video1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1_1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1_1
            // 
            this.webBrowser1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1_1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1_1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1_1.Name = "webBrowser1_1";
            this.webBrowser1_1.Size = new System.Drawing.Size(992, 479);
            this.webBrowser1_1.TabIndex = 0;
            // 
            // Form_Video1
            // 
            this.ClientSize = new System.Drawing.Size(992, 479);
            this.Controls.Add(this.webBrowser1_1);
            this.Name = "Form_Video1";
            this.Load += new System.EventHandler(this.Form_Video1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser1_1;
    }
}

