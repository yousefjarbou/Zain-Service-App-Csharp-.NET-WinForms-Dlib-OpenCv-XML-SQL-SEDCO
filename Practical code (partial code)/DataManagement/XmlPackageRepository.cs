using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ZainCustomerService.Constants.FilePaths;
using static ZainCustomerService.Constants.XmlElementNames;

namespace ZainCustomerService.DataManagement.PackageManagment
{
    public class XmlPackageRepository : IPackageRepository
    {
        private Dictionary<string, Package> _packages;

        public XmlPackageRepository()
        {
            _packages = new Dictionary<string, Package>();
            EnsureFileExists();
            LoadPackagesFromXml();
        }

        public void EnsureFileExists()
        {
            string directoryPath = Path.GetDirectoryName(PackagesFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(PackagesFilePath))
            {
                CreateDefaultPackageXmlFile();
            }
        }

        public void LoadPackagesFromXml()
        {
            XElement xml = XElement.Load(PackagesFilePath);

            foreach (XElement element in xml.Element(PrePaidElement).Elements())
            {
                Package package = new Package
                {
                    Name = element.Name.LocalName,
                    simPrice = double.Parse(element.Element(SimPriceElement).Value),
                    MonthlyPrice = double.Parse(element.Element(PriceElement).Value),
                    IsPrepaidBool = true
                };
                _packages[package.Name] = package;
            }

            foreach (XElement element in xml.Element(PostPaidElement).Elements())
            {
                Package package = new Package
                {
                    Name = element.Name.LocalName,
                    simPrice = double.Parse(element.Element(SimPriceElement).Value),
                    MonthlyPrice = double.Parse(element.Element(PriceElement).Value),
                    IsPrepaidBool = false
                };
                _packages[package.Name] = package;
            }
        }
        public Dictionary<string, Package> LoadAllPackages()
        {
            return _packages;
        }

        public Package GetPackageByName(string name)
        {
            _packages.TryGetValue(name, out Package package);
            return package;
        }

        public List<string> GetPackageNames(bool isPrepaid)
        {
            List<string> packageNames = new List<string>();
            foreach (Package package in _packages.Values)
            {
                if (package.IsPrepaidBool == isPrepaid)
                {
                    packageNames.Add(package.Name);
                }
            }
            return packageNames;
        }

        private void CreateDefaultPackageXmlFile()
        {
            XElement defaultXmlContent = new XElement("zainPackages",
                new XElement("prePaid",
                    new XElement("Zain8Plus",
                        new XElement("simPrice", 2.5),
                        new XElement("price", 8)
                    ),
                    new XElement("Zain10Plus",
                        new XElement("simPrice", 2.5),
                        new XElement("price", 10)
                    ),
                    new XElement("Zain13_5G",
                        new XElement("simPrice", 5),
                        new XElement("price", 13)
                    ),
                    new XElement("Jeelna7",
                        new XElement("simPrice", 1),
                        new XElement("price", 7)
                    )
                ),
                new XElement("postPaid",
                    new XElement("Jeelna9",
                        new XElement("simPrice", 6),
                        new XElement("price", 9)
                    ),
                    new XElement("Jeelna12",
                        new XElement("simPrice", 6),
                        new XElement("price", 12)
                    ),
                    new XElement("Go11Plus",
                        new XElement("simPrice", 5),
                        new XElement("price", 11)
                    ),
                    new XElement("Go15Plus",
                        new XElement("simPrice", 6),
                        new XElement("price", 15)
                    )
                )
            );

            defaultXmlContent.Save(PackagesFilePath);
        }
    }
}