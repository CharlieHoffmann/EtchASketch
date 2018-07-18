using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtchASketch
{
    public partial class Form1 : Form
    {
        Bitmap DrawArea;
        float penLoc1 = 10;
        float penLoc2 = 10;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Red; // sets form color as red
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);//creates a bitmap the size of the picturebox
            pictureBox1.Image = DrawArea;
            pictureBox1.BackColor = Color.Gray; //sets picturebox color as gray
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen pen = new Pen(Brushes.Black);
            g.DrawLine(pen, 0, 0, 200, 200);
            
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
  
            //capture up arrow key
             if (keyData == Keys.Up)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);

                Pen mypen = new Pen(Color.Black);
                if(penLoc2 !=0)
                {
                    g.DrawLine(mypen, penLoc1, penLoc2, penLoc1, penLoc2 - 10);
                    penLoc2 = penLoc2 - 10;
                }
                pictureBox1.Image = DrawArea;

                g.Dispose();
               
                
               
            
            }
            //capture down arrow key
            else if (keyData == Keys.Down)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);

                Pen mypen = new Pen(Color.Black);

                if (penLoc2 != 320)
                {
                    g.DrawLine(mypen, penLoc1, penLoc2, penLoc1, penLoc2 + 10);
                    penLoc2 = penLoc2 + 10;
                }
                pictureBox1.Image = DrawArea;

                g.Dispose();

                
            }
            //capture left arrow key
            else if (keyData == Keys.Left)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);

                Pen mypen = new Pen(Color.Black);

                if (penLoc1 != 0)
                {
                    g.DrawLine(mypen, penLoc1, penLoc2, penLoc1 - 10, penLoc2);
                    penLoc1 = penLoc1 - 10;
                }
                pictureBox1.Image = DrawArea;

                g.Dispose();

                
            }
            //capture right arrow key
            else if (keyData == Keys.Right)
            {
                Graphics g;
                g = Graphics.FromImage(DrawArea);

                Pen mypen = new Pen(Color.Black);

                if (penLoc1 != 680)
                {
                    g.DrawLine(mypen, penLoc1, penLoc2, penLoc1 + 10, penLoc2);
                    penLoc1 = penLoc1 + 10;
                    
                }

                pictureBox1.Image = DrawArea;

                g.Dispose();

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            g.Clear(Color.Gray);

            pictureBox1.Image = DrawArea;
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
 