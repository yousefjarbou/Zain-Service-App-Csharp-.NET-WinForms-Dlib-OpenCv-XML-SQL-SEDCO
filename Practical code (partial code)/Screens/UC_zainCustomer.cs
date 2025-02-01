using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZainCustomerService.DataManagement;
using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.DataManagement.UserManagment;

namespace ZainCustomerService.Screens
{
    public partial class UC_zainCustomer : UserControl
    {
        private readonly UserManager _userManager;
        private readonly PackageManager _packageManager;
        private User _selectedUser;

        public UC_zainCustomer(UserManager userManager, PackageManager packageManager)
        {
            InitializeComponent();
            _userManager = userManager;
            _packageManager = packageManager;
            //userListFlowLayoutPanal.Controls.Clear();
            userListFlowLayoutPanal.FlowDirection = FlowDirection.LeftToRight;
            HideUserInfo();

            ShowAllUsers();

            customerNumberTextBox.KeyDown += CustomerNumberTextBox_KeyDown;
            customerNumberTextBox.TextChanged += CustomerNumberTextBox_TextChanged;
        }

        private void AddUserRow(string phone, string name, string package, string expiryDate, string balance)
        {
            bool isActive;
            if (DateTime.TryParse(expiryDate, out DateTime parsedDate))
            {
                isActive = parsedDate > DateTime.Today;
            }
            else isActive = false;
            UC_UserInfoRow userInfoRow = new UC_UserInfoRow(phone, name, package, isActive, balance);
            userListFlowLayoutPanal.Controls.Add(userInfoRow);
            userInfoRow.BringToFront();

            userInfoRow.UserInfoRowClicked += UserInfoRow_Click;
        }

        private void UserInfoRow_Click(object sender, EventArgs e)
        {
            UC_UserInfoRow userInfoRow = sender as UC_UserInfoRow;
            if (userInfoRow != null)
            {
                string phone = userInfoRow.Phone;
                _selectedUser=_userManager.GetUserByPhoneNumber(phone);
                customerNumberTextBox.Text = phone;
                FillDataInLabels(phone);
                ShowUserInfo();
            }
        }

        private void CustomerNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string phone = customerNumberTextBox.Text;
                if (string.IsNullOrEmpty(phone))
                {
                    ShowAllUsers();
                    HideUserInfo();
                }
                else SearchUserByPhoneNumber(phone);
            }
        }
        private void CustomerNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string phone = customerNumberTextBox.Text;
            if (string.IsNullOrEmpty(phone)) { 
                ShowAllUsers();
                HideUserInfo();
            }
        }

        private void SearchUserByPhoneNumber(string phone)
        {
            userListFlowLayoutPanal.Controls.Clear();

            List<User> matchedUsers = _userManager.SearchMatchedUserByPhoneNumber(phone);
            HideUserInfo();

            foreach (User user in matchedUsers)
            {
                AddUserRow(user.PhoneNumber,user.FirstName+" "+user.LastName, user.UserPackage.Name, user.ExpiryDate, user.Balance.ToString());
            }
        }

        private void ShowAllUsers()
        {
            userListFlowLayoutPanal.Controls.Clear();
            List<User> allUsers = _userManager.LoadAllUsers();

            foreach (User user in allUsers)
            {
                AddUserRow(user.PhoneNumber, user.FirstName+" "+user.LastName, user.UserPackage.Name, user.ExpiryDate, user.Balance.ToString());
            }
        }

        private void HideUserInfo()
        {
            userInfoPanel.Visible = false;
        }

        private void ShowUserInfo()
        {
            FillDataInLabels(_selectedUser.PhoneNumber);
            userInfoPanel.Visible = true;
        }

        private void FillDataInLabels(string phone)
        {
            User user = _userManager.GetUserByPhoneNumber(phone);
            customerNumberTextBox.Text = phone;
            nameLabelInfo.Text = user.FirstName + " " + user.LastName;
            packageLabel.Text = user.UserPackage.Name;
            typeLabel.Text = user.UserPackage.IsPrepaidBool ? "Prepaid" : "Postpaid";
            monthlyPriceLable.Text = user.UserPackage.MonthlyPrice.ToString();
            if (DateTime.TryParse(user.ExpiryDate, out DateTime parsedDate))
            {
                DateTime today = DateTime.Today;
                if (parsedDate > today)
                {
                    activityLabel.Text = "(  Active  )";
                    activityLabel.ForeColor = Color.Green;

                }
                else { 
                    activityLabel.Text = "(Not Active)"; 
                    activityLabel.ForeColor= Color.Red;
                    }
            }
            else
            {
                activityLabel.Text = "(Not Active)";
                activityLabel.ForeColor = Color.Red;
            }

            expiryDateLabel.Text = user.ExpiryDate;
            balanceLabel.Text = user.Balance.ToString();
        }

        private void doneAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(addBalanceTextBox.Text))
                {
                    if (double.TryParse(addBalanceTextBox.Text, out double amount) && amount > 0 && amount < 100)
                    {
                        _selectedUser.Balance += amount;
                        _userManager.UpdateUser(_selectedUser);
                        addBalanceTextBox.Text = string.Empty;

                        // Update only the selected user's row
                        UpdateUserRow(_selectedUser.PhoneNumber);
                        ShowUserInfo();
                    }
                    else
                    {
                        MessageBox.Show("Amount of increase must be a positive number under 100JD");
                    }
                }
                else
                {
                    MessageBox.Show("Balance Value error!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Balance Value error!\n Amount should be a positive number under 100JD");
            }
        }

        private void deleteUserInfoButton_Click(object sender, EventArgs e)
        {
            // Show the confirmation dialog
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the user holding {_selectedUser.PhoneNumber} phone number?",
                $"Delete {_selectedUser.FirstName} {_selectedUser.LastName}'s Account?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                // Proceed with the deletion
                if (_selectedUser != null)
                {
                    _userManager.DeleteUser(_selectedUser.PhoneNumber);
                    customerNumberTextBox.Text = string.Empty;
                    MessageBox.Show("User has been deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No user is selected for deletion.");
                }
            }
        }

        private void editInfoButton_Click(object sender, EventArgs e)
        {
            using (EditUserForm editForm = new EditUserForm(_selectedUser,_userManager, _packageManager))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    addBalanceTextBox.Text = string.Empty;
                    _selectedUser=_userManager.GetUserByPhoneNumber(_selectedUser.PhoneNumber);
                    // Update only the selected user's row
                    UpdateUserRow(_selectedUser.PhoneNumber);
                    ShowUserInfo();
                }
            }
        }

        private void UpdateUserRow(string phoneNumber)
        {
            // Find the user row to update
            UC_UserInfoRow userInfoRowToUpdate = null;

            foreach (UC_UserInfoRow userInfoRow in userListFlowLayoutPanal.Controls)
            {
                if (userInfoRow.Phone == phoneNumber)
                {
                    userInfoRowToUpdate = userInfoRow;
                    break;
                }
            }

            if (userInfoRowToUpdate != null)
            {
                // Remove the old row
                userListFlowLayoutPanal.Controls.Remove(userInfoRowToUpdate);

                // Re-add the updated row
                User updatedUser = _userManager.GetUserByPhoneNumber(phoneNumber);
                AddUserRow(
                    updatedUser.PhoneNumber,
                    updatedUser.FirstName + " " + updatedUser.LastName,
                    updatedUser.UserPackage.Name,
                    updatedUser.ExpiryDate,
                    updatedUser.Balance.ToString()
                );
            }
        }
    }
}