namespace C__Task
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            mainPageLabel = new Label();
            partsSearchTextBox = new TextBox();
            productsSearchTextBox = new TextBox();
            productsSearchButton = new Button();
            partsSearchButton = new Button();
            partsDataGridView = new DataGridView();
            productsDataGridView = new DataGridView();
            addPartsButton = new Button();
            modifyPartsButton = new Button();
            deletePartsButton = new Button();
            deleteProductsButton = new Button();
            modifyProductsButton = new Button();
            addProductsButton = new Button();
            mainExitButton = new Button();
            mainPartsDGVLabel = new Label();
            mainProductsDGVLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainPageLabel
            // 
            mainPageLabel.AutoSize = true;
            mainPageLabel.Font = new Font("Segoe UI", 12F);
            mainPageLabel.Location = new Point(13, 9);
            mainPageLabel.Margin = new Padding(4, 0, 4, 0);
            mainPageLabel.Name = "mainPageLabel";
            mainPageLabel.Size = new Size(283, 28);
            mainPageLabel.TabIndex = 0;
            mainPageLabel.Text = "Inventory Management System";
            // 
            // partsSearchTextBox
            // 
            partsSearchTextBox.Location = new Point(511, 84);
            partsSearchTextBox.Name = "partsSearchTextBox";
            partsSearchTextBox.Size = new Size(231, 30);
            partsSearchTextBox.TabIndex = 2;
            // 
            // productsSearchTextBox
            // 
            productsSearchTextBox.Location = new Point(1274, 84);
            productsSearchTextBox.Name = "productsSearchTextBox";
            productsSearchTextBox.Size = new Size(231, 30);
            productsSearchTextBox.TabIndex = 4;
            // 
            // productsSearchButton
            // 
            productsSearchButton.Location = new Point(1141, 82);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(87, 34);
            productsSearchButton.TabIndex = 3;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = true;
            productsSearchButton.Click += productsSearchButton_Click;
            // 
            // partsSearchButton
            // 
            partsSearchButton.Location = new Point(385, 81);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(87, 34);
            partsSearchButton.TabIndex = 1;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = true;
            partsSearchButton.Click += partsSearchButton_Click;
            // 
            // partsDataGridView
            // 
            partsDataGridView.AllowUserToAddRows = false;
            partsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "Part ID";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            partsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            partsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsDataGridView.Location = new Point(43, 132);
            partsDataGridView.MultiSelect = false;
            partsDataGridView.Name = "partsDataGridView";
            partsDataGridView.ReadOnly = true;
            partsDataGridView.RowHeadersVisible = false;
            partsDataGridView.RowHeadersWidth = 51;
            partsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsDataGridView.Size = new Size(699, 337);
            partsDataGridView.TabIndex = 5;
            partsDataGridView.DataBindingComplete += partsMainBindingComplete;
            // 
            // productsDataGridView
            // 
            productsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGridView.Location = new Point(803, 132);
            productsDataGridView.MultiSelect = false;
            productsDataGridView.Name = "productsDataGridView";
            productsDataGridView.ReadOnly = true;
            productsDataGridView.RowHeadersVisible = false;
            productsDataGridView.RowHeadersWidth = 51;
            productsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDataGridView.Size = new Size(702, 337);
            productsDataGridView.TabIndex = 6;
            productsDataGridView.DataBindingComplete += productsMainDataBindingComplete;
            // 
            // addPartsButton
            // 
            addPartsButton.Location = new Point(461, 475);
            addPartsButton.Name = "addPartsButton";
            addPartsButton.Size = new Size(74, 43);
            addPartsButton.TabIndex = 7;
            addPartsButton.Text = "Add";
            addPartsButton.UseVisualStyleBackColor = true;
            addPartsButton.Click += addPartsButton_Click;
            // 
            // modifyPartsButton
            // 
            modifyPartsButton.Location = new Point(563, 475);
            modifyPartsButton.Name = "modifyPartsButton";
            modifyPartsButton.Size = new Size(74, 43);
            modifyPartsButton.TabIndex = 8;
            modifyPartsButton.Text = "Modify";
            modifyPartsButton.UseVisualStyleBackColor = true;
            modifyPartsButton.Click += modifyPartsButton_Click;
            // 
            // deletePartsButton
            // 
            deletePartsButton.Location = new Point(668, 475);
            deletePartsButton.Name = "deletePartsButton";
            deletePartsButton.Size = new Size(74, 43);
            deletePartsButton.TabIndex = 9;
            deletePartsButton.Text = "Delete";
            deletePartsButton.UseVisualStyleBackColor = true;
            deletePartsButton.Click += deletePartsButton_Click;
            // 
            // deleteProductsButton
            // 
            deleteProductsButton.Location = new Point(1431, 475);
            deleteProductsButton.Name = "deleteProductsButton";
            deleteProductsButton.Size = new Size(74, 43);
            deleteProductsButton.TabIndex = 12;
            deleteProductsButton.Text = "Delete";
            deleteProductsButton.UseVisualStyleBackColor = true;
            deleteProductsButton.Click += deleteProductsButton_Click;
            // 
            // modifyProductsButton
            // 
            modifyProductsButton.Location = new Point(1326, 475);
            modifyProductsButton.Name = "modifyProductsButton";
            modifyProductsButton.Size = new Size(74, 43);
            modifyProductsButton.TabIndex = 11;
            modifyProductsButton.Text = "Modify";
            modifyProductsButton.UseVisualStyleBackColor = true;
            modifyProductsButton.Click += modifyProductsButton_Click;
            // 
            // addProductsButton
            // 
            addProductsButton.Location = new Point(1224, 475);
            addProductsButton.Name = "addProductsButton";
            addProductsButton.Size = new Size(74, 43);
            addProductsButton.TabIndex = 10;
            addProductsButton.Text = "Add";
            addProductsButton.UseVisualStyleBackColor = true;
            addProductsButton.Click += addProductsButton_Click;
            // 
            // mainExitButton
            // 
            mainExitButton.Location = new Point(1431, 549);
            mainExitButton.Name = "mainExitButton";
            mainExitButton.Size = new Size(74, 43);
            mainExitButton.TabIndex = 13;
            mainExitButton.Text = "E&xit";
            mainExitButton.UseVisualStyleBackColor = true;
            mainExitButton.Click += mainExitButton_Click;
            // 
            // mainPartsDGVLabel
            // 
            mainPartsDGVLabel.AutoSize = true;
            mainPartsDGVLabel.Font = new Font("Segoe UI", 13F);
            mainPartsDGVLabel.Location = new Point(43, 88);
            mainPartsDGVLabel.Name = "mainPartsDGVLabel";
            mainPartsDGVLabel.Size = new Size(59, 30);
            mainPartsDGVLabel.TabIndex = 14;
            mainPartsDGVLabel.Text = "Parts";
            // 
            // mainProductsDGVLabel
            // 
            mainProductsDGVLabel.AutoSize = true;
            mainProductsDGVLabel.Font = new Font("Segoe UI", 13F);
            mainProductsDGVLabel.Location = new Point(804, 89);
            mainProductsDGVLabel.Name = "mainProductsDGVLabel";
            mainProductsDGVLabel.Size = new Size(97, 30);
            mainProductsDGVLabel.TabIndex = 15;
            mainProductsDGVLabel.Text = "Products";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 616);
            Controls.Add(mainProductsDGVLabel);
            Controls.Add(mainPartsDGVLabel);
            Controls.Add(mainExitButton);
            Controls.Add(deleteProductsButton);
            Controls.Add(modifyProductsButton);
            Controls.Add(addProductsButton);
            Controls.Add(deletePartsButton);
            Controls.Add(modifyPartsButton);
            Controls.Add(addPartsButton);
            Controls.Add(productsDataGridView);
            Controls.Add(partsDataGridView);
            Controls.Add(productsSearchTextBox);
            Controls.Add(productsSearchButton);
            Controls.Add(partsSearchTextBox);
            Controls.Add(partsSearchButton);
            Controls.Add(mainPageLabel);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Main Screen";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)partsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainPageLabel;
        private TextBox partsSearchTextBox;
        private TextBox productsSearchTextBox;
        private Button productsSearchButton;
        private Button partsSearchButton;
        private Button addPartsButton;
        private Button modifyPartsButton;
        private Button deletePartsButton;
        private Button deleteProductsButton;
        private Button modifyProductsButton;
        private Button addProductsButton;
        private Button mainExitButton;
        private Label mainPartsDGVLabel;
        private Label mainProductsDGVLabel;
        public DataGridView partsDataGridView;
        public DataGridView productsDataGridView;
    }
}
