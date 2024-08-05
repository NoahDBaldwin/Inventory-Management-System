namespace C__Task
{
    partial class AddPartForm
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
            addPartTitleLabel = new Label();
            addPartInHouseRadio = new RadioButton();
            addPartOutsourcedRadio = new RadioButton();
            addPartIDLabel = new Label();
            addPartIDTextBox = new TextBox();
            addPartNameTextBox = new TextBox();
            addPartNameLabel = new Label();
            addPartPriceTextBox = new TextBox();
            addPartPriceLabel = new Label();
            addPartInventoryTextBox = new TextBox();
            addPartInventoryLabel = new Label();
            addPartMaxTextBox = new TextBox();
            addPartMaxLabel = new Label();
            addPartMinTextBox = new TextBox();
            addPartMinLabel = new Label();
            addPartMachineIDTextBox = new TextBox();
            addPartMachineIDLabel = new Label();
            addPartSaveButton = new Button();
            addPartCancelButton = new Button();
            SuspendLayout();
            // 
            // addPartTitleLabel
            // 
            addPartTitleLabel.AutoSize = true;
            addPartTitleLabel.Font = new Font("Segoe UI", 13F);
            addPartTitleLabel.Location = new Point(14, 10);
            addPartTitleLabel.Name = "addPartTitleLabel";
            addPartTitleLabel.Size = new Size(96, 30);
            addPartTitleLabel.TabIndex = 0;
            addPartTitleLabel.Text = "Add Part";
            // 
            // addPartInHouseRadio
            // 
            addPartInHouseRadio.AutoSize = true;
            addPartInHouseRadio.Location = new Point(174, 14);
            addPartInHouseRadio.Name = "addPartInHouseRadio";
            addPartInHouseRadio.Size = new Size(101, 27);
            addPartInHouseRadio.TabIndex = 1;
            addPartInHouseRadio.TabStop = true;
            addPartInHouseRadio.Text = "In-House";
            addPartInHouseRadio.UseVisualStyleBackColor = true;
            addPartInHouseRadio.CheckedChanged += addPartInHouseRadio_CheckedChanged;
            // 
            // addPartOutsourcedRadio
            // 
            addPartOutsourcedRadio.AutoSize = true;
            addPartOutsourcedRadio.Location = new Point(343, 14);
            addPartOutsourcedRadio.Name = "addPartOutsourcedRadio";
            addPartOutsourcedRadio.Size = new Size(120, 27);
            addPartOutsourcedRadio.TabIndex = 2;
            addPartOutsourcedRadio.TabStop = true;
            addPartOutsourcedRadio.Text = "Outsourced";
            addPartOutsourcedRadio.UseVisualStyleBackColor = true;
            addPartOutsourcedRadio.CheckedChanged += addPartOutsourcedRadio_CheckedChanged;
            // 
            // addPartIDLabel
            // 
            addPartIDLabel.AutoSize = true;
            addPartIDLabel.Location = new Point(129, 100);
            addPartIDLabel.Name = "addPartIDLabel";
            addPartIDLabel.Size = new Size(27, 23);
            addPartIDLabel.TabIndex = 3;
            addPartIDLabel.Text = "ID";
            // 
            // addPartIDTextBox
            // 
            addPartIDTextBox.Location = new Point(188, 97);
            addPartIDTextBox.Name = "addPartIDTextBox";
            addPartIDTextBox.ReadOnly = true;
            addPartIDTextBox.Size = new Size(234, 30);
            addPartIDTextBox.TabIndex = 4;
            // 
            // addPartNameTextBox
            // 
            addPartNameTextBox.Location = new Point(188, 146);
            addPartNameTextBox.Name = "addPartNameTextBox";
            addPartNameTextBox.Size = new Size(234, 30);
            addPartNameTextBox.TabIndex = 6;
            // 
            // addPartNameLabel
            // 
            addPartNameLabel.AutoSize = true;
            addPartNameLabel.Location = new Point(100, 149);
            addPartNameLabel.Name = "addPartNameLabel";
            addPartNameLabel.Size = new Size(56, 23);
            addPartNameLabel.TabIndex = 5;
            addPartNameLabel.Text = "Name";
            // 
            // addPartPriceTextBox
            // 
            addPartPriceTextBox.Location = new Point(188, 246);
            addPartPriceTextBox.Name = "addPartPriceTextBox";
            addPartPriceTextBox.Size = new Size(234, 30);
            addPartPriceTextBox.TabIndex = 10;
            // 
            // addPartPriceLabel
            // 
            addPartPriceLabel.AutoSize = true;
            addPartPriceLabel.Location = new Point(58, 249);
            addPartPriceLabel.Name = "addPartPriceLabel";
            addPartPriceLabel.Size = new Size(98, 23);
            addPartPriceLabel.TabIndex = 9;
            addPartPriceLabel.Text = "Price / Cost";
            // 
            // addPartInventoryTextBox
            // 
            addPartInventoryTextBox.Location = new Point(188, 197);
            addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            addPartInventoryTextBox.Size = new Size(234, 30);
            addPartInventoryTextBox.TabIndex = 8;
            // 
            // addPartInventoryLabel
            // 
            addPartInventoryLabel.AutoSize = true;
            addPartInventoryLabel.Location = new Point(74, 200);
            addPartInventoryLabel.Name = "addPartInventoryLabel";
            addPartInventoryLabel.Size = new Size(82, 23);
            addPartInventoryLabel.TabIndex = 7;
            addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartMaxTextBox
            // 
            addPartMaxTextBox.Location = new Point(188, 297);
            addPartMaxTextBox.Name = "addPartMaxTextBox";
            addPartMaxTextBox.Size = new Size(117, 30);
            addPartMaxTextBox.TabIndex = 12;
            // 
            // addPartMaxLabel
            // 
            addPartMaxLabel.AutoSize = true;
            addPartMaxLabel.Location = new Point(114, 300);
            addPartMaxLabel.Name = "addPartMaxLabel";
            addPartMaxLabel.Size = new Size(42, 23);
            addPartMaxLabel.TabIndex = 11;
            addPartMaxLabel.Text = "Max";
            // 
            // addPartMinTextBox
            // 
            addPartMinTextBox.Location = new Point(417, 297);
            addPartMinTextBox.Name = "addPartMinTextBox";
            addPartMinTextBox.Size = new Size(118, 30);
            addPartMinTextBox.TabIndex = 14;
            // 
            // addPartMinLabel
            // 
            addPartMinLabel.AutoSize = true;
            addPartMinLabel.Location = new Point(343, 300);
            addPartMinLabel.Name = "addPartMinLabel";
            addPartMinLabel.Size = new Size(39, 23);
            addPartMinLabel.TabIndex = 13;
            addPartMinLabel.Text = "Min";
            // 
            // addPartMachineIDTextBox
            // 
            addPartMachineIDTextBox.Location = new Point(188, 351);
            addPartMachineIDTextBox.Name = "addPartMachineIDTextBox";
            addPartMachineIDTextBox.Size = new Size(234, 30);
            addPartMachineIDTextBox.TabIndex = 16;
            // 
            // addPartMachineIDLabel
            // 
            addPartMachineIDLabel.AutoSize = true;
            addPartMachineIDLabel.Location = new Point(59, 354);
            addPartMachineIDLabel.Name = "addPartMachineIDLabel";
            addPartMachineIDLabel.Size = new Size(97, 23);
            addPartMachineIDLabel.TabIndex = 15;
            addPartMachineIDLabel.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            addPartSaveButton.Location = new Point(322, 434);
            addPartSaveButton.Name = "addPartSaveButton";
            addPartSaveButton.Size = new Size(90, 44);
            addPartSaveButton.TabIndex = 17;
            addPartSaveButton.Text = "Save";
            addPartSaveButton.UseVisualStyleBackColor = true;
            addPartSaveButton.Click += addPartSaveButton_Click;
            // 
            // addPartCancelButton
            // 
            addPartCancelButton.Location = new Point(445, 434);
            addPartCancelButton.Name = "addPartCancelButton";
            addPartCancelButton.Size = new Size(90, 44);
            addPartCancelButton.TabIndex = 18;
            addPartCancelButton.Text = "Cancel";
            addPartCancelButton.UseVisualStyleBackColor = true;
            addPartCancelButton.Click += addPartCancelButton_Click;
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 517);
            Controls.Add(addPartCancelButton);
            Controls.Add(addPartSaveButton);
            Controls.Add(addPartMachineIDTextBox);
            Controls.Add(addPartMachineIDLabel);
            Controls.Add(addPartMinTextBox);
            Controls.Add(addPartMinLabel);
            Controls.Add(addPartMaxTextBox);
            Controls.Add(addPartMaxLabel);
            Controls.Add(addPartPriceTextBox);
            Controls.Add(addPartPriceLabel);
            Controls.Add(addPartInventoryTextBox);
            Controls.Add(addPartInventoryLabel);
            Controls.Add(addPartNameTextBox);
            Controls.Add(addPartNameLabel);
            Controls.Add(addPartIDTextBox);
            Controls.Add(addPartIDLabel);
            Controls.Add(addPartOutsourcedRadio);
            Controls.Add(addPartInHouseRadio);
            Controls.Add(addPartTitleLabel);
            Font = new Font("Segoe UI", 10F);
            Name = "AddPartForm";
            Text = "Part";
            Load += AddPartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addPartTitleLabel;
        private RadioButton addPartInHouseRadio;
        private RadioButton addPartOutsourcedRadio;
        private Label addPartIDLabel;
        private TextBox addPartIDTextBox;
        private TextBox addPartNameTextBox;
        private Label addPartNameLabel;
        private TextBox addPartPriceTextBox;
        private Label addPartPriceLabel;
        private TextBox addPartInventoryTextBox;
        private Label addPartInventoryLabel;
        private TextBox addPartMaxTextBox;
        private Label addPartMaxLabel;
        private TextBox addPartMinTextBox;
        private Label addPartMinLabel;
        private TextBox addPartMachineIDTextBox;
        private Label addPartMachineIDLabel;
        private Button addPartSaveButton;
        private Button addPartCancelButton;
    }
}