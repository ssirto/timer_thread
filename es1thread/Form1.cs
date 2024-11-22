using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace es1thread
{
    public partial class Form1 : Form
    {
        private Timer timer;

        public Form1(Timer timer)
        {
            InitializeComponent();
            
            timer = new Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out tempoRimanente) && tempoRimanente> 0)
            {
                label1.Text = $"Tempo rimanente: {tempoRimanente} secondi";
                timer.Start();
            }
            else
            {
                MessageBox.Show("Inserisci un numero valido!");
            }
        }

        private void btnPause_Click_1(object sender, EventArgs e)
        {
            timer.Pause();
        }

        private void btnResume_Click_1(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e, int tempoRimanente)
        {
            if (tempoRimanente > 0)
            {
                tempoRimanente--;
                label1.Text = $"Tempo rimanente: {tempoRimanente} secondi";
            }
            else
            {
                timer.Pause();
                MessageBox.Show("Tempo scaduto!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Tempo rimanente: {tempoRimanente} secondi";
        }
    }
}