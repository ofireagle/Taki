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
    public partial class Form1 : Form // name picker
    {
        private Mainform mf;
        
        public string chosenName = null;

        public Form1(Mainform mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chosenName = textBox1.Text;
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1_Click(null, null);
        }
    }
}
