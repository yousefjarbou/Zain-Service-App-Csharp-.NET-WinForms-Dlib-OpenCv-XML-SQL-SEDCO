namespace ZainCustomerService.Screens
{
    partial class EditUserForm
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
            postpaidRadioButton = new RadioButton();
            prepaidRadioButton = new RadioButton();
            addBalanceTextBox = new TextBox();
            label2 = new Label();
            doneCreateNewCustomerButton = new Button();
            monthlyPriceLabelNumber = new Label();
            label10 = new Label();
            simPriceLabelNumber = new Label();
            label5 = new Label();
            packageComboBox = new ComboBox();
            packageLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            SuspendLayout();
            // 
            // postpaidRadioButton
            // 
            postpaidRadioButton.AutoSize = true;
            postpaidRadioButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            postpaidRadioButton.ForeColor = Color.FromArgb(14, 54, 61);
            postpaidRadioButton.Location = new Point(282, 136);
            postpaidRadioButton.Name = "postpaidRadioButton";
            postpaidRadioButton.Size = new Size(139, 41);
            postpaidRadioButton.TabIndex = 62;
            postpaidRadioButton.Text = "Postpaid";
            postpaidRadioButton.UseVisualStyleBackColor = true;
            postpaidRadioButton.CheckedChanged += postpaidRadioButton_CheckedChanged;
            // 
            // prepaidRadioButton
            // 
            prepaidRadioButton.AutoSize = true;
            prepaidRadioButton.Checked = true;
            prepaidRadioButton.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            prepaidRadioButton.ForeColor = Color.FromArgb(14, 54, 61);
            prepaidRadioButton.Location = new Point(147, 136);
            prepaidRadioButton.Name = "prepaidRadioButton";
            prepaidRadioButton.Size = new Size(128, 41);
            prepaidRadioButton.TabIndex = 61;
            prepaidRadioButton.TabStop = true;
            prepaidRadioButton.Text = "Prepaid";
            prepaidRadioButton.UseVisualStyleBackColor = true;
            prepaidRadioButton.CheckedChanged += prepaidRadioButton_CheckedChanged;
            // 
            // addBalanceTextBox
            // 
            addBalanceTextBox.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            addBalanceTextBox.ForeColor = Color.FromArgb(14, 54, 61);
            addBalanceTextBox.Location = new Point(371, 347);
            addBalanceTextBox.MaxLength = 15;
            addBalanceTextBox.Name = "addBalanceTextBox";
            addBalanceTextBox.Size = new Size(113, 43);
            addBalanceTextBox.TabIndex = 60;
            addBalanceTextBox.Text = "0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.FromArgb(14, 54, 61);
            label2.Location = new Point(147, 347);
            label2.Name = "label2";
            label2.Size = new Size(218, 46);
            label2.TabIndex = 59;
            label2.Text = "Balance (JD):";
            // 
            // doneCreateNewCustomerButton
            // 
            doneCreateNewCustomerButton.BackColor = Color.FromArgb(14, 54, 61);
            doneCreateNewCustomerButton.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            doneCreateNewCustomerButton.ForeColor = Color.FromArgb(204, 204, 204);
            doneCreateNewCustomerButton.Location = new Point(331, 450);
            doneCreateNewCustomerButton.Name = "doneCreateNewCustomerButton";
            doneCreateNewCustomerButton.Size = new Size(153, 84);
            doneCreateNewCustomerButton.TabIndex = 58;
            doneCreateNewCustomerButton.Text = "Done";
            doneCreateNewCustomerButton.UseVisualStyleBackColor = false;
            doneCreateNewCustomerButton.Click += doneCreateNewCustomerButton_Click;
            // 
            // monthlyPriceLabelNumber
            // 
            monthlyPriceLabelNumber.AutoSize = true;
            monthlyPriceLabelNumber.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            monthlyPriceLabelNumber.ForeColor = Color.FromArgb(14, 54, 61);
            monthlyPriceLabelNumber.Location = new Point(543, 276);
            monthlyPriceLabelNumber.Name = "monthlyPriceLabelNumber";
            monthlyPriceLabelNumber.Size = new Size(88, 42);
            monthlyPriceLabelNumber.TabIndex = 57;
            monthlyPriceLabelNumber.Text = "10 Jd";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.FromArgb(14, 54, 61);
            label10.Location = new Point(410, 276);
            label10.Name = "label10";
            label10.Size = new Size(141, 42);
            label10.TabIndex = 56;
            label10.Text = "Monthly:";
            // 
            // simPriceLabelNumber
            // 
            simPriceLabelNumber.AutoSize = true;
            simPriceLabelNumber.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            simPriceLabelNumber.ForeColor = Color.FromArgb(14, 54, 61);
            simPriceLabelNumber.Location = new Point(303, 276);
            simPriceLabelNumber.Name = "simPriceLabelNumber";
            simPriceLabelNumber.Size = new Size(101, 42);
            simPriceLabelNumber.TabIndex = 55;
            simPriceLabelNumber.Text = "2.5 JD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(14, 54, 61);
            label5.Location = new Point(147, 276);
            label5.Name = "label5";
            label5.Size = new Size(155, 42);
            label5.TabIndex = 54;
            label5.Text = "SIM price:";
            // 
            // packageComboBox
            // 
            packageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            packageComboBox.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            packageComboBox.ForeColor = Color.FromArgb(14, 54, 61);
            packageComboBox.FormattingEnabled = true;
            packageComboBox.ItemHeight = 32;
            packageComboBox.Location = new Point(301, 210);
            packageComboBox.Name = "packageComboBox";
            packageComboBox.Size = new Size(191, 40);
            packageComboBox.TabIndex = 53;
            packageComboBox.SelectedIndexChanged += packageComboBox_SelectedIndexChanged;
            //
            // packageLabel
            // 
            packageLabel.AutoSize = true;
            packageLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            packageLabel.ForeColor = Color.FromArgb(14, 54, 61);
            packageLabel.Location = new Point(147, 203);
            packageLabel.Name = "packageLabel";
            packageLabel.Size = new Size(155, 46);
            packageLabel.TabIndex = 52;
            packageLabel.Text = "Package:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            lastNameTextBox.ForeColor = Color.FromArgb(14, 54, 61);
            lastNameTextBox.Location = new Point(403, 74);
            lastNameTextBox.MaxLength = 15;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(250, 43);
            lastNameTextBox.TabIndex = 49;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            lastNameLabel.ForeColor = Color.FromArgb(14, 54, 61);
            lastNameLabel.Location = new Point(403, 22);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(183, 46);
            lastNameLabel.TabIndex = 48;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic);
            firstNameTextBox.ForeColor = Color.FromArgb(14, 54, 61);
            firstNameTextBox.Location = new Point(147, 74);
            firstNameTextBox.MaxLength = 15;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(250, 43);
            firstNameTextBox.TabIndex = 47;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            firstNameLabel.ForeColor = Color.FromArgb(14, 54, 61);
            firstNameLabel.Location = new Point(147, 22);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(187, 46);
            firstNameLabel.TabIndex = 46;
            firstNameLabel.Text = "First Name";
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(postpaidRadioButton);
            Controls.Add(prepaidRadioButton);
            Controls.Add(addBalanceTextBox);
            Controls.Add(label2);
            Controls.Add(doneCreateNewCustomerButton);
            Controls.Add(monthlyPriceLabelNumber);
            Controls.Add(label10);
            Controls.Add(simPriceLabelNumber);
            Controls.Add(label5);
            Controls.Add(packageComboBox);
            Controls.Add(packageLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton postpaidRadioButton;
        private RadioButton prepaidRadioButton;
        private TextBox addBalanceTextBox;
        private Label label2;
        private Button doneCreateNewCustomerButton;
        private Label monthlyPriceLabelNumber;
        private Label label10;
        private Label simPriceLabelNumber;
        private Label label5;
        private ComboBox packageComboBox;
        private Label packageLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
    }
}