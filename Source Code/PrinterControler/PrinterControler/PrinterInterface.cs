using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonoBrick.NXT;

namespace PrinterControler  
{
    public class PrinterInterface 
    {
        //PUBLIC
        public bool Connected = false;
        public bool DoPrinting = false;

        //PRIVATE
        private Brick<Sensor, Sensor, Sensor, Sensor> Printer;
        private Timer timer = new Timer();
        private Point[] Dots;
        private Int16 DotIndex = -1;
        private Point CurrentPos = new Point(0, 0);
        private Int16 NumberOFDots = 0;
        private bool PenRaised = true;
        private RichTextBox console;
        private Label PosPrinterlbl;

     public void ConnectToPrinter(String PrinterCOM, RichTextBox consoles, Label Positionlbl)
        {
            Printer = new Brick<Sensor, Sensor, Sensor, Sensor>(PrinterCOM);
            
            try
            {
                console = consoles;
                Printer.Connection.Open();
                Connected = true;
                Printer.Vehicle.LeftPort = MotorPort.OutA;
                Printer.Vehicle.RightPort = MotorPort.OutB;
                PosPrinterlbl = Positionlbl;
                
                timer.Interval = 775;
                timer.Enabled = true;
                timer.Tick += Timer_Tick;

                UpdatePos();
            }
            catch
            {
                MessageBox.Show("Could Not Connect to Printer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisconnectFromPrinter()
        {

            try
            {
                Printer.Connection.Close();
                Connected = false;
            }
            catch
            {
                MessageBox.Show("Could Not Disconnect from Printer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

          public void LowerPen()
          {
              Printer.MotorA.On(10, 5, true);
              WaitForMotor(Printer.MotorA);
              Printer.MotorA.Brake();
              Printer.MotorA.Off();
          }

        

          public void RaisePen()
          {
               Printer.MotorA.On(-10, 5, true);
              WaitForMotor(Printer.MotorA);
              Printer.MotorA.Brake();
              Printer.MotorA.Off();
              return;
          } 

          public void YMotorClock()
          {
            
                Printer.MotorB.On(5, 10, true);
                WaitForMotor(Printer.MotorB);
                Printer.MotorB.Brake();
                Printer.MotorB.Off();

            UpdatePos();
          }

          public void XMotorClock()
          {

                  Printer.MotorC.On(5, 10, true);
                  WaitForMotor(Printer.MotorC);
                  Printer.MotorC.Brake();
                  Printer.MotorC.Off();

            UpdatePos();
          } 

          public void YMotorCounterClock()
          {
            
                Printer.MotorB.On(-5, 10, true);
                WaitForMotor(Printer.MotorB);
                Printer.MotorB.Brake();
                Printer.MotorB.Off();

            UpdatePos();
            
        }

          public void XMotorCounterClock()
          {
              Printer.MotorC.On(-5, 10, true);
              WaitForMotor(Printer.MotorC);
              Printer.MotorC.Brake();
              Printer.MotorC.Off();

            UpdatePos();
          } 

          private void WaitForMotor(Motor motor)
          {
              Task.Delay(480);

              while (motor.IsRunning())
              {
                  Task.Delay(50);
              }
          } 

           

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(DoPrinting == true)
            {
              if(NumberOFDots > -1)
                {
                    Printer.MotorB.Brake(); // Stop All Motors
                    Printer.MotorB.Off();

                    Printer.MotorC.Brake();
                    Printer.MotorC.Off(); 

                    if (PenRaised == false && (Dist(CurrentPos.X, CurrentPos.Y, Dots[DotIndex - NumberOFDots].X, Dots[DotIndex - NumberOFDots].Y).X > 1 || Dist(CurrentPos.X, CurrentPos.Y, Dots[DotIndex - NumberOFDots].X, Dots[DotIndex - NumberOFDots].Y).Y > 1))
                    {
                        RaisePen();
                        PenRaised = true;
                    }

                    if(CurrentPos.X == Dots[DotIndex - NumberOFDots].X && CurrentPos.Y == Dots[DotIndex - NumberOFDots].Y)
                    {
                        if (PenRaised == true)
                        {
                            LowerPen();
                            PenRaised = false;
                        }
                        NumberOFDots--;
                    }
                    else
                    {
                        if(CurrentPos.X < Dots[DotIndex - NumberOFDots].X) // X-Motor to Right
                        {
                            CurrentPos.X++;
                            Printer.MotorC.On(-5, 10, true);
                        }
                         if (CurrentPos.X > Dots[DotIndex - NumberOFDots].X) // X-Motor to Left
                        {
                            CurrentPos.X--;
                            Printer.MotorC.On(5, 10, true);
                        }

                        if(CurrentPos.Y < Dots[DotIndex - NumberOFDots].Y)// Y-motor Down
                        {
                            CurrentPos.Y++;
                            Printer.MotorB.On(-5, 10, true);                        
                        }
                        if(CurrentPos.Y > Dots[DotIndex - NumberOFDots].Y)// Y-motor Up
                        {
                            CurrentPos.Y--;
                            Printer.MotorB.On(5, 10, true);
                        }
                    }
                }
              else
                {
                    Printer.MotorB.Brake(); // Stop All Motors
                    Printer.MotorB.Off();

                    Printer.MotorC.Brake();
                    Printer.MotorC.Off();

                    if (PenRaised == false)
                    {
                        RaisePen();
                        PenRaised = true;
                    }
                     // Raise Pen Before returning home

                    if (CurrentPos.X == 0 && CurrentPos.Y == 0)
                    {
                        timer.Enabled = false;
                    }

                    
                     if (CurrentPos.X > 0) // X-Motor to Left
                    {
                        CurrentPos.X--;
                        Printer.MotorC.On(5, 10, true);
                    }

                   
                     if (CurrentPos.Y > 0)// Y-motor Up
                    {
                        CurrentPos.Y--;
                        Printer.MotorB.On(5, 10, true);
                    }


                }

                UpdatePos();
            }
   
        }

        public void ScanForDots(Bitmap image, RichTextBox console, char Orientation)
        {
            Dots = new Point[image.Width * image.Height];

            if(Orientation == 'P')
            {
                console.Text += "SCAN START\n";
                int linner = 0;
                for (int y = 0; y < image.Height; y++)
                {
                    linner++;
                    if (linner % 2 == 0)
                    {
                        for (int x = image.Width - 1; x >= 0; x--)
                        {
                            if (image.GetPixel(x, y) != System.Drawing.Color.FromArgb(255, 255, 255, 255))
                            {
                                DotIndex++;
                                Dots[DotIndex] = new Point(x, y);
                            }
                        }
                    }
                    else
                    {
                        for (int x = 0; x < image.Width; x++)
                        {
                            if (image.GetPixel(x, y) != System.Drawing.Color.FromArgb(255, 255, 255, 255))
                            {
                                DotIndex++;
                                Dots[DotIndex] = new Point(x, y);
                            }
                        }
                    }
                }
                NumberOFDots = DotIndex;
                console.Text += "SCAN END\n";
            }
            else if(Orientation == 'L')
            {
                console.Text += "SCAN START\n";
                int linner = 0;
                for (int y = 0; y < image.Height; y++)
                {
                    linner++;

                    if (linner % 2 == 0)
                    {
                        for (int x = image.Width - 1; x >= 0; x--)
                        {
                            if (image.GetPixel(x, y) != System.Drawing.Color.FromArgb(255, 255, 255, 255))
                            {
                                DotIndex++;
                                Dots[DotIndex] = new Point(y, x);
                            }
                        }
                    }
                    else
                    {
                        for (int x = 0; x < image.Width; x++)
                        {
                            if (image.GetPixel(x, y) != System.Drawing.Color.FromArgb(255, 255, 255, 255))
                            {
                                DotIndex++;
                                Dots[DotIndex] = new Point(y, x);
                            }
                        }
                    }
                }
                NumberOFDots = DotIndex;
                console.Text += "SCAN END " + NumberOFDots.ToString() + "\n";
            }

          
        }

        private Point Dist(int CurX, int CurY, int DestX, int DestY)
        {
            return new Point(Math.Abs(CurX - DestX) , Math.Abs(CurY - DestY));
        }

        private int Distance(int CurX, int CurY, int DestX, int DestY)
        {
            return Math.Abs(CurX - DestX) +  Math.Abs(CurY - DestY);
        }

        private void UpdatePos()
        {
            PosPrinterlbl.Text = "Pen Position: " + CurrentPos.ToString();
        }

    }
}
