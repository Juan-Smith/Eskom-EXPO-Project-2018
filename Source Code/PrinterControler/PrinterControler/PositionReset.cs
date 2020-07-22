using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterControler
{
    public partial class PositionReset : Form
    {

        private PrinterInterface InterFace;

        public PositionReset()
        {
            InitializeComponent();
        }

        public void Create(PrinterInterface interfaces)
        {
            InterFace = interfaces;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            InterFace.YMotorCounterClock();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterFace.YMotorClock();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterFace.XMotorClock();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InterFace.XMotorCounterClock();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InterFace.LowerPen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InterFace.RaisePen();
        }
    }
}
