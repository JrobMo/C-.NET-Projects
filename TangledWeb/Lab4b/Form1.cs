
/*Purpose: Form that checks whether users inputed HTML code has balanced opening and closing tags
 * Date of submission :11/27/22
 * I, Jacob Robbins, 000371194 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * For the user: Please use this application to parse and check if html tags are balanced on your webpage
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace Lab4b
{
    /// <summary>
    /// Partial Class Form 1 : Form
    /// </summary>
    public partial class Form1 : Form
    {

        public string folderPath = string.Empty;
        string fileContent = string.Empty;
        public List<string> filterList = new List<string>();
        public List<string> filterListTwo = new List<string>();
        public Stack<string> dataStack = new Stack<string>();
        public int counterOne;
        public int counterTwo;
        static string[] TagsToRemove = new string[] { "<br>", "<hr>", "<img>" };

        /// <summary>
        /// Public Form1 ; Empty Constructor for the Form Class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Form1_Load Constructor
        /// Constructor providing default Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// loadFileToolStripMenuItem_Click
        /// handles click event for file load / user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openFileDialog class used to open Directory on users computer 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter to ensure user only selects html files
            openFileDialog1.Filter = "Html Files (*.html)|*.html";

            //if File load is ok
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = openFileDialog1.FileName;
                fileContent = openFileDialog1.ToString();
                selectLabel.Text = folderPath;
            }
            var fileStream = openFileDialog1.OpenFile();

            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
            }

            if (folderPath == string.Empty)
            {
                dataList.Items.Clear();
                processToolStripMenuItem.Enabled = false;
            }
            else
            {
                dataList.Items.Clear();
                processToolStripMenuItem.Enabled = true;
            }
        }
        /// <summary>
        /// exitToolStripMenu Onclick handler
        /// handles onclick event for exit click events 
        /// closes the application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// checkTagsToolStripMenuItem_Click
        /// Handles Click events for the checkTags menu option
        /// when clicked executes the filtering of the HTML files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allTags = @"(</?[^5>]+>)";
            var matchesOne = Regex.Matches(fileContent, allTags);

            if (matchesOne.Count > 0)
            {
                foreach (Match m in matchesOne)
                //add values to list
                filterList.Add(m.Value);
                //filter the Void Tags 
                filterList.RemoveAll(x => TagsToRemove.Contains(x));
                //count obj in list
                counterOne = filterList.Count;
                // add result to dataList in form 
                Console.WriteLine(counterOne);
            }
            
            else
            {
                Console.WriteLine("No HTML");
            }
            foreach (object obj in filterList)
            {
                dataList.Items.Add("Found Tag : " + obj);
            }
            if(counterOne % 2 == 0)
            {
                checkLabel.Text = "HTML tags are balanced!";
            }
            else
            {
                checkLabel.Text = "HTML tags are not balanced!";
            }
        }

    }
    }





