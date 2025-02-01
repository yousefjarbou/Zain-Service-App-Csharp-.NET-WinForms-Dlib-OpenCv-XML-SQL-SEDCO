using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZainCustomerService.DataManagement.PackageManagment;

namespace ZainCustomerService.DataManagement.UserManagment
{
    public class UserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly PackageManager _packageManager;

        public UserManager(IUserRepository userManager,PackageManager packageManager)
        {
            _userRepository = userManager;
            _packageManager = packageManager;
        }

        public void CreateUser(string phoneNumber, string firstName, string lastName, double balance, string expiryDate, string packageName)
        {
            User newUser = new User(phoneNumber, firstName, lastName, balance, expiryDate, _packageManager.GetPackageByName(packageName));
            _userRepository.Add(newUser);
        }

        public bool IsUserRegistered(string phoneNumber)
        {
            List<string> phonNumbers = _userRepository.LoadPhoneNumbers();
            return phonNumbers.Contains(phoneNumber);
        }

        public User GetUserByPhoneNumber(string phoneNumber)
        {
            return _userRepository.GetUserByPhoneNumber(phoneNumber);
        }


        public List<User> LoadAllUsers()
        {
            return _userRepository.LoadUsers();
        }

        public void UpdateUser(User selectedUser)
        {
            _userRepository.Delete(selectedUser.PhoneNumber);
            _userRepository.Add(selectedUser);
        }

        public List<User> SearchMatchedUserByPhoneNumber(string phone)
        {
            return _userRepository.LoadUsers(phone);
        }

        public void DeleteUser(string phoneNumber)
        {
            _userRepository.Delete(phoneNumber);
        }

        public static void CheckIfUserActive(ref string expiryDate, ref double balance, double monthlyPrice)
        {
            if (DateTime.TryParse(expiryDate, out DateTime parsedDate))
            {
                DateTime today = DateTime.Today;
                if (parsedDate <= today && balance >= monthlyPrice)
                {
                    balance-=monthlyPrice;
                    DateTime nextMonthDate = DateTime.Now.AddMonths(1);
                    expiryDate= nextMonthDate.ToShortDateString();
                }
            }
            else if (balance >= monthlyPrice)
            {
                balance -= monthlyPrice;
                DateTime nextMonthDate = DateTime.Now.AddMonths(1);
                expiryDate= nextMonthDate.ToShortDateString();
            }
        }
    }
}


