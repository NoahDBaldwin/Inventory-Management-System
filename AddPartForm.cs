using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Task
{
    public partial class AddPartForm : Form
    {
        //MainForm mainForm;
        public AddPartForm()
        {
            InitializeComponent();
            //this.mainForm = mainForm;
        }


        // Cancel button closes window
        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Checks if the radio button is inhouse or outsourced, change label text
        bool isInHouse = true;
        private void addPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineIDLabel.Text = "Machine ID";
            isInHouse = true;
        }
        private void addPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineIDLabel.Text = "Company Name";
            isInHouse = false;
        }



        // Auto generate the next ID number
        int partIdCurrent = Inventory.partsList.Count + 1;
        // Make the Id number show in the text box
        private void AddPartForm_Load(object sender, EventArgs e)
        {
            addPartIDTextBox.Text = Convert.ToString(partIdCurrent);
        }



        // Save Button adds the part to the binding list and closes the window
        private void addPartSaveButton_Click(object sender, EventArgs e)
        {


            // Keep track if there are errors
            int errorCount1 = 0;

            foreach (Control txtBox in this.Controls)
            {
                if (txtBox.Text == "")
                {
                    // Change color if missing a field
                    txtBox.BackColor = Color.FromArgb(255, 100, 100);
                    errorCount1++;
                }
            }

            // Show an error if any fields are missing
            if (errorCount1 > 0)
            {
                MessageBox.Show("Fill all of fields.");
            }
            else
            {

                // check if there is an error (if users put in a string where a number belongs)
                bool parseError = false;

                // Make sure that it is numbers entered into the text boxes, catch parsing errors
                try
                {
                    int inventory = Convert.ToInt32(addPartInventoryTextBox.Text);
                    decimal price = Convert.ToDecimal(addPartPriceTextBox.Text);
                    int min = Convert.ToInt32(addPartMinTextBox.Text);
                    int max = Convert.ToInt32(addPartMaxTextBox.Text);
                    int machineId = Convert.ToInt32(addPartMachineIDTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    parseError = true;
                }

                // If there are no errors, run the actual save code
                if (parseError == false)
                {
                    // Add the content from each of the fields in the form to the "part" object (inhouse or outsourced).
                    if (isInHouse == true)
                    {

                        InHouse inHouse = new InHouse
                        (
                            partIdCurrent,
                            addPartNameTextBox.Text,
                            Convert.ToInt32(addPartInventoryTextBox.Text),
                            Convert.ToDecimal(addPartPriceTextBox.Text),
                            Convert.ToInt32(addPartMinTextBox.Text),
                            Convert.ToInt32(addPartMaxTextBox.Text),
                            Convert.ToInt32(addPartMachineIDTextBox.Text)
                        );

                        // Add the part to the binding list
                        Inventory.AddPart(inHouse);
                    }
                    else
                    {
                        Outsourced outsourced = new Outsourced
                        (
                            partIdCurrent,
                            addPartNameTextBox.Text,
                            Convert.ToInt32(addPartInventoryTextBox.Text),
                            Convert.ToDecimal(addPartPriceTextBox.Text),
                            Convert.ToInt32(addPartMinTextBox.Text),
                            Convert.ToInt32(addPartMaxTextBox.Text),
                            addPartMachineIDTextBox.Text
                        );

                        // Add the part to the binding list
                        Inventory.AddPart(outsourced);
                    }

                    // Close the form
                    this.Close();
                }
            }
        }
    }
}
