namespace Projeto_Video_Windows_Forms
{
    partial class Form_Vid2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser2_2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser2_2
            // 
            this.webBrowser2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2_2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2_2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2_2.Name = "webBrowser2_2";
            this.webBrowser2_2.Size = new System.Drawing.Size(800, 450);
            this.webBrowser2_2.TabIndex = 0;
            this.webBrowser2_2.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser2_DocumentCompleted);
            // 
            // Form_Vid2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser2_2);
            this.Name = "Form_Vid2";
            this.Text = "Form_Vid2";
            this.Load += new System.EventHandler(this.Form_Vid2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser2_2;
    }
}