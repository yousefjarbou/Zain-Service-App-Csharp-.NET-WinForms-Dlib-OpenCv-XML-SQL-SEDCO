using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ZainCustomerService.DataManagement.PackageManagment;

namespace ZainCustomerService.DataManagement.PackageManagment
{
    public interface IPackageRepository
    {
        public Package GetPackageByName(string name);
        public List<string> GetPackageNames(bool isPrepaid);

        public Dictionary<string, Package> LoadAllPackages();
    }
}
