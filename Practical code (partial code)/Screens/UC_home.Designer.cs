namespace ZainCustomerService.Screens
{
    partial class UC_home
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
            components = new System.ComponentModel.Container();
            timeLable = new Label();
            dateLable = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            addNewCustomerButton = new Button();
            serveZainCustomerButton = new Button();
            SuspendLayout();
            // 
            // timeLable
            // 
            timeLable.AutoSize = true;
            timeLable.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLable.ForeColor = Color.FromArgb(14, 54, 61);
            timeLable.Location = new Point(736, 74);
            timeLable.Name = "timeLable";
            timeLable.Size = new Size(174, 86);
            timeLable.TabIndex = 2;
            timeLable.Text = "time";
            timeLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateLable
            // 
            dateLable.AutoSize = true;
            dateLable.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLable.ForeColor = Color.FromArgb(14, 54, 61);
            dateLable.Location = new Point(744, 173);
            dateLable.Name = "dateLable";
            dateLable.Size = new Size(129, 65);
            dateLable.TabIndex = 3;
            dateLable.Text = "date";
            dateLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // addNewCustomerButton
            // 
            addNewCustomerButton.BackColor = SystemColors.ButtonFace;
            addNewCustomerButton.Cursor = Cursors.Hand;
            addNewCustomerButton.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            addNewCustomerButton.ForeColor = Color.FromArgb(14, 54, 61);
            addNewCustomerButton.Location = new Point(400, 400);
            addNewCustomerButton.Name = "addNewCustomerButton";
            addNewCustomerButton.Size = new Size(350, 200);
            addNewCustomerButton.TabIndex = 4;
            addNewCustomerButton.Text = "Add New Customer";
            addNewCustomerButton.UseVisualStyleBackColor = false;
            addNewCustomerButton.Click += addNewCustomerButton_Click;
            // 
            // serveZainCustomerButton
            // 
            serveZainCustomerButton.BackColor = SystemColors.ButtonFace;
            serveZainCustomerButton.Cursor = Cursors.Hand;
            serveZainCustomerButton.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold | FontStyle.Italic);
            serveZainCustomerButton.ForeColor = Color.FromArgb(14, 54, 61);
            serveZainCustomerButton.Location = new Point(930, 400);
            serveZainCustomerButton.Name = "serveZainCustomerButton";
            serveZainCustomerButton.Size = new Size(377, 200);
            serveZainCustomerButton.TabIndex = 5;
            serveZainCustomerButton.Text = "Serve Zain Customer";
            serveZainCustomerButton.UseVisualStyleBackColor = false;
            serveZainCustomerButton.Click += serveZainCustomerButton_Click;
            // 
            // UC_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(serveZainCustomerButton);
            Controls.Add(addNewCustomerButton);
            Controls.Add(dateLable);
            Controls.Add(timeLable);
            Name = "UC_home";
            Size = new Size(1680, 902);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLable;
        private Label dateLable;
        private System.Windows.Forms.Timer timer1;
        private Button addNewCustomerButton;
        private Button serveZainCustomerButton;
    }
}
