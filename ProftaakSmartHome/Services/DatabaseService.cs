using System;
using System.IO;
using System.Security.Cryptography;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Services
{
    public static class DatabaseService
    {
        /// <summary>
        /// Checks and returns the 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Guid GetMd5HashFromFile(string filename)
        {
            using (var stream = File.Open(Database.Filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var md5 = new MD5CryptoServiceProvider();
                var retVal = md5.ComputeHash(stream);
                stream.Close();
                return new Guid(retVal);
            }
        }
    }
}
