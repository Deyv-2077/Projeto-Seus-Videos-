namespace Projeto_Video_Windows_Forms
{
    partial class FormAddVideo
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
            this.textBox_Drive = new System.Windows.Forms.TextBox();
            this.labelDrive = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Copie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Drive
            // 
            this.textBox_Drive.Location = new System.Drawing.Point(307, 88);
            this.textBox_Drive.Multiline = true;
            this.textBox_Drive.Name = "textBox_Drive";
            this.textBox_Drive.Size = new System.Drawing.Size(389, 25);
            this.textBox_Drive.TabIndex = 0;
            this.textBox_Drive.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDrive
            // 
            this.labelDrive.AutoSize = true;
            this.labelDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9F, System.Drawing.FontStyle.Bold);
            this.labelDrive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDrive.Location = new System.Drawing.Point(74, 88);
            this.labelDrive.Name = "labelDrive";
            this.labelDrive.Size = new System.Drawing.Size(219, 25);
            this.labelDrive.TabIndex = 3;
            this.labelDrive.Text = "Link do Google Drive ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Copie
            // 
            this.textBox_Copie.Location = new System.Drawing.Point(307, 119);
            this.textBox_Copie.Multiline = true;
            this.textBox_Copie.Name = "textBox_Copie";
            this.textBox_Copie.Size = new System.Drawing.Size(389, 25);
            this.textBox_Copie.TabIndex = 5;
            this.textBox_Copie.Text = "https://drive.google.com/file/d/1X0j3CJNS96Y4BI4A35AdcLWE_FkhLUBI/preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.9F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(74, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copie o link de teste";
            // 
            // FormAddVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Copie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDrive);
            this.Controls.Add(this.textBox_Drive);
            this.Name = "FormAddVideo";
            this.Text = "FormAddVideo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Drive;
        private System.Windows.Forms.Label labelDrive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Copie;
        private System.Windows.Forms.Label label1;
    }
}