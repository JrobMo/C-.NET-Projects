using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I, Jacob Robbins, 000371194 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
// Date : 04.26.23 

///Program purpose - Using a Timer Class object as well as a TrackBar Class Object,
///Fill the contents of a bucket that is drawn on the Form.
///Using the ColourDialogue Class object, allow the user to change the colour of the liquid 
///There is also be an exit button so that the user may gracefully exit the application

namespace DropInABucket
{
    /// <summary>
    /// Class Form1 - the auto-generated class from the WinForms app
    /// Contains variables used throughout the applicaton
    /// </summary>
    public partial class Form1 : Form
    {
        //Variable - bluePen - Pen that is blue to assist in drawing the water 
        public Pen bluePen = new Pen(Color.Blue, 3);
       
        //Variable - blackPen - Pen that is black to assist in drawing the water 
        public Pen blackPen = new Pen(Color.Black, 3);
       
        // Variable - controlPen - Pen that is same colour as background to hide rectangles 
        // to assist in drawing the water so that it does not have to be redrawn / invalidated 
        public Pen controlPen = new Pen(Color.White, 3);
        
        // Variable - blueBrush - Brush that is blue to assist in drawing the water 
        public SolidBrush blueBrush = new SolidBrush(Color.Blue);
        
        // Variable - colourBool - Pen that is blue to assist in drawing the water 
        public bool colourBool = false;
      
        // Variable - Boolean - used as control to assist in calling the FillRectangle Methods
        // on the Graphics object to fill the bucket with water
        // boolBuckets 1-10 follow suit
        public static bool boolBucket = true;
        public static bool boolBucket1;
        public static bool boolBucket2;
        public static bool boolBucket3;
        public static bool boolBucket4;
        public static bool boolBucket5;
        public static bool boolBucket6;
        public static bool boolBucket7;
        public static bool boolBucket8;
        public static bool boolBucket9;
        public static bool boolBucket10;

        //Dynamically draw Rectangles and fill for water line
        //Rectangles
        public static Rectangle r1 = new Rectangle(3, 263, 95, 25);
        public static Rectangle r2 = new Rectangle(3, 250, 95, 25);
        public static Rectangle r3 = new Rectangle(3, 230, 95, 25);
        public static Rectangle r4 = new Rectangle(3, 210, 95, 25);
        public static Rectangle r5 = new Rectangle(3, 190, 95, 25);
        public static Rectangle r6 = new Rectangle(3, 170, 95, 25);
        public static Rectangle r7 = new Rectangle(3, 150, 95, 25);
        public static Rectangle r8 = new Rectangle(3, 130, 95, 25);
        public static Rectangle r9 = new Rectangle(3, 110, 95, 25);
        public static Rectangle r10 = new Rectangle(3, 90, 95, 25);
        public static Rectangle r11 = new Rectangle(3, 70, 95, 25);
        public static Rectangle r12 = new Rectangle(3, 50, 95, 25);

        //List - myRecs - Contains all the Rectangles to be drawn to hold the
        //water when FillRectangle is called 
        public static List<Rectangle> myRecs = new List<Rectangle>() { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12 };


        /// <summary>
        /// Constructor - Form1 - the auto-generated WinForm constructor to display the GUI of the application
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            spigotPanel.Image = spigotPanel.InitialImage;
            spigotPanel.SizeMode = PictureBoxSizeMode.Zoom;

            //fillTrack variables 
            fillTrack.TickFrequency = 1;
            fillTrack.LargeChange = 1;
            fillTrack.SmallChange = 1;
            fillTrack.Maximum = 10;
            fillTrack.Minimum = 0;
            fillTrack.Orientation = Orientation.Horizontal;
            fillTrack.BackColor = Color.AliceBlue;

            //Set timer interval
            theTimer.Interval = 10;
        }

