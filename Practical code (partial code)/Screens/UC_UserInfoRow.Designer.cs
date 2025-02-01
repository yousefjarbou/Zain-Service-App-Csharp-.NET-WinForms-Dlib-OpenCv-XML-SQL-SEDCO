namespace ZainCustomerService.Screens
{
    partial class UC_UserInfoRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fullNameLabel = new Label();
            packageLabel = new Label();
            activeOrNotPicture = new PictureBox();
            BalanceLabel = new Label();
            phoneNumberLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)activeOrNotPicture).BeginInit();
            SuspendLayout();
            // 
            // fullNameLabel
            // 
            fullNameLabel.Dock = DockStyle.Left;
            fullNameLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            fullNameLabel.ForeColor = Color.FromArgb(14, 54, 61);
            fullNameLabel.Location = new Point(250, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(300, 50);
            fullNameLabel.TabIndex = 45;
            fullNameLabel.Text = "Yousef Jarbou";
            fullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // packageLabel
            // 
            packageLabel.Dock = DockStyle.Left;
            packageLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            packageLabel.ForeColor = Color.FromArgb(14, 54, 61);
            packageLabel.Location = new Point(550, 0);
            packageLabel.Name = "packageLabel";
            packageLabel.Size = new Size(300, 50);
            packageLabel.TabIndex = 46;
            packageLabel.Text = "Mix 3.5";
            packageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // activeOrNotPicture
            // 
            activeOrNotPicture.Image = Properties.Resources.activePic;
            activeOrNotPicture.Location = new Point(863, 0);
            activeOrNotPicture.Name = "activeOrNotPicture";
            activeOrNotPicture.Size = new Size(50, 50);
            activeOrNotPicture.SizeMode = PictureBoxSizeMode.Zoom;
            activeOrNotPicture.TabIndex = 49;
            activeOrNotPicture.TabStop = false;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Dock = DockStyle.Right;
            BalanceLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            BalanceLabel.ForeColor = Color.FromArgb(14, 54, 61);
            BalanceLabel.Location = new Point(943, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(250, 50);
            BalanceLabel.TabIndex = 48;
            BalanceLabel.Text = "30";
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Dock = DockStyle.Left;
            phoneNumberLabel.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold | FontStyle.Italic);
            phoneNumberLabel.ForeColor = Color.FromArgb(14, 54, 61);
            phoneNumberLabel.Location = new Point(0, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(250, 50);
            phoneNumberLabel.TabIndex = 50;
            phoneNumberLabel.Text = "0796615878";
            phoneNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_UserInfoRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(activeOrNotPicture);
            Controls.Add(packageLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(phoneNumberLabel);
            Name = "UC_UserInfoRow";
            Size = new Size(1193, 50);
            ((System.ComponentModel.ISupportInitialize)activeOrNotPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Label fullNameLabel;
        public Label packageLabel;
        public PictureBox activeOrNotPicture;
        public Label BalanceLabel;
        public Label phoneNumberLabel;
    }
}
