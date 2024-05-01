using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//I, Jacob Robbins, 000371194 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
// Date : 04.26.23

///Program purpose - using both SQL and Linq statements that the user can interchange between
///Display the contents of the Doctor Who Actors, Companions and Episodes
///from data obtained from the given database

namespace Time_is_my_Companion
{
    /// <summary>
    /// class Form1 : Form - Auto Generated code for the basic format from WinForms Apps 
    /// Implements variables used throughout the applications' methods
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        ///String - connectionString  - Used to connect to the chosen database 
        /// </summary>
        private string connectionString = @"Data Source=BALOGNEFACE\SQLEXPRESS;Initial Catalog=COMP10204_Lab5;Integrated Security=True";

        //SQL Lists
        /// <summary>
        /// List - doctorList - Contains all of the Doctors from the Doctors Table
        /// </summary>
        private static readonly List<DOCTOR> s_doctorList = new List<DOCTOR>();
        /// <summary>
        /// List - companionList - Contains all of the Companions from the Companions Table
        /// </summary>
        private static readonly List<COMPANION> s_companionList = new List<COMPANION>();
        /// <summary>
        /// List - episodeList - Contains all of the Episodes from the Episodes Table
        /// </summary> 
        private static readonly List<EPISODE> s_episodeList = new List<EPISODE>();
        /// <summary>
        /// List - imageList - Contains all of the Images converted from the Doctors Table
        /// </summary>
        private static readonly List<Image> s_imageList = new List<Image>();

        /// <summary>
        /// Bool - sqlBool - Boolean to assist in determining whether SQL statements will execute
        /// </summary>
        private static bool s_isSql;
        /// <summary>
        /// Bool - linqBool - linqBool to assist in detering whether LINQ statements will execute
        /// </summary>
        private static bool s_isLinq;

        //Load Doctors Table
        /// <summary>
        /// Method - LoadDocs - Loads the Doctors table into the corresponding List
        /// </summary>
        public void LoadDocs()
        {
            //Repeated throughout - SQL connection standard/ open connection / read - while loop / close connection
            using (SqlConnection sourceConnection = new SqlConnection(connectionString))
            {
                sourceConnection.Open();
                SqlDataReader myReader = null;

                SqlCommand myCommand = new SqlCommand("SELECT * FROM " + "dbo.DOCTOR;", sourceConnection);

                myReader = myCommand.ExecuteReader();
                //Read reader adding values to attributes in the s_doctorList
                while (myReader.Read())
                {
                    s_doctorList.Add(new DOCTOR
                    {
                        DOCTORID = (int)myReader["DOCTORID"],
                        ACTOR = myReader["ACTOR"].ToString(),
                        SERIES = (int)myReader["SERIES"],
                        AGE = (int)myReader["AGE"],
                        DEBUT = myReader["DEBUT"].ToString(),
                        PICTURE = (byte[])myReader["Picture"],
                    });
                    byte[] photo = (byte[])myReader["Picture"];
                    MemoryStream stream = new MemoryStream(photo);
                    Image image = Image.FromStream(stream);
                    s_imageList.Add(image);
                }
                //close connection
                sourceConnection.Close();
            }
            var docQuery = 
            from DOCTOR doc in s_doctorList
            select doc.DOCTORID;

            foreach (var doc in docQuery)
            {
                doctorComboBox.Items.Add(doc);
            }
        }

