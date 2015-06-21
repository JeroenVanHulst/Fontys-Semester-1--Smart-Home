using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ProftaakSmartHome.Interfaces;
using ProftaakSmartHome.Services;

namespace ProftaakSmartHome.Classes
{
    public class User : IDatabaseObject
    {
        [Browsable(false)]
        public int Id { get; set; }

        public string Name { get; set; }

        private string _password;

        [PasswordPropertyText(true)]
        public string Password
        {
            get { return _password; }
            set { _password = UserService.ConvertStringToMd5(value); }
        }

        [Browsable(false)]
        public List<Group> Privileges { get; set; }

        public bool IsAdmin { get; set; }

        public User(string name)
        {
            Name = name;
            Privileges = new List<Group>();
        }

        public User(string name, string password)
        {
            Name = name;
            _password = password;
            Privileges = new List<Group>();
        }

        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            _password = password;
            Privileges = new List<Group>();
        }

        public void SetPassword(string password)
        {
            Password = UserService.ConvertStringToMd5(password);
        }

        #region Database Queries

        public void Update()
        {
            var query = string.Format("UPDATE user SET username = '{0}', password = '{1}', admin = {2} WHERE userid = {3}", Name, Password, Convert.ToInt32(IsAdmin), Id);
            Database.Query = query;

            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();
        }

        public bool Remove()
        {
            var query = "DELETE FROM user WHERE userid=" + Id;
            Database.Query = query;

            try
            {
                Database.OpenConnection();
                Database.Command.ExecuteNonQuery();
                Database.CloseConnection();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Insert()
        {
            var query = "INSERT INTO user (username, password, admin) VALUES ('" + Name + "', '" + Password + "', " + Convert.ToInt32(IsAdmin) + ")";
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
                var user = new User(Convert.ToInt32(reader["userid"]), reader["username"].ToString(), reader["password"].ToString())
                {
                    IsAdmin = Convert.ToBoolean(reader["admin"])
                };
                users.Add(user);
            }

            var queryPrivileges = "SELECT * FROM permission";
            Database.Query = queryPrivileges;

            reader = Database.Command.ExecuteReader();
            while (reader.Read())
            {
                users.First(x => x.Id == (int) reader["userid"])
                     .Privileges.Add(Group.GetGroupById(Convert.ToInt32(reader["groupid"])));
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
            reader.Read();
            if(reader.HasRows)
            {
                user = new User(Convert.ToInt32(reader["userid"]), reader["username"].ToString(), reader["password"].ToString())
                {
                    IsAdmin = Convert.ToBoolean(reader["admin"])
                };

                var queryPrivileges = "SELECT * FROM permission WHERE userid = " + user.Id;
                Database.Query = queryPrivileges;

                var readerPrivileges = Database.Command.ExecuteReader();

                while (readerPrivileges.Read())
                {
                    user.Privileges.Add(Group.GetGroupById(Convert.ToInt32(reader["groupid"])));
                }

                Database.CloseConnection();
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
            reader.Read();

            if (reader.HasRows)
            {
                user = new User(Convert.ToInt32(reader["userid"]), reader["username"].ToString(), reader["password"].ToString())
                {
                    IsAdmin = Convert.ToBoolean(reader["admin"])
                };

                var queryPrivileges = "SELECT * FROM permission WHERE userid=" + user.Id;
                Database.Query = queryPrivileges;

                var readerPrivileges = Database.Command.ExecuteReader();
                Database.OpenConnection();
                while (readerPrivileges.Read())
                {
                    if (user.Privileges == null) user.Privileges = new List<Group>();
                    user.Privileges.Add(Group.GetGroupById(Convert.ToInt32(readerPrivileges["groupid"])));
                }

                return user;
            }

            Database.CloseConnection();

            return null;
        }

        public void UpdatePrivilages()
        {
            var deleteQuery = "DELETE FROM permission WHERE userid = " + Id;
            Database.Query = deleteQuery;
            Database.OpenConnection();
            Database.Command.ExecuteNonQuery();
            Database.CloseConnection();

            foreach (var permission in Privileges)
            {
                var query = string.Format("INSERT INTO permission VALUES ({0}, {1})", permission.Id, Id);
                Database.Query = query;
                Database.OpenConnection();
                Database.Command.ExecuteNonQuery();
                Database.CloseConnection();
            }
        }

        #endregion
    }
}
