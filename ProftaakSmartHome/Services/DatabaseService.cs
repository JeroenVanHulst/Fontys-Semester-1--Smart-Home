using System;
using System.IO;
using System.Security.Cryptography;
using ProftaakSmartHome.Classes;

namespace ProftaakSmartHome.Services
{
    public static class DatabaseService
    {
        /// <summary>
        /// Checks and returns the MD5 checksum of the file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Guid GetMd5HashFromFile(string filename)
        {
            using (var stream = File.OpenRead(Database.Filename))
            {
                var md5 = new MD5CryptoServiceProvider();
                var retVal = md5.ComputeHash(stream);
                stream.Close();
                return new Guid(retVal);
            }
        }
    }
}
