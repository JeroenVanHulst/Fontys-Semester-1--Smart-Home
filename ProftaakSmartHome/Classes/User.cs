using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProftaakSmartHome.Interfaces;
using ProftaakSmartHome.Services;

namespace ProftaakSmartHome.Classes
{
    public class User : IDatabaseObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = UserService.ConvertStringToMd5(value); }
        }

        public List<Group> Privileges { get; set; }

        public bool IsAdmin { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public User(string name, string password)
        {
            Name = name;
            _password = password;
        }

        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            _password = password;
        }

        public void SetPassword(string password)
        {
            Password = UserService.ConvertStringToMd5(password);
        }

        #region Database Querys

        public void Update()
        {
            var query = "UPDATE user SET username = '" + Name + "', password =" + Password;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Remove()
        {
            var query = "DELETE FROM user WHERE userid=" + Id;
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public void Insert()
        {
            var query = "INSERT INTO user (username, password) VALUES ('" + Name + "', '" + Password + "')";
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public static List<User> GetAllUsers()
        {
            var queryUsers = "SELECT * FROM user";
            var users = new List<User>();

            Database.Query = queryUsers;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();
            while (reader.Read())
            {
                var user = new User((int) reader["userid"], reader["username"].ToString(), reader["password"].ToString());
                users.Add(user);
            }

            var queryPrivileges = "SELECT * FROM permission";
            Database.Query = queryPrivileges;

            reader = Database.Command.ExecuteReader();
            while (reader.Read())
            {
                users.First(x => x.Id == (int) reader["userid"])
                     .Privileges.Add(Group.GetGroupById((int) reader["groupid"]));
            }

            Database.CloseConnection();

            return users;
        }

        public static User GetUserById(int id)
        {
            var queryUsers = "SELECT * FROM user WHERE userid="+id;
            User user;

            Database.Query = queryUsers;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();
            if(reader.HasRows)
            {
                user = new User((int)reader["userid"], reader["username"].ToString(), reader["password"].ToString());

                var queryPrivileges = "SELECT * FROM permission WHERE userid = " + user.Id;
                Database.Query = queryPrivileges;

                var readerPrivileges = Database.Command.ExecuteReader();

                while (readerPrivileges.Read())
                {
                    user.Privileges.Add(Group.GetGroupById((int) reader["groupid"]));
                }

                return user;
            }

            Database.CloseConnection();

            return null;
        }

        public static User GetUserByName(string name)
        {
            var queryUsers = "SELECT * FROM user WHERE username='" + name + "'";
            User user;

            Database.Query = queryUsers;
            Database.OpenConnection();

            var reader = Database.Command.ExecuteReader();
            if (reader.HasRows)
            {
                user = new User((int)reader["userid"], reader["username"].ToString(), reader["password"].ToString());

                var queryPrivileges = "SELECT * FROM permission WHERE userid=" + user.Id;
                Database.Query = queryPrivileges;

                var readerPrivileges = Database.Command.ExecuteReader();

                while (readerPrivileges.Read())
                {
                    user.Privileges.Add(Group.GetGroupById((int)reader["groupid"]));
                }

                return user;
            }

            Database.CloseConnection();

            return null;
        }

        #endregion
    }
}
