using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ZainCustomerService.DataManagement.UserManagment
{
    public interface IUserRepository
    {
        public void Add(User user);
        public void Delete(string phoneNumber);
        public List<string> LoadPhoneNumbers();
        public User GetUserByPhoneNumber(string phoneNumber);
        public List<User> LoadUsers(string phone="");
    }
}
