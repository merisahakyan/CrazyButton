using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int bx = r.Next(10, ClientSize.Width-button1.Width);
            int by = r.Next(10, ClientSize.Height-button1.Height);
            button1.Location = new Point(bx, by);


        }
    }
}
