using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.DataManagement.UserManagment;
using LivePersonDetectionLibrary;


namespace ZainCustomerService.Screens
{
    public partial class UC_newCustomer : UserControl
    {
        private readonly UserManager _userManager;
        private readonly PackageManager _packageManager;
        private bool _isPackagePrepaid = true;
        private List<string> _availablePackageNames = new List<string>();
        public UC_newCustomer(UserManager userManager,PackageManager packageManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _packageManager = packageManager;
            InitializeLabels();
            PopulatePackageComboBox();
        }

        private void DoneCreateNewCustomerButton_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            if (ValidateInput(out errorMessage))
            {
                var detector = new LivePersonDetector();
                bool isRealPerson = detector.StartDetection(15, 5, 0.45);
                if (isRealPerson) {
                    AddNewCustomer();
                    ClearAllFields();
                    MessageBox.Show("New User Has Been Created");
                }
                else {
                    MessageBox.Show("Show Real Person Face on the camera!!", "No Live Face Detected!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                //pop-up errorMsg
                MessageBox.Show(errorMessage, "User Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearAllFields()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            assignNewNumberTextBox.Clear();
            addBalanceTextBox.Clear();
            simPriceLabelNumber.Text = "";
            monthlyPriceLabelNumber.Text = "";
            packageComboBox.SelectedIndex = 0;
        }

        private void AddNewCustomer()
        {
            DateTime currentDate = DateTime.Now;
            DateTime nextMonthDate = currentDate.AddMonths(1);
            
            _userManager.CreateUser(
                "079" + assignNewNumberTextBox.Text,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                Convert.ToDouble(addBalanceTextBox.Text),
                nextMonthDate.ToShortDateString(),
                packageComboBox.SelectedItem.ToString());
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = "";
            if (IsAllFieldsEmpty())
                errorMessage = "All fields must be filled!";

            else if (PhoneNumberExists())
                errorMessage = "Number already assigned to an existing user!";

            else if (Is7digits())
                errorMessage = "Phone number must be in total 10 Numbers (including 079)\nSo please just enter 7 digits";
            else
            {
                if (TextContainsOnlyLetters(firstNameTextBox.Text))
                    errorMessage = "First name must contain only letters!\n";


                if (TextContainsOnlyLetters(lastNameTextBox.Text))
                    errorMessage += "Last name must contain only letters!\n";

                if (IsValidBalance())
                    errorMessage += "Balance must be a number greater than 0 and less than 100!";
            }
            return errorMessage == "";
        }

        private bool IsValidBalance()=>(!double.TryParse(addBalanceTextBox.Text, out double balance) || balance < 0 || balance >= 100);

        private bool TextContainsOnlyLetters(string text)=>!System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z]+$");

        private bool Is7digits()=>!System.Text.RegularExpressions.Regex.IsMatch(assignNewNumberTextBox.Text, @"\d{7}$");
        
        private bool PhoneNumberExists()=> _userManager != null && _userManager.IsUserRegistered("079" + assignNewNumberTextBox.Text);
        
        private bool IsAllFieldsEmpty()
        {
            return (string.IsNullOrEmpty(assignNewNumberTextBox?.Text) ||
                string.IsNullOrEmpty(firstNameTextBox?.Text) ||
                string.IsNullOrEmpty(lastNameTextBox?.Text) ||
                string.IsNullOrEmpty(addBalanceTextBox?.Text));
        }

        private void packageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            simPriceLabelNumber.Text = _packageManager.GetPackageByName(_availablePackageNames[packageComboBox.SelectedIndex]).simPrice.ToString() + " JD";
            monthlyPriceLabelNumber.Text = _packageManager.GetPackageByName(_availablePackageNames[packageComboBox.SelectedIndex]).MonthlyPrice.ToString() + " JD";
        }

        private void prepaidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isPackagePrepaid = true;
            PopulatePackageComboBox();
        }

        private void postpaidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _isPackagePrepaid = false;
            PopulatePackageComboBox();
        }

        private void PopulatePackageComboBox()
        {//Fill ComboBox (dropDown menu) from XML Packages
            packageComboBox.Items.Clear();
            _availablePackageNames = _packageManager.GetPackageNames(_isPackagePrepaid);
            foreach (string packageName in _availablePackageNames)
            {
                packageComboBox.Items.Add(packageName);
            }
            packageComboBox.SelectedIndex = 0; // Set default selection
            simPriceLabelNumber.Text = _packageManager.GetPackageByName(_availablePackageNames[0]).simPrice.ToString() + " JD";
            monthlyPriceLabelNumber.Text = _packageManager.GetPackageByName(_availablePackageNames[0]).MonthlyPrice.ToString() + " JD";
        }

        private void InitializeLabels()
        {
            simPriceLabelNumber.Text = "";
            monthlyPriceLabelNumber.Text = "";
            DateTime currentDate = DateTime.Now;
            DateTime nextMonthDate = currentDate.AddMonths(1);
            string nextMonthDateString = nextMonthDate.ToString("dd/MM/yyyy") + " (one month from now)";
            expiryDateLabel.Text = nextMonthDateString;
        }

    }
}
