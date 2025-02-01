using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using ZainCustomerService.DataManagement.UserManagment;
using static ZainCustomerService.Constants.FilePaths;
using static ZainCustomerService.Constants.XmlElementNames;

namespace ZainCustomerService.DataManagement.PackageManagment
{
    public class PackageManager 
    {
        private Dictionary<string, Package> _packages;
        private readonly IPackageRepository _packageRepository;

        public PackageManager(IPackageRepository packageManager)
        {
            _packageRepository = packageManager;
            _packages = _packageRepository.LoadAllPackages();
        }

        public Package GetPackageByName(string name)
        {
            return _packageRepository.GetPackageByName(name);
        }

        public List<string> GetPackageNames(bool isPrepaid)
        {
            return _packageRepository.GetPackageNames(isPrepaid);
        }

    }
}
