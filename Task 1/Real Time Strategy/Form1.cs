using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Time_Strategy
{
    public partial class Form1 : Form
    {
        Game_Engine Engine;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Indicates how many units to add and sets the number of tiles
            Engine = new Game_Engine(10, UnitInfo, MapDisp);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void lblRound_Click(object sender, EventArgs e)
        {

        }
    }
}
