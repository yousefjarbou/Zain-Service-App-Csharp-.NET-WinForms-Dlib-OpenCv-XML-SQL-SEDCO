using System;
using System.Windows.Forms;

namespace ZainCustomerService.Screens
{
    public partial class UC_home : UserControl
    {
        public event EventHandler AddNewCustomerClicked;
        public event EventHandler ServeZainCustomerClicked;

        public UC_home()
        {
            InitializeComponent();
            timeHandling();
            UpdateDateTime(); // Initial update of the time and date
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime(); // Update the time and date on each tick
        }

        private void timeHandling()
        {
            timer1.Tick += new EventHandler(timer1_Tick!);
            timer1.Start(); // Start the timer
        }

        private void UpdateDateTime()
        {
            timeLable.Text = DateTime.Now.ToShortTimeString();
            dateLable.Text = DateTime.Now.ToShortDateString();
        }

        private void addNewCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomerClicked?.Invoke(this, EventArgs.Empty);
        }

        private void serveZainCustomerButton_Click(object sender, EventArgs e)
        {
            ServeZainCustomerClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
