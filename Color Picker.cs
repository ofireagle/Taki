using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taki
{
    public partial class Color_Picker : Form
    {
        public Color_Picker()
        {
            InitializeComponent();
        }

        public Color Chosen = Color.None;

        private void button1_Click(object sender, EventArgs e)
        {
            Chosen = Color.Red;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chosen = Color.Blue;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Chosen = Color.Yellow;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chosen = Color.Green;
            this.Close();
        }
    }
}
