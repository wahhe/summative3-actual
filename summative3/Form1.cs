using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace summative3
{
    public partial class summative : Form
    {
        public summative()
        {
            InitializeComponent();
        }

        private void exploreButton_Click(object sender, EventArgs e)
        {
            titleLabel.Hide();
            exploreButton.Hide();

            Thread.Sleep(10);

            Graphics XXX = CreateGraphics();
            Graphics g = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush purpleBrush = new SolidBrush(Color.Purple);
            Pen whitePen = new Pen(Color.White);
            //initialize
            int x = 10;
            int y = 10;

            //test


            while (y <= this.Width)
            {

                //act
                //g.Clear(Color.White);
                g.FillRectangle(whiteBrush, 0, 0, x, y);

                Thread.Sleep(5);

                //change
                x++;
                y = x + 2;
            }

            outputLabel.Text = "Welcome to the XXX world. ";
            outputLabel.Refresh();
            Thread.Sleep(2000);
            outputLabel.Hide();
            g.Clear(Color.Black);
            g.DrawLine(whitePen, 0, 300, x, 300);
            //this.width start from the right, x=0 start from the left
            //when x < 0, X++ the line grow from left to right
            for (x = 0; x < Width ; x++)
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(blackBrush, x, 300, 10, 10);
                g.DrawLine(whitePen, x, 300, 0, 300);

                Thread.Sleep(5);
            }


            for (y = 290; y > 75; y--)
            {
                //act
                g.Clear(Color.Black);
                g.FillRectangle(whiteBrush, 200, y, 10, 10);                            
                g.DrawLine(whitePen, 0, 300, x, 300);

                Thread.Sleep(10);
            }
            
            for (int pixels = 1; pixels < 256; pixels++)
            {
                //act
                g.Clear(Color.Black);

                whiteBrush.Color = Color.FromArgb(255 - pixels, 0 , 255 - pixels);

                g.FillRectangle(whiteBrush, 200 - pixels / 2, 75 - pixels / 2, 10 + pixels, 10 + pixels);
                g.DrawLine(whitePen, 0, 300, x, 300);

                Thread.Sleep(5);
            }

            g.Clear(Color.Black );

            for (x = 0; x < Width ; x++)
            {
                //act
                g.Clear(Color.Black);
                whiteBrush.Color = Color.White;
                //g.FillRectangle(whiteBrush, x, 200, 10, 10);
                g.DrawLine(whitePen, 0, 320, x, y);
                g.FillRectangle(blackBrush, 220, 180, 30, 30);
                g.DrawLine(whitePen, 220, 198, 220, 300);
                g.DrawLine(whitePen, 250, 178, 250, 300);
                g.DrawLine(whitePen, 220, 300, 250, 300);
                g.FillRectangle(purpleBrush, 225, 275, 20, 20);
                Thread.Sleep(10);
            }


            //for (x = 10; x < Width - 20; x = x+1)
            //{
                
            //    g.FillRectangle(redBrush, x, y, 10, 10);
              
            //    Thread.Sleep(5);
            //}

            for (y = 0; y < 275; y++)
            {
                //act
                
                g.FillRectangle(redBrush, 225, y, 10, 10);
              

                Thread.Sleep(10);
            }

            for (int pixels = 0; pixels < 256; pixels++)
            {
                //act
       

                whiteBrush.Color = Color.FromArgb(255 - pixels, 0, 255 - pixels);

                g.FillRectangle(whiteBrush, 225 - pixels / 2, 300 - pixels / 2, 30 + pixels, 30 + pixels);

               
                Thread.Sleep(5);
            }

            outputLabel.Text = "Mission explored";


        }
    }
}

            
            
        

      

    

