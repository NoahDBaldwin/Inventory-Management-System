using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Task
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Add button under parts DGV on main directs to Add Parts Window
        private void addPartsButton_Click(object sender, EventArgs e)
        {
            // "this" allows the partsDataGridView to transfer to the add parts form
            AddPartForm addPartForm = new();
            addPartForm.Show();
        }
        


        // Modify button under parts DGV on main directs to Modify Parts Window
        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            ModifyPartForm modifyPartForm = new(this);
            modifyPartForm.Show();
        }

        // Add button under products DGV on main directs to Add Products Window
        private void addProductsButton_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new();
            addProductForm.Show();
        }

        // Modify button under products DGV on main directs to Modify Products Window
        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            ModifyProductForm modifyProductForm = new();
            modifyProductForm.Show();
        }



        // Function to populate the tables of the main form on load
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Create a few items for the parts list
            InHouse inHouse1 = new InHouse(0, "Tire", 11, 8.00M, 5, 25, 12);
            InHouse inHouse2 = new InHouse(1, "Bottom Bracket", 7, 24.87M, 5, 25, 3);
            Outsourced outsourced1 = new Outsourced(2, "Pannier", 16, 88.45M, 5, 25, "Ortlieb");


            // Initialize data in the data lists. Then populate DGV by using the lists as a datasource.
            Inventory.ListInit();
            Inventory.partsList.Add(inHouse1);
            Inventory.partsList.Add(inHouse2);
            Inventory.partsList.Add(outsourced1);
            partsDataGridView.DataSource = Inventory.partsList;
            productsDataGridView.DataSource = Inventory.productsList;
         
          
            // When form is loaded, make min, max not visible
            partsDataGridView.Columns["partMin"].Visible = false;
            partsDataGridView.Columns["partMax"].Visible = false;
            //partsDataGridView.Columns["machineId"].Visible = false;
            //partsDataGridView.Columns["inHouse"].Visible = false;
            productsDataGridView.Columns["productMin"].Visible = false;
            productsDataGridView.Columns["productMax"].Visible = false;
        }


        // When the form is loaded, there isn't a row automatically highlighted/selected
        private void partsMainBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsDataGridView.ClearSelection();
        }
        private void productsMainDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productsDataGridView.ClearSelection();
        }



        // Parts delete button
        private void deletePartsButton_Click(object sender, EventArgs e)
        {

            DialogResult isSure = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (isSure == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partsDataGridView.SelectedRows)
                {
                    partsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                return;
            }

        }

        // Products Delete Button
        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
             DialogResult isSure = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (isSure == DialogResult.Yes)
             {
                 foreach (DataGridViewRow row in productsDataGridView.SelectedRows)
                 {
                     productsDataGridView.Rows.RemoveAt(row.Index);
                 }
             }
             else
             {
                 return;
             }
            
        }

        // Exit Button closes Window
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        // Show matching parts from search
        private void partsSearchButton_Click(object sender, EventArgs e)
        {
            partsDataGridView.ClearSelection();
            // Take in input of the ID number
            int partSearchId;
            if (partsSearchTextBox.Text != "")
            {
                
                partSearchId = Convert.ToInt32(partsSearchTextBox.Text);
                   

                foreach (DataGridViewRow row in partsDataGridView.Rows)
                {
                    // Call the lookupPart function with the paramater of the entered ID
                    Inventory.LookupPart(partSearchId);
                }
            }
        }
        


        // Show matching Products from search
        private void productsSearchButton_Click(object sender, EventArgs e)
        {
            productsDataGridView.ClearSelection();

        }
    }
}
