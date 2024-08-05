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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }


        private void AddProductForm_Load(object sender, EventArgs e)
        {
            addProductAllPartsDGV.DataSource = Inventory.partsList;
            //addProductAssociatedPartsDGV.DataSource = Inventory.partsList;
        }


        // When form is loaded, rows aren't automatically highlighted/selected
        private void addProductAllBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductAllPartsDGV.ClearSelection();
        }

        private void addProductAssociatedBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            addProductAssociatedPartsDGV.ClearSelection();
        }
    }
}
