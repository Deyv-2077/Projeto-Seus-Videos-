namespace Projeto_Video_Windows_Forms
{
    partial class Form_Vid4
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
            this.webBrowser4_4 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser4_4
            // 
            this.webBrowser4_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4_4.Location = new System.Drawing.Point(0, 0);
            this.webBrowser4_4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4_4.Name = "webBrowser4_4";
            this.webBrowser4_4.Size = new System.Drawing.Size(800, 450);
            this.webBrowser4_4.TabIndex = 0;
            // 
            // Form_Vid4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser4_4);
            this.Name = "Form_Vid4";
            this.Text = "Form_Vid4";
            this.Load += new System.EventHandler(this.Form_Vid4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser4_4;
    }
}