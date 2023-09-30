using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_JosueBenjaminCenturion
{
    public partial class AddNewQuoteForm : Form
    {
        // Get the Current

        public string Date { get; set; }


        public AddNewQuoteForm()
        {
            InitializeComponent();
        }

        // It performs preparatory logic for the form 
        private void AddNewQuoteForm_Load(object sender, EventArgs e)
        {


            // Gets the values stored in the DesktopMaterial enum 
            DesktopMaterial[] desktopMaterial = (DesktopMaterial[])Enum.GetValues(typeof(DesktopMaterial));

            // Assign each of the values to be an option for the material field
            foreach (DesktopMaterial material in desktopMaterial)
            {
                materialComboBox.Items.Add(material.ToString());
            }

            // Performing the same action as line 26 and 29, but with the RushDays enum
            RushDays[] rush = (RushDays[])Enum.GetValues(typeof(RushDays));

            foreach (RushDays day in rush)
            {
                rushComboBox.Items.Add((int)day);
            }

            // Disables sendQuote button to don't send an empty form 
            sendQuote.Enabled = false;

            // Updates the current day format to capitalize the first letter in the month
            DateTime formattedDate = DateTime.Now;
            string[] dateParts = formattedDate.ToString("dd MMMM yyyy").Split(' ');
            dateParts[1] = char.ToUpper(dateParts[1][0]) + dateParts[1].Substring(1);
            string finalDate = string.Join(" ", dateParts);
            currentTime.Text = finalDate;
            Date = finalDate; 
        }

        private void BackMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        // Inputs Validations 

        // Validating name
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void nameTextBox_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            //widthErrorProvider.SetError(nameTextBox, "");
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            
           
        }


        // Width Validating

        // Before the user leaves the focus in it, it checks if the input is valid.
        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string width = widthTextBox.Text.Trim();
            string errorMsg = "";


            // Validating if the width is an integer,
            // if not, it shows a error 
            if (!int.TryParse(width, out int result))
            {
                e.Cancel = true;
                widthTextBox.Select(0, widthTextBox.Text.Length);
                errorMsg = "Invalid width input. Please enter a valid integer";
                this.widthErrorProvider.SetError(widthTextBox, errorMsg);
            }
            else
            {
                // Validating width if it's in range of the MIN and MAX
                // determined by the Desk class. 
                if (!ValidWidth(result, out errorMsg))
                {
                    e.Cancel = true;
                    widthTextBox.Select(0, widthTextBox.Text.Length);
                    this.widthErrorProvider.SetError(widthTextBox, errorMsg);
                }
                else
                {
                    // If it's a valid input, no errors. 
                    widthErrorProvider.SetError(widthTextBox, "");
                    ValidateInputsAndEnableSendQuote();
                }


            }
        }

        // Performing the logic of validating the MIN and MAX width 
        public bool ValidWidth(int width, out string errorMessage)
        {
            if (width < Desk.MINWIDTH)
            {
                errorMessage = $"Width must be greater than {Desk.MINWIDTH}";
                return false;
            }
            else if (width > Desk.MAXWIDTH)
            {
                errorMessage = $"Width must be smaller than {Desk.MAXWIDTH}";
                return false;
            }
            else
            {
                errorMessage = null;
                return true;
            }
        }

        // If all conditions have been met, clear the ErrorProvider of errors.
        private void widthTextBox_Validated(object sender, EventArgs e)
        {
            widthErrorProvider.SetError(widthTextBox, "");
        }

        // Prevents to the user to input invalid values by making to select itself
        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = widthTextBox.Text.Trim();
            string errorMsg = "";

            if (!int.TryParse(input, out _))
            {
                widthTextBox.Select(0, widthTextBox.Text.Length);
                errorMsg = "Invalid width input. Please enter a valid integer.";
                this.widthErrorProvider.SetError(widthTextBox, errorMsg);
            }
            else
            {
                widthErrorProvider.SetError(widthTextBox, "");
                ValidateInputsAndEnableSendQuote();
            }
        }



        // Depth Validation

        // It performs the validation of the input by checking the key pressed
        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string depth = e.KeyChar.ToString();
            string errorMsg;

            try
            {
                // If the input is not a digit or control, it prevents the user to 
                // receive it in the textbox 
                if (int.TryParse(depth, out _))
                {
                    depthErrorProvider.SetError(depthTextBox, "");
                    ValidateInputsAndEnableSendQuote();
                }
                else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    errorMsg = "You're trying to enter a non-valid integer, please try typing an integer";
                    depthTextBox.Select(0, depthTextBox.Text.Length);
                    this.depthErrorProvider.SetError(depthTextBox, errorMsg);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        // Before the user leaves the focus in it, it checks if the input
        // is an int and the is in between the MIN and MAX depth
        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            int depth;
            string errorMsg;

            try
            {
                if (!int.TryParse(depthTextBox.Text, out depth))
                {
                    errorMsg = "You're trying to enter a non-valid integer, please try typing an integer";
                    depthTextBox.Select(0, depthTextBox.Text.Length);
                    this.depthErrorProvider.SetError(depthTextBox, errorMsg);
                    e.Cancel = true;
                }
                else
                {

                    if (!ValidDepth(depth, out errorMsg))
                    {
                        depthTextBox.Select(0, depthTextBox.Text.Length);
                        this.depthErrorProvider.SetError(depthTextBox, errorMsg);
                    }
                    else
                    {
                        depthErrorProvider.SetError(depthTextBox, "");
                        ValidateInputsAndEnableSendQuote();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        // It checks if the depth is between the MIN and MAX depth allowed
        private bool ValidDepth(int depth, out string errorMessage)
        {
            if (depth < Desk.MINDEPTH)
            {
                errorMessage = $"Depth must be greater than {Desk.MINDEPTH}";
                return false;
            }
            else if (depth > Desk.MAXDEPTH)
            {
                errorMessage = $"Depth must be smaller than {Desk.MAXDEPTH}";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }

        }


        // Before the user leaves the focus in it, it checks if the input
        // is an int and the is in between the MIN and MAX drawers
        private void drawersTextBox_Validating(object sender, CancelEventArgs e)
        {
            int drawers;
            string errorMsg;

            try
            {
                if (!int.TryParse(drawersTextBox.Text, out drawers))
                {
                    errorMsg = "You're trying to enter a non-valid integer, please try typing an integer";
                    drawersTextBox.Select(0, drawersTextBox.Text.Length);
                    this.drawersErrorProvider.SetError(drawersTextBox, errorMsg);
                    e.Cancel = true;
                }
                else
                {

                    if (!ValidDrawers(drawers, out errorMsg))
                    {
                        drawersTextBox.Select(0, drawersTextBox.Text.Length);
                        this.drawersErrorProvider.SetError(drawersTextBox, errorMsg);
                    }
                    else
                    {
                        drawersErrorProvider.SetError(drawersTextBox, "");
                        ValidateInputsAndEnableSendQuote();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        // It checks if the drawers are between the MIN and MAX depth allowed
        public bool ValidDrawers(int drawers, out string errorMessage)
        {
            if (drawers < Desk.MINNUMOFDRAWERS)
            {
                errorMessage = $"The number of drawers must be at least {Desk.MINNUMOFDRAWERS}";
                return false;
            }
            else if (drawers > Desk.MAXNUMOFDRAWERS)
            {
                errorMessage = $"The number of drawers must be smaller than {Desk.MAXNUMOFDRAWERS}";
                return false;
            }
            else
            {
                errorMessage = null;
                return true;
            }
        }

        // It checks if the user choose an option after focusing on this field,
        // but before leaving the focus 
        private void materialComboBox_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                if (materialComboBox.SelectedIndex == -1)
                {
                    string errorMsg = "Please select a valid option from the list.";
                    e.Cancel = true;
                    materialErrorProvider.SetError(materialComboBox, errorMsg);
                }
                else
                {
                    materialErrorProvider.SetError(materialComboBox, "");

                }
                ValidateInputsAndEnableSendQuote();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        // It prevents the user to write an input out of the list of options
        // If the users tries to leave the input without choosing an input, it displays 
        // an error message. 
        private void rushcomboBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (rushComboBox.SelectedIndex == -1)
                {
                    string errorMsg = "Please select a valid option from the list.";
                    e.Cancel = true;
                    materialErrorProvider.SetError(rushComboBox, errorMsg);
                }
                else
                {
                    materialErrorProvider.SetError(rushComboBox, "");

                }
                ValidateInputsAndEnableSendQuote();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        // It handles the DeskQuote submission, It receives the desk properties to display them 
        // in the upcoming form called "DisplayQuote"
        private void sendQuote_Click(object sender, EventArgs e)

        {
            int width = Convert.ToInt32(widthTextBox.Text);
            int depth = Convert.ToInt32(depthTextBox.Text);
            string name = nameTextBox.Text;
            string material = materialComboBox.Text;
            int drawers = Convert.ToInt32(drawersTextBox.Text);
            int rushDays = Convert.ToInt32(rushComboBox.Text);

            Desk submittedDesk = new Desk(width, depth, drawers, material);
            DeskQuote deskQuote = new DeskQuote(submittedDesk, rushDays, name, Date);

            DisplayQuote displayQuoteForm = new DisplayQuote(deskQuote);
            displayQuoteForm.Show();
        }

        // It checks if all inputs are present in the right format before 
        // enabling submission
        private void ValidateInputsAndEnableSendQuote()
        {
            if (ValidateInputs())
            {
                sendQuote.Enabled = true;
            }
            else
            {
                sendQuote.Enabled = false;
            }
        }

        // It validates if the input fields are completed, if not, returns false
        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(widthTextBox.Text) ||
                string.IsNullOrEmpty(depthTextBox.Text) ||
                string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(materialComboBox.Text) ||
                string.IsNullOrEmpty(drawersTextBox.Text) ||
                string.IsNullOrEmpty(rushComboBox.Text))
            {
                return false;
            }

            return true;
        }


    }
}
