namespace Projeto_Video_Windows_Forms
{
    partial class Form_Vids2
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
            this.webBrowser5 = new System.Windows.Forms.WebBrowser();
            this.webBrowser6 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxVideoAdd = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser5
            // 
            this.webBrowser5.Location = new System.Drawing.Point(127, 161);
            this.webBrowser5.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser5.Name = "webBrowser5";
            this.webBrowser5.Size = new System.Drawing.Size(278, 213);
            this.webBrowser5.TabIndex = 16;
            this.webBrowser5.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser5_DocumentCompleted);
            // 
            // webBrowser6
            // 
            this.webBrowser6.Location = new System.Drawing.Point(469, 161);
            this.webBrowser6.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser6.Name = "webBrowser6";
            this.webBrowser6.Size = new System.Drawing.Size(278, 213);
            this.webBrowser6.TabIndex = 17;
            this.webBrowser6.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser6_DocumentCompleted_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(149, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Viagem ao Japão - PT 4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(530, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adicionar Vídeo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxVideoAdd
            // 
            this.pictureBoxVideoAdd.Image = global::Projeto_Video_Windows_Forms.Properties.Resources.video_plus_icon_136058;
            this.pictureBoxVideoAdd.Location = new System.Drawing.Point(469, 161);
            this.pictureBoxVideoAdd.Name = "pictureBoxVideoAdd";
            this.pictureBoxVideoAdd.Size = new System.Drawing.Size(278, 213);
            this.pictureBoxVideoAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVideoAdd.TabIndex = 23;
            this.pictureBoxVideoAdd.TabStop = false;
            this.pictureBoxVideoAdd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Projeto_Video_Windows_Forms.Properties.Resources.Seus_Vídeos22;
            this.pictureBox5.Location = new System.Drawing.Point(127, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(620, 69);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // Form_Vids2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(863, 578);
            this.Controls.Add(this.pictureBoxVideoAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.webBrowser6);
            this.Controls.Add(this.webBrowser5);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form_Vids2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Vids2";
            this.Load += new System.EventHandler(this.Form_Vids2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideoAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.WebBrowser webBrowser5;
        private System.Windows.Forms.WebBrowser webBrowser6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBoxVideoAdd;
    }
}