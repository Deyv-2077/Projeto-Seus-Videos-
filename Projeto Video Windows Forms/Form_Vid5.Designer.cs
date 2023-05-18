namespace Projeto_Video_Windows_Forms
{
    partial class Form_Vid5
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
            this.webBrowser5_5 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser5_5
            // 
            this.webBrowser5_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser5_5.Location = new System.Drawing.Point(0, 0);
            this.webBrowser5_5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5_5.Name = "webBrowser5_5";
            this.webBrowser5_5.Size = new System.Drawing.Size(800, 450);
            this.webBrowser5_5.TabIndex = 0;
            // 
            // Form_Vid5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser5_5);
            this.Name = "Form_Vid5";
            this.Text = "Form_Vid5";
            this.Load += new System.EventHandler(this.Form_Vid5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser5_5;
    }
}