        /// <summary>
        /// Method - ProcessCmdKey - Prevents the arrow keys from being used to control the 
        /// trackBar/FillTrack object
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Left || keyData == Keys.Right)
            {
                WndProc(ref msg);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        /// <summary>
        /// Method - FillTrack_Scroll EventHandler - Sets the speed at which the water to fill the
        /// bucket is draw using the trackBar Object/Class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FillTrack_Scroll(object sender, EventArgs e)
        {
            switch (fillTrack.Value)
            {
                case 0:
                    theTimer.Interval += 10;
                    boolBucket = true;
                    break;
                case 1:
                    theTimer.Interval += 10;
                    boolBucket1 = true;
                    bucketPanel.Invalidate();
                    break;
                case 2:
                    theTimer.Interval += 10;
                    boolBucket2 = true;
                    bucketPanel.Invalidate();
                    break;
                case 3:
                    theTimer.Interval += 10;
                    boolBucket3 = true;
                    bucketPanel.Invalidate();
                    break;
                case 4:
                    theTimer.Interval += 10;
                    boolBucket4 = true;
                    bucketPanel.Invalidate();
                    break;
                case 5:
                    theTimer.Interval += 10;
                    boolBucket5 = true;
                    bucketPanel.Invalidate();
                    break;
                case 6:
                    theTimer.Interval += 10;
                    boolBucket6 = true;
                    bucketPanel.Invalidate();
                    break;
                case 7:
                    theTimer.Interval += 10;
                    boolBucket7 = true;
                    bucketPanel.Invalidate();
                    break;
                case 8:
                    theTimer.Interval += 10;
                    boolBucket8 = true;
                    bucketPanel.Invalidate();
                    break;
                case 9:
                    theTimer.Interval = 10;
                    boolBucket9 = true;
                    bucketPanel.Invalidate();
                    break;
                case 10:
                    theTimer.Interval += 10;
                    boolBucket10 = true;
                    bucketPanel.Invalidate();
                    fillTrack.Value = 0;
                    break;
                default:
                    theTimer.Interval = 10;
                    fillTrack.Value = 0;
                    boolBucket = false;
                    bucketPanel.Invalidate();
                    break;
            }
        }

        /// <summary>
        /// Method - ColourButton_Click EventHandler - to help determine whether the ColourDialogue has been
        /// Selected by the user, if the Colour has been selected the colourBool Conditional is set
        /// to true so the water to fill the bucket can be drawn in the user selected colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColourButton_Click(object sender, EventArgs e)
        {
            if (changeColourDialogue.ShowDialog() == DialogResult.OK)
            {
                bluePen.Color = changeColourDialogue.Color;
                blueBrush.Color = changeColourDialogue.Color;
                colourBool = true;
                bucketPanel.Invalidate();
            }
        }


        /// <summary>
        /// Method - BucketPanel_Paint Method - Instantiates the points required to draw the bucket 
        /// object as well as drawing the rectangles for the water fill and spigot water 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ex"></param>
        private void BucketPanel_Paint(object sender, PaintEventArgs ex)
        {
            //Bucket Co-ords 
            Point p1 = new Point(100, 50);
            Point p2 = new Point(100, 290);
            Point p3 = new Point(1, 290);
            Point p4 = new Point(1, 50);
            Point p5 = new Point(0, 290);
            Point p6 = new Point(102, 290);
            Point p7 = new Point(20, 0);
            Point p8 = new Point(20, 100);

            //Draw Bucket Lines
            ex.Graphics.DrawLine(blackPen, p1, p2);
            ex.Graphics.DrawLine(blackPen, p3, p4);
            ex.Graphics.DrawLine(blackPen, p5, p6);

            //Draw Rectangles 
            ex.Graphics.DrawRectangle(controlPen, myRecs[0]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[1]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[2]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[3]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[4]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[5]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[6]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[7]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[8]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[9]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[10]);
            ex.Graphics.DrawRectangle(controlPen, myRecs[11]);

            //Fill Rectangle Conditionals
            //boolBuckets booleans controlled in FillTrack_Scroll()
            //if bools are true execute Graphics.FillRectangle
            if (boolBucket == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[0]);
            }
            if (boolBucket1 == true)
            {
                ex.Graphics.DrawLine(bluePen, p7, p8);
                ex.Graphics.FillRectangle(blueBrush, myRecs[1]);
            }
            if (boolBucket2 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[2]);
            }
            if (boolBucket3 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[3]);
            }
            if (boolBucket4 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[4]);
            }
            if (boolBucket5 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[5]);
            }
            if (boolBucket6 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[6]);
            }
            if (boolBucket7 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[7]);
            }
            if (boolBucket8 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[8]);
                ex.Graphics.FillRectangle(blueBrush, myRecs[9]);
            }
            if (boolBucket9 == true)
            {
                ex.Graphics.FillRectangle(blueBrush, myRecs[10]);
                ex.Graphics.FillRectangle(blueBrush, myRecs[11]);
            }
            if (theTimer.Interval == 20 && fillTrack.Value == 0)
            {
                boolBucket1 = false;
                boolBucket2 = false;
                boolBucket3 = false;
                boolBucket4 = false;
                boolBucket5 = false;
                boolBucket6 = false;
                boolBucket7 = false;
                boolBucket8 = false;
                boolBucket9 = false;
                bucketPanel.Invalidate();
            }
        }

        /// <summary>
        /// Method - ExitButton_Click EventHandler - Assists with exiting the application in a 
        /// graceful manner 0 as param as exit is intended
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //exit the application
            Environment.Exit(0);
        }
    }
}

