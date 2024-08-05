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
    public partial class ModifyProductForm : Form
    {
        public ModifyProductForm()
        {
            InitializeComponent();
        }

        private void ModifyProductForm_Load(object sender, EventArgs e)
        {
            modifyProductAllPartsDGV.DataSource = Inventory.partsList;
            //modifyProductAssociatedPartsDGV.DataSource = Inventory.partsList;
        }

        // When form is loaded, rows aren't automatically highlighted/selected
        private void modifyProductAllBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyProductAllPartsDGV.ClearSelection();
        }

        private void modifyProductAssociatedBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            modifyProductAssociatedPartsDGV.ClearSelection();
        }
    }
}
