using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Lab to be done individually
 * In order to be graded, the following Statement of Authorship must be present at the beginning of the script
 * I, Jacob Robbins, student number 000371194, certify that this material is my original work. No other person's work has been used without 
 * due acknowledgment and I have not made my work available to anyone else.
 * March 2023
 */


namespace Lab3B2
{
    /// <summary>
    /// Lab 3B - Purpose - To calculate the rates and services offered by a Hairsalon.
    /// </summary>
    public partial class Lab3B : Form
    {
        /// <summary>
        /// Form Constructor
        /// </summary>
        public Lab3B()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ServiceBox_SelectedIndexChanged - Enables the Add Button when the ServiceBox detects a change in selection.
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="e">default</param>
        private void ServiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ServiceBox.SelectedIndex != -1)
            {
                AddButton.Enabled = true;
            }
        }

        /// <summary>
        /// AddButton_Click() - Method that adds the services and hairdressers to their respected ListBoxes when the AddButton is clicked.
        /// </summary>
        /// <param name="sender">default</param>
        /// <param name="e">default</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var x = ChargeBox.Items.Count;
            var y = HairdresserBox.SelectedIndex;

            if (y != -1 && x <= 0)
            {
                string n = HairdresserBox.Text;
                string m = ServiceBox.Text;
                var dresserNoNum = Regex.Replace(n, "[0-9$-.]+", string.Empty);
                var serviceNoNum = Regex.Replace(m, "[0-9$-.]+", string.Empty);

                ChargeBox.Items.Add(dresserNoNum);
                ChargeBox.Items.Add(serviceNoNum);

                var dresserText = Regex.Replace(n, "[A-Z/a-z- ]+", string.Empty);
                var serviceText = Regex.Replace(m, "[A-Z/a-z- ]+", string.Empty);

                PriceList.Items.Add(dresserText);
                PriceList.Items.Add(serviceText);

                CalculateButton.Enabled = true;
                HairdresserBox.Enabled = false;
            }
            else if (x != -1)
            {
                string m = ServiceBox.Text;
                var serviceNoNum = Regex.Replace(m, "[0-9$-.]+", string.Empty);
                var serviceText = Regex.Replace(m, "[A-Z/a-z- ]+", string.Empty);
                ChargeBox.Items.Add(serviceNoNum);
                PriceList.Items.Add(serviceText);
            }

        }
            /// <summary>
            /// CalculateButton_Click() - Method that calculates the sum of all the services collected in the PriceListBox
            /// </summary>
            /// <param name="sender">default</param>
            /// <param name="e">default</param>
            private void CalculateButton_Click(object sender, EventArgs e)
            {
                var sum = PriceList.Items.Cast<string>()
                    .Select(x => int.Parse(Regex.Match(x, @"\d+").Value))
                    .Sum();

                if (FinalPrice.Items.Count == -1)
                {
                    FinalPrice.Items.Add(sum);
                }
                else if (FinalPrice.Items.Count >= 0)
                {
                    FinalPrice.Items.Clear();
                    FinalPrice.Items.Add($"{sum:C2}");
                }
            }

            /// <summary>
            /// CalculateButton_Click() - Method that calculates the sum of all the services collected in the PriceListBox
            /// </summary>
            /// <param name="sender">default</param>
            /// <param name="e">default</param>
            private void ExitButton_Click_1(object sender, EventArgs e)
                {
                    Application.Exit();
                }

            /// <summary>
            /// ResetButton_Click() - Method that resets all the fields on the form and sets focus to the HairdresserBox
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ResetButton_Click(object sender, EventArgs e)
            {
                {
                    HairdresserBox.SelectedIndex = 0;
                    HairdresserBox.Enabled = true;
                    ServiceBox.SelectedIndex = 0;
                    PriceList.Items.Clear();
                    ChargeBox.Items.Clear();
                    FinalPrice.Items.Clear();
                    AddButton.Enabled = false;
                    CalculateButton.Enabled = false;
                    HairdresserBox.Focus();
                }
            }
        }
    }