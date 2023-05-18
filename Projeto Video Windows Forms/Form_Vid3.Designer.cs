namespace Projeto_Video_Windows_Forms
{
    partial class Form_Vid3
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
            this.webBrowser3_3 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser3_3
            // 
            this.webBrowser3_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3_3.Location = new System.Drawing.Point(0, 0);
            this.webBrowser3_3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3_3.Name = "webBrowser3_3";
            this.webBrowser3_3.Size = new System.Drawing.Size(800, 450);
            this.webBrowser3_3.TabIndex = 0;
            this.webBrowser3_3.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser3_3_DocumentCompleted);
            // 
            // Form_Vid3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser3_3);
            this.Name = "Form_Vid3";
            this.Text = "Form_Vid3";
            this.Load += new System.EventHandler(this.Form_Vid3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser3_3;
    }
}