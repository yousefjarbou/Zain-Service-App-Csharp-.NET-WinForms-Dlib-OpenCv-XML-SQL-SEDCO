using System;
using System.Windows.Forms;

namespace ZainCustomerService.Screens
{
    public partial class UC_UserInfoRow : UserControl
    {
        public string Phone { get; private set; }

        public UC_UserInfoRow()
        {
            InitializeComponent();
        }

        public UC_UserInfoRow(string phone, string name, string package, bool isActive, string balance)
        {
            InitializeComponent();
            Phone = phone;
            phoneNumberLabel.Text = phone;
            fullNameLabel.Text = name;
            packageLabel.Text = package;
            if (isActive)
            {
                activeOrNotPicture.Image = ZainCustomerService.Properties.Resources.activePic;
            }
            else
            {
                activeOrNotPicture.Image = ZainCustomerService.Properties.Resources.notActivePic;
            }
            BalanceLabel.Text = balance;

            // Ensure child controls don't handle the click events
            foreach (Control control in Controls)
            {
                control.Click += (sender, e) => OnClick(e);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            // Fire a custom event or handle the click here
            UserInfoRowClicked?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler UserInfoRowClicked;
    }
}
