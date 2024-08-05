namespace C__Task
{
    partial class ModifyProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            modifyProductTitleLabel = new Label();
            modifyProductAssociatedPartsDGVLabel = new Label();
            modifyProductDeleteButton = new Button();
            modifyProductAssociatedPartsDGV = new DataGridView();
            modifyProductAllPartsDGVLabel = new Label();
            modifyProductAllPartsButton = new Button();
            modifyProductAllPartsDGV = new DataGridView();
            modifyProductSearchTextBox = new TextBox();
            modifyProductSearchButton = new Button();
            modifyProductMinTextBox = new TextBox();
            modifyProductMinLabel = new Label();
            modifyProductMaxTextBox = new TextBox();
            modifyProductMaxLabel = new Label();
            modifyProductPriceTextBox = new TextBox();
            modifyProductPriceLabel = new Label();
            modifyProductInventoryTextBox = new TextBox();
            modifyProductInventoryLabel = new Label();
            modifyProductNameTextBox = new TextBox();
            modifyProductNameLabel = new Label();
            modifyProductIDTextBox = new TextBox();
            modifyProductIDLabel = new Label();
            modifyProductCancelButton = new Button();
            modifyProductSaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)modifyProductAssociatedPartsDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductAllPartsDGV).BeginInit();
            SuspendLayout();
            // 
            // modifyProductTitleLabel
            // 
            modifyProductTitleLabel.AutoSize = true;
            modifyProductTitleLabel.Font = new Font("Segoe UI", 13F);
            modifyProductTitleLabel.Location = new Point(12, 9);
            modifyProductTitleLabel.Name = "modifyProductTitleLabel";
            modifyProductTitleLabel.Size = new Size(163, 30);
            modifyProductTitleLabel.TabIndex = 0;
            modifyProductTitleLabel.Text = "Modify Product";
            // 
            // modifyProductAssociatedPartsDGVLabel
            // 
            modifyProductAssociatedPartsDGVLabel.AutoSize = true;
            modifyProductAssociatedPartsDGVLabel.Font = new Font("Segoe UI", 9F);
            modifyProductAssociatedPartsDGVLabel.Location = new Point(559, 392);
            modifyProductAssociatedPartsDGVLabel.Name = "modifyProductAssociatedPartsDGVLabel";
            modifyProductAssociatedPartsDGVLabel.Size = new Size(236, 20);
            modifyProductAssociatedPartsDGVLabel.TabIndex = 56;
            modifyProductAssociatedPartsDGVLabel.Text = "Parts Associated With This Product";
            // 
            // modifyProductDeleteButton
            // 
            modifyProductDeleteButton.Location = new Point(1150, 641);
            modifyProductDeleteButton.Name = "modifyProductDeleteButton";
            modifyProductDeleteButton.Size = new Size(74, 43);
            modifyProductDeleteButton.TabIndex = 55;
            modifyProductDeleteButton.Text = "Add";
            modifyProductDeleteButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductAssociatedPartsDGV
            // 
            modifyProductAssociatedPartsDGV.AllowUserToAddRows = false;
            modifyProductAssociatedPartsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            modifyProductAssociatedPartsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            modifyProductAssociatedPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modifyProductAssociatedPartsDGV.Location = new Point(558, 417);
            modifyProductAssociatedPartsDGV.MultiSelect = false;
            modifyProductAssociatedPartsDGV.Name = "modifyProductAssociatedPartsDGV";
            modifyProductAssociatedPartsDGV.ReadOnly = true;
            modifyProductAssociatedPartsDGV.RowHeadersVisible = false;
            modifyProductAssociatedPartsDGV.RowHeadersWidth = 51;
            modifyProductAssociatedPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductAssociatedPartsDGV.Size = new Size(699, 218);
            modifyProductAssociatedPartsDGV.TabIndex = 54;
            modifyProductAssociatedPartsDGV.DataBindingComplete += modifyProductAssociatedBindingComplete;
            // 
            // modifyProductAllPartsDGVLabel
            // 
            modifyProductAllPartsDGVLabel.AutoSize = true;
            modifyProductAllPartsDGVLabel.Font = new Font("Segoe UI", 9F);
            modifyProductAllPartsDGVLabel.Location = new Point(558, 72);
            modifyProductAllPartsDGVLabel.Name = "modifyProductAllPartsDGVLabel";
            modifyProductAllPartsDGVLabel.Size = new Size(134, 20);
            modifyProductAllPartsDGVLabel.TabIndex = 53;
            modifyProductAllPartsDGVLabel.Text = "All Candidate Parts";
            // 
            // modifyProductAllPartsButton
            // 
            modifyProductAllPartsButton.Location = new Point(1149, 321);
            modifyProductAllPartsButton.Name = "modifyProductAllPartsButton";
            modifyProductAllPartsButton.Size = new Size(74, 43);
            modifyProductAllPartsButton.TabIndex = 52;
            modifyProductAllPartsButton.Text = "Add";
            modifyProductAllPartsButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductAllPartsDGV
            // 
            modifyProductAllPartsDGV.AllowUserToAddRows = false;
            modifyProductAllPartsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            modifyProductAllPartsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            modifyProductAllPartsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            modifyProductAllPartsDGV.Location = new Point(557, 97);
            modifyProductAllPartsDGV.MultiSelect = false;
            modifyProductAllPartsDGV.Name = "modifyProductAllPartsDGV";
            modifyProductAllPartsDGV.ReadOnly = true;
            modifyProductAllPartsDGV.RowHeadersVisible = false;
            modifyProductAllPartsDGV.RowHeadersWidth = 51;
            modifyProductAllPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductAllPartsDGV.Size = new Size(699, 218);
            modifyProductAllPartsDGV.TabIndex = 51;
            modifyProductAllPartsDGV.DataBindingComplete += modifyProductAllBindingComplete;
            // 
            // modifyProductSearchTextBox
            // 
            modifyProductSearchTextBox.Location = new Point(1025, 46);
            modifyProductSearchTextBox.Name = "modifyProductSearchTextBox";
            modifyProductSearchTextBox.Size = new Size(231, 30);
            modifyProductSearchTextBox.TabIndex = 50;
            // 
            // modifyProductSearchButton
            // 
            modifyProductSearchButton.Location = new Point(899, 43);
            modifyProductSearchButton.Name = "modifyProductSearchButton";
            modifyProductSearchButton.Size = new Size(87, 34);
            modifyProductSearchButton.TabIndex = 49;
            modifyProductSearchButton.Text = "Search";
            modifyProductSearchButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductMinTextBox
            // 
            modifyProductMinTextBox.Location = new Point(171, 489);
            modifyProductMinTextBox.Name = "modifyProductMinTextBox";
            modifyProductMinTextBox.Size = new Size(118, 30);
            modifyProductMinTextBox.TabIndex = 48;
            // 
            // modifyProductMinLabel
            // 
            modifyProductMinLabel.AutoSize = true;
            modifyProductMinLabel.Location = new Point(45, 492);
            modifyProductMinLabel.Name = "modifyProductMinLabel";
            modifyProductMinLabel.Size = new Size(39, 23);
            modifyProductMinLabel.TabIndex = 47;
            modifyProductMinLabel.Text = "Min";
            // 
            // modifyProductMaxTextBox
            // 
            modifyProductMaxTextBox.Location = new Point(172, 436);
            modifyProductMaxTextBox.Name = "modifyProductMaxTextBox";
            modifyProductMaxTextBox.Size = new Size(117, 30);
            modifyProductMaxTextBox.TabIndex = 46;
            // 
            // modifyProductMaxLabel
            // 
            modifyProductMaxLabel.AutoSize = true;
            modifyProductMaxLabel.Location = new Point(42, 439);
            modifyProductMaxLabel.Name = "modifyProductMaxLabel";
            modifyProductMaxLabel.Size = new Size(42, 23);
            modifyProductMaxLabel.TabIndex = 45;
            modifyProductMaxLabel.Text = "Max";
            // 
            // modifyProductPriceTextBox
            // 
            modifyProductPriceTextBox.Location = new Point(172, 385);
            modifyProductPriceTextBox.Name = "modifyProductPriceTextBox";
            modifyProductPriceTextBox.Size = new Size(234, 30);
            modifyProductPriceTextBox.TabIndex = 44;
            // 
            // modifyProductPriceLabel
            // 
            modifyProductPriceLabel.AutoSize = true;
            modifyProductPriceLabel.Location = new Point(42, 388);
            modifyProductPriceLabel.Name = "modifyProductPriceLabel";
            modifyProductPriceLabel.Size = new Size(98, 23);
            modifyProductPriceLabel.TabIndex = 43;
            modifyProductPriceLabel.Text = "Price / Cost";
            // 
            // modifyProductInventoryTextBox
            // 
            modifyProductInventoryTextBox.Location = new Point(172, 336);
            modifyProductInventoryTextBox.Name = "modifyProductInventoryTextBox";
            modifyProductInventoryTextBox.Size = new Size(234, 30);
            modifyProductInventoryTextBox.TabIndex = 42;
            // 
            // modifyProductInventoryLabel
            // 
            modifyProductInventoryLabel.AutoSize = true;
            modifyProductInventoryLabel.Location = new Point(42, 339);
            modifyProductInventoryLabel.Name = "modifyProductInventoryLabel";
            modifyProductInventoryLabel.Size = new Size(82, 23);
            modifyProductInventoryLabel.TabIndex = 41;
            modifyProductInventoryLabel.Text = "Inventory";
            // 
            // modifyProductNameTextBox
            // 
            modifyProductNameTextBox.Location = new Point(172, 285);
            modifyProductNameTextBox.Name = "modifyProductNameTextBox";
            modifyProductNameTextBox.Size = new Size(234, 30);
            modifyProductNameTextBox.TabIndex = 40;
            // 
            // modifyProductNameLabel
            // 
            modifyProductNameLabel.AutoSize = true;
            modifyProductNameLabel.Location = new Point(42, 288);
            modifyProductNameLabel.Name = "modifyProductNameLabel";
            modifyProductNameLabel.Size = new Size(56, 23);
            modifyProductNameLabel.TabIndex = 39;
            modifyProductNameLabel.Text = "Name";
            // 
            // modifyProductIDTextBox
            // 
            modifyProductIDTextBox.Location = new Point(172, 236);
            modifyProductIDTextBox.Name = "modifyProductIDTextBox";
            modifyProductIDTextBox.Size = new Size(234, 30);
            modifyProductIDTextBox.TabIndex = 38;
            // 
            // modifyProductIDLabel
            // 
            modifyProductIDLabel.AutoSize = true;
            modifyProductIDLabel.Location = new Point(42, 239);
            modifyProductIDLabel.Name = "modifyProductIDLabel";
            modifyProductIDLabel.Size = new Size(27, 23);
            modifyProductIDLabel.TabIndex = 37;
            modifyProductIDLabel.Text = "ID";
            // 
            // modifyProductCancelButton
            // 
            modifyProductCancelButton.Location = new Point(1150, 708);
            modifyProductCancelButton.Name = "modifyProductCancelButton";
            modifyProductCancelButton.Size = new Size(74, 43);
            modifyProductCancelButton.TabIndex = 58;
            modifyProductCancelButton.Text = "Cancel";
            modifyProductCancelButton.UseVisualStyleBackColor = true;
            // 
            // modifyProductSaveButton
            // 
            modifyProductSaveButton.Location = new Point(1035, 708);
            modifyProductSaveButton.Name = "modifyProductSaveButton";
            modifyProductSaveButton.Size = new Size(74, 43);
            modifyProductSaveButton.TabIndex = 57;
            modifyProductSaveButton.Text = "Save";
            modifyProductSaveButton.UseVisualStyleBackColor = true;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 768);
            Controls.Add(modifyProductCancelButton);
            Controls.Add(modifyProductSaveButton);
            Controls.Add(modifyProductAssociatedPartsDGVLabel);
            Controls.Add(modifyProductDeleteButton);
            Controls.Add(modifyProductAssociatedPartsDGV);
            Controls.Add(modifyProductAllPartsDGVLabel);
            Controls.Add(modifyProductAllPartsButton);
            Controls.Add(modifyProductAllPartsDGV);
            Controls.Add(modifyProductSearchTextBox);
            Controls.Add(modifyProductSearchButton);
            Controls.Add(modifyProductMinTextBox);
            Controls.Add(modifyProductMinLabel);
            Controls.Add(modifyProductMaxTextBox);
            Controls.Add(modifyProductMaxLabel);
            Controls.Add(modifyProductPriceTextBox);
            Controls.Add(modifyProductPriceLabel);
            Controls.Add(modifyProductInventoryTextBox);
            Controls.Add(modifyProductInventoryLabel);
            Controls.Add(modifyProductNameTextBox);
            Controls.Add(modifyProductNameLabel);
            Controls.Add(modifyProductIDTextBox);
            Controls.Add(modifyProductIDLabel);
            Controls.Add(modifyProductTitleLabel);
            Font = new Font("Segoe UI", 10F);
            Name = "ModifyProductForm";
            Text = "Product";
            Load += ModifyProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)modifyProductAssociatedPartsDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)modifyProductAllPartsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modifyProductTitleLabel;
        private Label modifyProductAssociatedPartsDGVLabel;
        private Button modifyProductDeleteButton;
        private Label modifyProductAllPartsDGVLabel;
        private Button modifyProductAllPartsButton;
        private TextBox modifyProductSearchTextBox;
        private Button modifyProductSearchButton;
        private TextBox modifyProductMinTextBox;
        private Label modifyProductMinLabel;
        private TextBox modifyProductMaxTextBox;
        private Label modifyProductMaxLabel;
        private TextBox modifyProductPriceTextBox;
        private Label modifyProductPriceLabel;
        private TextBox modifyProductInventoryTextBox;
        private Label modifyProductInventoryLabel;
        private TextBox modifyProductNameTextBox;
        private Label modifyProductNameLabel;
        private TextBox modifyProductIDTextBox;
        private Label modifyProductIDLabel;
        private Button modifyProductCancelButton;
        private Button modifyProductSaveButton;
        public DataGridView modifyProductAllPartsDGV;
        public DataGridView modifyProductAssociatedPartsDGV;
    }
}