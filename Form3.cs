using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picDragoon.Left -= 1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timrDragon.Start();
            tmrMadara.Start();
            timeMadara.Start();
        }

        private void tmrMadara_Tick(object sender, EventArgs e)
        {
            picMadara.Left -= 1;
        }

        private void timeMadara_Tick(object sender, EventArgs e)
        {
            pcMadara.Left-=1;
        }
    }
}
