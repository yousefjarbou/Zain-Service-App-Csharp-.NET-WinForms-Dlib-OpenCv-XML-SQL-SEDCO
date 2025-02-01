using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml;
using ZainCustomerService.DataManagement.PackageManagment;
using ZainCustomerService.Screens;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static ZainCustomerService.Constants.FilePaths;
using static ZainCustomerService.Constants.XmlElementNames;

namespace ZainCustomerService.DataManagement.UserManagment
{
    public class XmlUserRepository : IUserRepository
    {
        private readonly PackageManager _packageManager;
        public XmlUserRepository(PackageManager packageManager) // Constructor
        {
            EnsureFileExists();
            _packageManager = packageManager;
        }

        private void EnsureFileExists()
        {
            if (!File.Exists(UsersFilePath))
            {
                CreateXmlFile();
            }
        }

        private void CreateXmlFile()
        {
            XmlDocument xmlDocument = new XmlDocument();

            // Create the XML declaration
            xmlDocument.InsertBefore(xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null), xmlDocument.DocumentElement);

            // Create the userNumbers element
            xmlDocument.AppendChild(xmlDocument.CreateElement(string.Empty, "userNumbers", string.Empty));

            // Save the XML document to the specified file
            xmlDocument.Save(UsersFilePath);
        }

        public void Add(User user)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(UsersFilePath);

            XmlNode userNumbersElement = xmlDocument.DocumentElement;

            List<object> userInfoList = [
                user.PhoneNumber,
                user.FirstName,
                user.LastName,
                user.UserPackage?.Name ?? "N/A",
                user.UserPackage?.MonthlyPrice ?? 0,
                user.UserPackage?.IsPrepaidBool ?? false,
                user.Balance,
                user.ExpiryDate
                ];

            XmlElement userElement = xmlDocument.CreateElement(UserElement);
            userNumbersElement.AppendChild(userElement);

            // Add phone number as an attribute
            XmlAttribute phoneAttr = xmlDocument.CreateAttribute(PhoneNumberElement);
            phoneAttr.Value = user.PhoneNumber;
            userElement.Attributes.Append(phoneAttr);

            string[] infoNames = {PhoneNumberElement,FirstNameElement,LastNameElement,
                PackageElement,PriceElement,IsPrepaidBoolElement,BalanceElement,ExpDateElement };

            int i = 0;
            //var is used her because the return type will be list of Objects
            foreach (var info in userInfoList)
            {
                if (info == userInfoList[0])
                {
                    i++;
                    continue;
                }
                XmlElement elementName = xmlDocument.CreateElement(infoNames[i]);
                string insideInfo = Convert.ToString(info)!;
                elementName.InnerText = insideInfo!;
                userElement.AppendChild(elementName);
                i++;
            }
            xmlDocument.Save(UsersFilePath);
        }

        public User GetUserByPhoneNumber(string phoneNumber)
        {
            
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(UsersFilePath);
            XmlNode userNumbersElement = xmlDocument.DocumentElement!;

            // Find the user element with the specified phone number attribute
            XmlNode userNode = userNumbersElement.SelectSingleNode($"{UserElement}[@{PhoneNumberElement}='{phoneNumber}']")!;
            
            string firstName = userNode[FirstNameElement].InnerText;
            string lastName = userNode[LastNameElement].InnerText;
            string packageName = userNode[PackageElement].InnerText;
            double balance = Convert.ToDouble(userNode[BalanceElement].InnerText);
            string expiryDate = userNode[ExpDateElement].InnerText;

            return new User(phoneNumber, firstName, lastName, balance, expiryDate, _packageManager.GetPackageByName(packageName));
            
        }

        public List<string> LoadPhoneNumbers()
        {
            List<string> phoneNums = new List<string>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(UsersFilePath);
            XmlNode rootElement = xmlDocument.DocumentElement!;

            // Iterate over each user node in the XML
            foreach (XmlNode userNode in rootElement.SelectNodes(UserElement))
            {
                // Get the phoneNumber attribute from each user node
                XmlAttribute phoneNumberAttr = userNode.Attributes[PhoneNumberElement];
                if (phoneNumberAttr != null)
                {
                    phoneNums.Add(phoneNumberAttr.Value);
                }
            }
            return phoneNums;
        }

        public List<User> LoadUsers(string phone = "")
        {
            if (phone == "")
            {
                List<User> users = new List<User>();

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(UsersFilePath);
                XmlNode rootElement = xmlDocument.DocumentElement!;

                foreach (XmlNode userNode in rootElement.SelectNodes(UserElement))
                {
                    string phoneNumber = userNode.Attributes[PhoneNumberElement]?.Value ?? string.Empty;
                    string firstName = userNode[FirstNameElement]?.InnerText ?? string.Empty;
                    string lastName = userNode[LastNameElement]?.InnerText ?? string.Empty;
                    string packageName = userNode[PackageElement]?.InnerText ?? string.Empty;
                    double balance = Convert.ToDouble(userNode[BalanceElement]?.InnerText ?? "0");
                    string expiryDate = userNode[ExpDateElement]?.InnerText ?? string.Empty;

                    User user = new User(phoneNumber, firstName, lastName, balance, expiryDate, _packageManager.GetPackageByName(packageName));

                    users.Add(user);
                }

                return users;
            }
            else
            {
                List<User> matchingUsers = new List<User>();

                if (string.IsNullOrEmpty(phone))
                {
                    return matchingUsers; // Return an empty list if the input is empty
                }

                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(UsersFilePath);
                XmlNode rootElement = xmlDocument.DocumentElement!;

                foreach (XmlNode userNode in rootElement.SelectNodes(UserElement))
                {
                    // Get the phoneNumber attribute from each user node
                    XmlAttribute phoneNumberAttr = userNode.Attributes[PhoneNumberElement];
                    if (phoneNumberAttr != null && phoneNumberAttr.Value.StartsWith(phone))
                    {
                        matchingUsers.Add(GetUserByPhoneNumber(phoneNumberAttr.Value));
                    }
                }

                return matchingUsers;
            }
        }

        public void Delete(string phoneNumber)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(UsersFilePath);
            XmlNode userNumbersElement = xmlDocument.DocumentElement!;

            // Find the user element with the specified phone number attribute
            XmlNode userNode = userNumbersElement.SelectSingleNode($"{UserElement}[@{PhoneNumberElement}='{phoneNumber}']");
            if (userNode != null)
            {
                userNumbersElement.RemoveChild(userNode);
                xmlDocument.Save(UsersFilePath);
            }
        }
    }
}
