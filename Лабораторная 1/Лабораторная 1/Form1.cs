using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_1
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }
        private int z = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Size == pictureBox1.MaximumSize)
                z = 1;
            if (pictureBox1.Size == pictureBox1.MinimumSize)
                z = 0;
            if (z == 0)
                pictureBox1.Size = pictureBox1.Size + new Size(1, 1);
            if (z == 1)
                pictureBox1.Size = pictureBox1.Size - new Size(1, 1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
