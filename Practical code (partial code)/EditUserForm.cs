using System;
using System.Windows.Forms;
using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.DataManagement;
using ZainCustomerService.DataManagement.UserManagment;

namespace ZainCustomerService.Screens
{
    public partial class EditUserForm : Form
    {
        private ZainCustomerService.DataManagement.User SelectedUser;
        private readonly UserManager _userManager;
        private readonly PackageManager _packageManager;
        private bool IsPrepaid = true;
        private List<string> PackageNamesToBeEdited = new List<string>();

        public EditUserForm(ZainCustomerService.DataManagement.User user,UserManager userManager, PackageManager packageManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _packageManager = packageManager;
            InitializeFields(user);
            PopulatePackageComboBox();
        }

        private void InitializeFields(ZainCustomerService.DataManagement.User user)
        {
            try
            {
                SelectedUser = user;
                firstNameTextBox.Text = user.FirstName;
                lastNameTextBox.Text = user.LastName;
                addBalanceTextBox.Text = user.Balance.ToString();

                var packageNames = _packageManager.GetPackageNames(user.UserPackage.IsPrepaidBool);
                if (packageNames == null || !packageNames.Any())
                {
                    throw new Exception("No _packages found for the given type.");
                }

                packageComboBox.Items.AddRange(packageNames.ToArray());

                if (packageNames.Contains(user.UserPackage.Name))
                {
                    packageComboBox.SelectedItem = user.UserPackage.Name;
                }
                else
                {
                    throw new Exception($"Package '{user.UserPackage.Name}' not found in the available _packages.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing fields: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void doneCreateNewCustomerButton_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateInputs();
            if (errorMessage == "")
            {
                User user = new User(SelectedUser.PhoneNumber,
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                Convert.ToDouble(addBalanceTextBox.Text),
                SelectedUser.ExpiryDate,
                _packageManager.GetPackageByName(packageComboBox.SelectedItem.ToString()));
                _userManager.UpdateUser(user);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateInputs()
        {
            if (TextContainsOnlyLetters(firstNameTextBox.Text))
                return "First name must contain only letters!";


            if (TextContainsOnlyLetters(lastNameTextBox.Text))
                return "Last name must contain only letters!";

            if (IsValidBalance())
                return "Balance must be a number greater than 0 and less than 100!";

            if (packageComboBox.SelectedIndex == -1)
            {
                return "Please select a package!";
            }

            return "";
        }

        private bool IsValidBalance() => (!double.TryParse(addBalanceTextBox.Text, out double balance) || balance < 0 || balance >= 100);

        private bool TextContainsOnlyLetters(string text) => !System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z]+$");

        private void prepaidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IsPrepaid = true;
            PopulatePackageComboBox();
        }

        private void postpaidRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            IsPrepaid = false;
            PopulatePackageComboBox();
        }

        private void PopulatePackageComboBox()
        {
            packageComboBox.Items.Clear();
            PackageNamesToBeEdited = _packageManager.GetPackageNames(IsPrepaid);
            foreach (var packageName in PackageNamesToBeEdited)
            {
                packageComboBox.Items.Add(packageName);
            }
            if (packageComboBox.Items.Count > 0)
            {
                packageComboBox.SelectedIndex = 0; // Set default selection
                simPriceLabelNumber.Text = _packageManager.GetPackageByName(PackageNamesToBeEdited[0]).simPrice.ToString() + " JD";
                monthlyPriceLabelNumber.Text = _packageManager.GetPackageByName(PackageNamesToBeEdited[0]).MonthlyPrice.ToString() + " JD";
            }
        }

        private void packageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (packageComboBox.SelectedIndex >= 0 && packageComboBox.SelectedIndex < PackageNamesToBeEdited.Count)
            {
                simPriceLabelNumber.Text = _packageManager.GetPackageByName(PackageNamesToBeEdited[packageComboBox.SelectedIndex]).simPrice.ToString() + " JD";
                monthlyPriceLabelNumber.Text = _packageManager.GetPackageByName(PackageNamesToBeEdited[packageComboBox.SelectedIndex]).MonthlyPrice.ToString() + " JD";
            }
            else
            {
                simPriceLabelNumber.Text = "N/A";
                monthlyPriceLabelNumber.Text = "N/A";
            }
        }
    }
}