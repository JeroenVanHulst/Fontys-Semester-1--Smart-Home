using System;
using System.Security.Cryptography;
using System.Text;

namespace ProftaakSmartHome.Services
{
    public static class UserService
    {
        public static string ConvertStringToMd5(string password)
        {
            var utfPassword = new UTF8Encoding().GetBytes(password);
            var hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(utfPassword);
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
    }
}
