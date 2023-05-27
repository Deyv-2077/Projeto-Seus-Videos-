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
    public partial class FormAddVideo : Form
    {
        private Form_Vids2 formVids2;
        public string OriginalVideoUrl;

        public FormAddVideo(Form_Vids2 formVids2)
        {
            InitializeComponent();
            this.formVids2 = formVids2;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Vids2 form_Vids2 = new Form_Vids2();
            this.OriginalVideoUrl = textBox_Drive.Text;
            formVids2.UpdateVideoUrl(OriginalVideoUrl);
            textBox_Copie.Text = "";
            form_Vids2.UpdateVideoUrl(OriginalVideoUrl);
            Close();

        }
    }
}
