using ZainCustomerService.DataManagement;
using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.DataManagement.UserManagment;
using ZainCustomerService.Screens;

namespace ZainCustomerService
{
    public partial class CustomerServiceDashboard : Form
    {
        private readonly UserManager _userManager; // Declare the UserManager
        private readonly PackageManager _packageManager;
        public CustomerServiceDashboard()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _packageManager = new PackageManager(new XmlPackageRepository());
            // Initialize the UserManager with an instance of XmlUserRepository
            _userManager = new UserManager(new XmlUserRepository(_packageManager),_packageManager);

            UC_home homeScreen = new UC_home();
            homeScreen.AddNewCustomerClicked += HomeScreen_AddNewCustomerClicked;
            homeScreen.ServeZainCustomerClicked += HomeScreen_ServeZainCustomerClicked;
            AddUserControl(homeScreen);
            SelectedButtonStyle(homeButton);
        }

        private void AddUserControl(UserControl screen)
        {
            screen.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(screen);
            screen.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            UC_home homeScreen = new UC_home();
            homeScreen.AddNewCustomerClicked += HomeScreen_AddNewCustomerClicked;
            homeScreen.ServeZainCustomerClicked += HomeScreen_ServeZainCustomerClicked;
            SelectedButtonStyle(homeButton);
            AddUserControl(homeScreen);
        }

        private void newCustomerButton_Click(object sender, EventArgs e)
        {
            UC_newCustomer newCustomerScreen = new UC_newCustomer(_userManager,_packageManager);
            SelectedButtonStyle(newCustomerButton);
            AddUserControl(newCustomerScreen);
        }

        private void zainCustomerButton_Click(object sender, EventArgs e)
        {
            UC_zainCustomer zainCustomerScreen = new UC_zainCustomer(_userManager, _packageManager);
            SelectedButtonStyle(zainCustomerButton);
            AddUserControl(zainCustomerScreen);
        }



        private void SelectedButtonStyle(Button activeButton)
        {
            foreach (Button button in new[] { homeButton, newCustomerButton, zainCustomerButton })
            {
                if (button == activeButton)
                {
                    button.BackColor = ColorTranslator.FromHtml("#cccccc");
                }
                else
                {
                    button.BackColor = Color.White;
                }
            }
        }

        private void HomeScreen_AddNewCustomerClicked(object sender, EventArgs e)
        {
            newCustomerButton.PerformClick();
        }

        private void HomeScreen_ServeZainCustomerClicked(object sender, EventArgs e)
        {
            zainCustomerButton.PerformClick();
        }
    }
}
