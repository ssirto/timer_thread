using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es2thread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int time) && time > 0 &&
                int.TryParse(textBox2.Text, out int interval) && interval > 0)
            {
                Timer.SetInterval(interval);
                Timer.Start(time);
            }
            else
            {
                MessageBox.Show("Inserisci valori validi per tempo e intervallo!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
