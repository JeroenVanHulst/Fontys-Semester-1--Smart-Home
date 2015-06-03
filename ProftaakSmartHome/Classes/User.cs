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

        public User(int id, string name, string password)
        {
            Id = id;
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
                     .Privileges.Add(Room.GetRoomById((int) reader["roomid"]));
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

                var queryPrivileges = "SELECT * FROM permission WHERE userid=" + user.Id;
                Database.Query = queryPrivileges;

                var readerPrivileges = Database.Command.ExecuteReader();

                while (readerPrivileges.Read())
                {
                    user.Privileges.Add(Room.GetRoomById((int) reader["roomid"]));
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
                    user.Privileges.Add(Room.GetRoomById((int)reader["roomid"]));
                }

                return user;
            }

            Database.CloseConnection();

            return null;
        }

        #endregion
    }
}
