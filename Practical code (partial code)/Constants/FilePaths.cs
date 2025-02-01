using System;
using System.IO;

namespace ZainCustomerService.Constants
{
    public static class FilePaths
    {
        private static readonly string BaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "XML local Data Files");

        public static readonly string UsersFilePath = Path.Combine(BaseDirectory, "zainUsers.xml");
        public static readonly string PackagesFilePath = Path.Combine(BaseDirectory, "packages.xml");

        static FilePaths()
        {
            // Ensure that the directory exists
            Directory.CreateDirectory(BaseDirectory);
        }
    }
}
