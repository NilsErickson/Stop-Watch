using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop_Watch
{
    public partial class Form1 : Form
    {
        int timerCs, timerS, timerMin;
        bool isActive;

        private void startButton_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            resetClock();
            isActive = false;
        }

        private void resetClock()
        {
            timerCs = 0;
            timerS = 0;
            timerMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timerCs++;

                if (timerCs >= 100)
                {
                    timerS++;
                    timerCs = 0;

                    if (timerS >= 60)
                    {
                        timerMin++;
                        timerS = 0;
                    }
                }
            }
            drawClock();
        }

        private void drawClock()
        {
            CsLabel.Text = String.Format("0,00", timerCs);
            secLabel.Text = String.Format("0,00", timerS);
            minLabel.Text = String.Format("0,00", timerMin);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isActive = false;
        }
    }
}
