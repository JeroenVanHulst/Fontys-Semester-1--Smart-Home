using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProftaakSmartHome.Services;

namespace ProftaakSmartHome.Classes
{
    public class User : IDatabaseObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; private set; }

        public List<Room> Privileges { get; set; }

        public bool IsAdmin { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void SetPassword(string password)
        {
            Password = UserService.ConvertStringToMd5(password);
        }

        #region Database Querys

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public static List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public static User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public static User GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
