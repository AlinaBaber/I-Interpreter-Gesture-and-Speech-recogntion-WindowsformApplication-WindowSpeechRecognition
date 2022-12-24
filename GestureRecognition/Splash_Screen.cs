using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GestureRecognition
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            
            InitializeComponent();
          
        }
      
        private void Splash_Screen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            { timer1.Stop(); }
        }
    }
}
