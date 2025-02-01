using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.DataManagement.UserManagment;

namespace ZainCustomerService.DataManagement
{
    /// <summary>
    /// This class holds information for a single Customer who has a Zain SIM Card.
    /// </summary>
    public class User
    {
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public string ExpiryDate { get; set; }
        public Package UserPackage { get; private set; }

        //constructor ^_^
        public User(string phone, string firstName, string lastName, double balance, string expiryDate, Package package)
        {
            UserManager.CheckIfUserActive(ref expiryDate, ref balance, package.MonthlyPrice);
            PhoneNumber = phone;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            ExpiryDate = expiryDate;
            UserPackage = package;
        }
    }
}


