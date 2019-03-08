/*
  Program -> Lab5b.cs
  Author ->  Jess Nguyen
  Date ->    December 3, 2018
  Statement Of Authorship -> I, Jess Nguyen, 000747411 certify that this material is my original work. No other person's work has been used without due acknowledgement.
  Purpose -> To read text file and display information about doctor who.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5b
{
    public partial class Form1 : Form
    {
        private string fileName; //text file path.

        /// <summary>
        /// The constructor for the form so that the application can automatically display components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        //list of doctors, episodes, and companions objects
        List<Doctor> doctorWhos = new List<Doctor>();
        List<Companion> assistants = new List<Companion>();
        List<Episode> adventures = new List<Episode>();

        /// <summary>
        /// Close this form
        /// </summary>
        /// <param name="sender">menu item exit</param>
        /// <param name="e">event of the exit menu item clicked</param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Open file of user's choice and read the text file.
        /// </summary>
        /// <param name="sender">menu item open</param>
        /// <param name="e">event of the open menu item clicked</param>
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            #region open file

            TextOpenFileDialog.Title = "Please Select HTML File";               //the title of the openfiledialog.
            TextOpenFileDialog.Filter = "Text|*.txt|All|*.*";
            if (TextOpenFileDialog.ShowDialog() == DialogResult.OK)             //if the file is able to open by pressing ok do the following. Otherwise it was canceled. 
            {
                fileName = TextOpenFileDialog.FileName;                         //Assign the file to fileName string.
                                                                                // Open the file for reading purposes
                Read(); //read text file.

                //order the doctorWhos by ordinal.
                doctorWhos = doctorWhos.OrderBy(x => x.ordinal).ToList();

                //get ordinal, add to the ordinal to the combobox.
                foreach (Doctor timeLord in doctorWhos)
                {
                    doctorComboBox.Items.Add(timeLord.ordinal);
                }
            }
            else
            {
                MessageBox.Show("You canceled this operation");                 //Cancelling open file. 
            }
            #endregion
        }

        /// <summary>
        /// Read the text file and split the information in the text file into objects o doctor, episode, and companion.
        /// </summary>
        private void Read()
        {
            StreamReader reader = new StreamReader(fileName);                   //Stream Text File.
            string line;                                                        // One line of data read from the file 

            //split the text file so that its readable
            while ((line = reader.ReadLine()) != null)
            {
                //put each data into an index
                string[] exploded = line.Split('|');

                //If the line starts with D, E, or C then create a Doctor, Episode, or Companion object.
                if (exploded[0].Trim() == "D")
                {
                    doctorWhos.Add(new Doctor(int.Parse(exploded[1].Trim()), exploded[2].Trim(), int.Parse(exploded[3].Trim()), int.Parse(exploded[4].Trim()), exploded[5].Trim()));
                }
                else if (exploded[0].Trim() == "E")
                {
                    adventures.Add(new Episode(exploded[1].Trim(), int.Parse(exploded[2].Trim()), int.Parse(exploded[3].Trim()), exploded[4].Trim()));
                }
                else if (exploded[0].Trim() == "C")
                {
                    assistants.Add(new Companion(exploded[1].Trim(), exploded[2].Trim(), int.Parse(exploded[3].Trim()), exploded[4].Trim()));
                }
            }
        }


        /// <summary>
        /// if the selected index is chosen then display data.
        /// </summary>
        /// <param name="sender">doctor combo box</param>
        /// <param name="e">event of the index of combo box changes</param>
        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear listbox from previous selected index.
            companionsListBox.Items.Clear();

            //check the selected value and show that doctor #'s info and companion.
            var selectedDoctor = from doc in doctorWhos
                                 where doc.ordinal == Convert.ToInt32(doctorComboBox.SelectedItem)
                                 select doc;
            //create a doctor object to hold the selected doctor.
            Doctor timeLord = null;

            //Set the selected Doctor to timeLord.
            foreach (var d in selectedDoctor)
            {
                timeLord = d;
            }
            //get selected episode that matches with selected doctor debut by episode story.
            var selectedAdventure = from ep in adventures
                                    where ep.story == timeLord.debut
                                    select ep;
            //create an episode to hold on to the doctor's episode
            Episode chapter = null;

            foreach (var a in selectedAdventure)
            {
                chapter = a;
            }

            Episode friendEpisode = null;

            //get selected companion that matches with selected doctor ordinal by companion doctor. 
            var selectedCompanion = from compan in assistants
                                    where compan.doctor == timeLord.ordinal
                                    select compan;
            //go through each companion that the doctor has to match companion episode with episode story.
            foreach (var c in selectedCompanion)
            {
                //get selected companion's episode that matches with selected Episode Story by companion debut.
                var companionDebut = from companEp in adventures
                                     where companEp.story == c.debut
                                     select companEp;
                //go through selected companionDebut to assign friendEpisode an object of episode.
                foreach (var cd in companionDebut)
                {
                    friendEpisode = cd;
                }

                //Show Companion information from friendEpisode and selected companion.
                string friendInfo = c.name + " (" + c.actor + ")";
                companionsListBox.Items.Add(friendInfo);
                friendInfo = "\"" + friendEpisode.title + "\" (" + friendEpisode.year + ")";
                companionsListBox.Items.Add(friendInfo);
                companionsListBox.Items.Add(" ");
            }

            //Show Doctor information.
            actorTextBox.Text = timeLord.actor;
            seriesTextBox.Text = timeLord.series.ToString();
            ageTextBox.Text = timeLord.age.ToString();

            //Show Episode Infomation
            yearTextBox.Text = chapter.year.ToString();
            firstEpisodeTextBox.Text = chapter.title.ToString();
        }
    }
}
