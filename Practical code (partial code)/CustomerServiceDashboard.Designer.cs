namespace ZainCustomerService
{
    partial class CustomerServiceDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerServiceDashboard));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            zainCustomerButton = new Button();
            newCustomerButton = new Button();
            homeButton = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 54, 61);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(204, 204, 204);
            label1.Location = new Point(145, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 1;
            label1.Text = "Customer Service";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zain_logo;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(newCustomerButton);
            panel2.Controls.Add(zainCustomerButton);
            panel2.Controls.Add(homeButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1680, 63);
            panel2.TabIndex = 1;
            // 
            // zainCustomerButton
            // 
            zainCustomerButton.Cursor = Cursors.Hand;
            zainCustomerButton.Dock = DockStyle.Right;
            zainCustomerButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zainCustomerButton.ForeColor = Color.FromArgb(14, 54, 61);
            zainCustomerButton.Location = new Point(1120, 0);
            zainCustomerButton.Name = "zainCustomerButton";
            zainCustomerButton.Size = new Size(560, 63);
            zainCustomerButton.TabIndex = 3;
            zainCustomerButton.Text = "Zain Customer";
            zainCustomerButton.UseVisualStyleBackColor = true;
            zainCustomerButton.Click += zainCustomerButton_Click;
            // 
            // newCustomerButton
            // 
            newCustomerButton.Cursor = Cursors.Hand;
            newCustomerButton.Dock = DockStyle.Left;
            newCustomerButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newCustomerButton.ForeColor = Color.FromArgb(14, 54, 61);
            newCustomerButton.Location = new Point(560, 0);
            newCustomerButton.Name = "newCustomerButton";
            newCustomerButton.Size = new Size(560, 63);
            newCustomerButton.TabIndex = 2;
            newCustomerButton.Text = "New Customer";
            newCustomerButton.UseVisualStyleBackColor = true;
            newCustomerButton.Click += newCustomerButton_Click;
            // 
            // homeButton
            // 
            homeButton.Cursor = Cursors.Hand;
            homeButton.Dock = DockStyle.Left;
            homeButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeButton.ForeColor = Color.FromArgb(14, 54, 61);
            homeButton.Location = new Point(0, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(560, 63);
            homeButton.TabIndex = 0;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 125);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1680, 902);
            panelContainer.TabIndex = 2;
            //panelContainer.Paint += panelContainer_Paint;
            // 
            // CustomerServiceDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1680, 1027);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerServiceDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zain Customer Service";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Button homeButton;
        private Panel panelContainer;
        private Button zainCustomerButton;
        private Button newCustomerButton;
    }
}
