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
    public partial class FormAmpulheta : Form
    {

        private Timer timer;
        public FormAmpulheta()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 7500;
            timer.Tick += Timer_Tick;
        }

        public FormAmpulheta(string time)
        {

            InitializeComponent();
            timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += Timer_Tick;

        }

        private void FormAmpulheta_Load(object sender, EventArgs e)
        {

            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e) 
        {
        
        
            timer.Stop();
            Close();
        
        }
    }
}
