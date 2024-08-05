using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Task
{
    public partial class ModifyPartForm : Form
    {
        MainForm mainForm;
        public ModifyPartForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;   
        }
       

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {
            // Make sure that a row was selected from partsDataGridView on load
            if (mainForm.partsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a part to modify.");
                this.Close();
            }
            else
            {
                foreach (DataGridViewRow row in mainForm.partsDataGridView.SelectedRows)
                {
                    MessageBox.Show("Text");
                    modifyPartIDTextBox.Text = row.Cells[0].Value.ToString();
                    modifyPartNameTextBox.Text = row.Cells[1].Value.ToString();
                    modifyPartInventoryTextBox.Text = row.Cells[2].Value.ToString();
                    modifyPartPriceTextBox.Text = row.Cells[3].Value.ToString();
                    modifyPartMinTextBox.Text = row.Cells[4].Value.ToString();
                    modifyPartMaxTextBox.Text = row.Cells[5].Value.ToString();
                    modifyPartMachineIDTextBox.Text = row.Cells[6].Value.ToString();
                }

            }
                
        }


        // Checks if the radio button is inhouse or outsourced, change label text
        bool isInHouse = true;
        private void modifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineIDLabel.Text = "Machine ID";
            //isInHouse = true;
        }
        private void modifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartMachineIDLabel.Text = "Company Name";
            //isInHouse = false;
        }



        /*
        int partId;
        Parts part;
        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            Inventory.UpdatePart(partId, part);
        }
        */



        // Cancel button closes the window
        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