        /// <summary>
        /// Method - LoadDocs - Loads the Doctors table into the corresponding List
        /// </summary>
        public void LoadEps()
        {

            using (SqlConnection sourceConnection =
                 new SqlConnection(connectionString))
            {
                sourceConnection.Open();

                SqlDataReader myReader = null;

                SqlCommand myCommand = new SqlCommand("SELECT * FROM " + "dbo.EPISODE;", sourceConnection);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    s_episodeList.Add(new EPISODE
                    {
                        STORYID = myReader["STORYID"].ToString(),
                        SEASON = (int)myReader["SEASON"],
                        SEASONYEAR = (int)myReader["SEASONYEAR"],
                        TITLE = myReader["TITLE"].ToString(),
                    });
                }
                sourceConnection.Close();
            }
        }

        /// <summary>
        ///  Method - LoadDocs - Loads the Doctors table into the corresponding List
        /// </summary>
        public void LoadComps()
        {
            using (SqlConnection sourceConnection =
                 new SqlConnection(connectionString))
            {
                sourceConnection.Open();

                SqlDataReader myReader = null;

                SqlCommand myCommand = new SqlCommand( "SELECT * FROM " + "dbo.COMPANION;", sourceConnection);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    s_companionList.Add(new COMPANION
                    {
                        NAME = myReader["NAME"].ToString(),
                        ACTOR = myReader["ACTOR"].ToString(),
                        DOCTORID = (int)myReader["DOCTORID"],
                        STORYID = myReader["STORYID"].ToString(),
                    });
                }
                sourceConnection.Close();
            }
        }

        /// <summary>
        ///  Constructor - Form1 - Auto-Generated WinForms Constructor for the Form1 object
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            LoadDocs();
            LoadComps();
            LoadEps();
        }

        /// <summary>
        /// Method - doctorComboBox_SelectedIndexChanged - determines which conditional of the switch 
        /// statement to be used dependant on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear pre-existing values
            companionListBox.Items.Clear();
            firstEpText.Text = string.Empty;
            int userInput = doctorComboBox.SelectedIndex;
            int count = userInput += 1;
            int indexer = userInput -= 1;

            if (s_isSql)
            {
                //switch conditional to handle user input / doctor selection
                for (int i = 0; i < s_doctorList.Count; i++)
                {
                    playText.Text = s_doctorList[indexer].ACTOR;
                    yearText.Text = s_doctorList[indexer].DEBUT;
                    seriesText.Text = s_doctorList[indexer].SERIES.ToString();
                    ageText.Text = s_doctorList[indexer].AGE.ToString();
                    docPhotoBox.Image = s_imageList[indexer];

    var compQuery = 
                    from comp in s_companionList
                    join episode in s_episodeList on comp.STORYID equals episode.STORYID
                    where comp.DOCTORID == count
                    select new { comp.NAME, comp.ACTOR, episode.TITLE };

                    foreach (var comp in compQuery)
                    {
                        companionListBox.Items.Add($"Companion Name : {comp.NAME} Actor : {comp.ACTOR}");
                        companionListBox.Items.Add($" Episodes: {comp.TITLE}");
                        companionListBox.Items.Add("\n");
                    }

                    var epQuery = from ep in s_episodeList
                                  where ep.STORYID == s_doctorList[indexer].DEBUT.ToString()
                                  select ep;

                    foreach (var ep in epQuery)
                    {
                        firstEpText.Text = $"{ep.TITLE}";
                    }
                }
            }
            else if (s_isLinq)
            {
                //Linq Statements 
                for (int i = 0; i < s_doctorList.Count; i++)
                {

                    IEnumerable<DOCTOR> resultDoc =
                        from doctor in s_doctorList
                        where doctor.DOCTORID == count
                        select doctor;

                    //Fill Primary Doctor Information
                    foreach (var doctor in resultDoc)
                    {
                        playText.Text = doctor.ACTOR;
                        yearText.Text = doctor.DEBUT.ToString();
                        seriesText.Text = doctor.SERIES.ToString();
                        ageText.Text = doctor.AGE.ToString();
                        docPhotoBox.Image = s_imageList[indexer];
                    }

                    //Fill Companion and Episode information
    var resultComp =
                    s_companionList.Join(s_episodeList,
                    companion => companion.STORYID,
                    eps => eps.STORYID,
                    (companion, eps) => new { companion.NAME, companion.ACTOR, companion.DOCTORID, eps.TITLE, })
                    .Where(companion => companion.DOCTORID == count);

                    foreach (var resItem in resultComp)
                    {
                        companionListBox.Items.Add($"Companion Name : {resItem.NAME} Actor : {resItem.ACTOR} ");
                        companionListBox.Items.Add($" Episodes: {resItem.TITLE} ");
                        companionListBox.Items.Add("\n");
                    }

                    //Fill Episode Text 
                    IEnumerable<EPISODE> resultEp =
                            from episodes in s_episodeList
                            where episodes.STORYID == s_doctorList[indexer].DEBUT.ToString()
                            select episodes;

                    foreach (var episode in resultEp)
                    {
                        firstEpText.Text = $"{episode.TITLE}";
                    }
                }
            }
        }

        /// <summary>
        /// Method - SQLButton_CheckChanged - Assists in determining whether SQL statements will execute
        /// or LINQ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SQLButton_CheckedChanged(object sender, EventArgs e)
        {
            s_isSql = true;
            s_isLinq = false;
        }

        /// <summary>
        /// Method - SQLButton_CheckChanged - Assists in determining whether LINQ statements will execute
        /// or SQL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LINQButton_CheckedChanged(object sender, EventArgs e)
        {
            s_isLinq = true;
            s_isSql = false;
        }
    }
}
