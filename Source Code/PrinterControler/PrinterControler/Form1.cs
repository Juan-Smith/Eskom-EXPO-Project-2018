using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PrinterControler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new Renderer();
        }

        // Public Variables
        public String PrinterCOMPort = "COM11";
        //

        // Private Variables
        private PrinterInterface Printer = new PrinterInterface();
        private Graphics PictureDraw;
        private Graphics PictureCreate;
        private bool MouseisDown = false;
        private Bitmap Print;
        private Int16 FillTrimmer = 200;
        //


        private void portraitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (portraitToolStripMenuItem.Checked == false)
            {
                var answer = MessageBox.Show("If You change the page orientation the image might look different! Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    portraitToolStripMenuItem.Checked = true;
                    landsacpeToolStripMenuItem.Checked = false;
                    panel2.Left = 320;
                    panel2.Top = 25;
                    panel2.Width = 420;
                    panel2.Height = 600;

                    Print = new Bitmap(126, 181);
                    PictureCreate = Graphics.FromImage(Print);
                    PictureDraw = panel2.CreateGraphics();

                    PictureCreate.Clear(Color.FromArgb(255, 255, 255, 255));
                }
            }
        }

        private void landsacpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (landsacpeToolStripMenuItem.Checked == false)
            {
                var answer = MessageBox.Show("If You change the page orientation the image might look different! Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    landsacpeToolStripMenuItem.Checked = true;
                    portraitToolStripMenuItem.Checked = false;
                    panel2.Left = 200;
                    panel2.Top = 100;
                    panel2.Width = 600;
                    panel2.Height = 420;

                    Print = new Bitmap(181, 126);
                    PictureCreate = Graphics.FromImage(Print);
                    PictureDraw = panel2.CreateGraphics();

                    PictureCreate.Clear(Color.FromArgb(255, 255, 255, 255));
                }
            }
        }

       
        private void changeCOMPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
         PrinterCOMPort =  Interaction.InputBox("Enter COM Port", "Settings", "", this.Width / 2, this.Height / 2);
         lblCOM.Text = "COM Port: " + PrinterCOMPort;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrinetStatus.Text = "Printer Status: Offline";
            lblPrintingStatus.Text = " Printing Status: Not Printing";
            lblCOM.Text = "COM Port: " + PrinterCOMPort;
            //  lblPos.Text = "Printer Position: " + "(" + PosX.ToString() + ";" + PosY.ToString() + ")";
            Print = new Bitmap(126, 181);
            PictureCreate = Graphics.FromImage(Print);
            PictureDraw = panel2.CreateGraphics();

            PictureCreate.Clear(Color.FromArgb(255, 255, 255, 255));
            // PictureCreate.FillRectangle(new SolidBrush(Color.Red), 20, 20, 1, 1);
            // PictureCreate.FillRectangle(new SolidBrush(Color.DodgerBlue), 20, 21, 1, 1);
            DrawPrint();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Printer.ConnectToPrinter(PrinterCOMPort, Console, lblPos);

            if (Printer.Connected == true)
            {
                lblPrinetStatus.Text = "Printer Status: Online";
                BtnConnect.ForeColor = SystemColors.ControlDarkDark;
                BtnDisconnect.ForeColor = SystemColors.ButtonFace;
                BtnScan.ForeColor = SystemColors.ButtonFace;
            }
            else
                lblPrinetStatus.Text = "Printer Status: Offline";

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            Printer.DisconnectFromPrinter();
            if (Printer.Connected == false)
            {
                lblPrinetStatus.Text = "Printer Status: Offline";
                BtnConnect.ForeColor = SystemColors.ButtonFace;
                BtnDisconnect.ForeColor = SystemColors.ControlDarkDark;
                BtnScan.ForeColor = SystemColors.ControlDarkDark;
            }
            else
                lblPrinetStatus.Text = "Printer Status: Online";

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MouseisDown = true;

            if (MouseisDown == true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    PictureCreate.FillRectangle(new SolidBrush(Color.Black), (panel2.PointToClient(MousePosition).X) / 3, (panel2.PointToClient(MousePosition).Y) / 3, 1, 1);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    PictureCreate.FillRectangle(new SolidBrush(Color.White), (panel2.PointToClient(MousePosition).X) / 3, (panel2.PointToClient(MousePosition).Y) / 3, 1, 1);
                }
                // PictureDraw.DrawImage(Print, new Rectangle(0, 0, 420, 600));
            }
            DrawPrint();
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            MouseisDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseisDown == true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    PictureCreate.FillRectangle(new SolidBrush(Color.Black), (panel2.PointToClient(MousePosition).X) / 3, (panel2.PointToClient(MousePosition).Y) / 3, 1, 1);
                }
                else if(e.Button == MouseButtons.Right)
                {
                    PictureCreate.FillRectangle(new SolidBrush(Color.White), (panel2.PointToClient(MousePosition).X) / 3, (panel2.PointToClient(MousePosition).Y) / 3, 1, 1);
                }
                // PictureDraw.DrawImage(Print, new Rectangle(0, 0, 420, 600));
            }
            DrawPrint();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Task.Delay(8000);
            Printer.YMotorClock();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Task.Delay(8000);
            Printer.YMotorCounterClock();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Printer.XMotorClock();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Printer.XMotorCounterClock();
        }

        private void BtnScan_Click(object sender, EventArgs e)
        {
            if (BtnScan.ForeColor == SystemColors.ButtonFace)
            {
                BtnPrint.ForeColor = SystemColors.ButtonFace;

                if (Print.Width == 126)
                    Printer.ScanForDots(Print, Console, 'P');
                else if (Print.Width == 181)
                    Printer.ScanForDots(Print, Console, 'L');
                 
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (BtnPrint.ForeColor == SystemColors.ButtonFace)
            {
                BtnCnclPrint.ForeColor = SystemColors.ButtonFace;
                Printer.DoPrinting = true;
                lblPrintingStatus.Text = "Printing Status: Printing"; ;
            }

        }

        private void BtnCnclPrint_Click(object sender, EventArgs e)
        {
            if (BtnCnclPrint.ForeColor == SystemColors.ButtonFace)
            {
                BtnPrint.ForeColor = SystemColors.ButtonFace;
                Printer.DoPrinting = false;

                lblPrintingStatus.Text = "Printing Status: Printing";
            }
        }

        private class Renderer : ToolStripProfessionalRenderer
        {
            public Renderer() : base(new PickedColors())
            {

            }
        }

        private class PickedColors : ProfessionalColorTable
        {

            public override Color MenuItemSelected
            {
                get { return Color.DodgerBlue; }
            }


            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DodgerBlue; }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.DodgerBlue; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(255, 50, 50, 50); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(255, 50, 50, 50); }
            }

            public override Color ButtonSelectedBorder
            {
                get { return Color.FromArgb(255, 50, 50, 50); }
            }

        }

        private void BtnDisconnect_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void DrawPrint()
        {
            Bitmap temp = new Bitmap(Print.Width * 3, Print.Height * 3);
            Graphics graphics = Graphics.FromImage(temp);
            for(int y = 0; y < Print.Height; y++)
            {
                for(int x = 0; x < Print.Width; x++)
                {
                    graphics.FillRectangle(new SolidBrush(Print.GetPixel(x, y)), x * 3, y * 3, 3, 3);
                }
            }

            PictureDraw.DrawImage(temp, 0, 0);
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {
            Console.SelectionStart = Console.Text.Length;
            Console.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Printer.RaisePen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Printer.LowerPen();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void importToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Bitmap temp = new Bitmap(openFileDialog1.OpenFile());

            if((temp.Width == 126 && temp.Height == 181) || (temp.Width == 181 && temp.Height == 126))
            {
                ConvertToProper(temp);        
            }
            else
            {
                MessageBox.Show("Image was not the correct size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

         private void ConvertToProper(Bitmap map)
        {
            for(int y = 0; y < map.Height; y++)
            {
                for(int x = 0; x < map.Width; x++)
                {
                   if(map.GetPixel(x, y).R == map.GetPixel(x, y).G && map.GetPixel(x, y).G == map.GetPixel(x, y).B && map.GetPixel(x, y) != Color.White && map.GetPixel(x, y).B > FillTrimmer)
                    {
                        PictureCreate.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 255, 255)), x, y, 1, 1);
                    }  
                   else
                    {
                        PictureCreate.FillRectangle(new SolidBrush(Color.Black), x, y, 1, 1);
                    }
                }
            }
        }

        private void resetPrinterPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(Printer.Connected == true)
            {
                PositionReset Reset = new PositionReset();
                Reset.Create(Printer);
                Reset.Show();
            }
            else
            {
                MessageBox.Show("Please connect to printer before reseting position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changeFillSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FillTrimmer = Convert.ToInt16(Interaction.InputBox("Change fill trimmer (0 - 255)", "Settings", FillTrimmer.ToString() , this.Width / 2, this.Height / 2));
            }
            catch
            {
                MessageBox.Show("Invalid integer enterd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
