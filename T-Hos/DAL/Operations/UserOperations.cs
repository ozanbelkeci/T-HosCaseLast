using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Operations
{
    public class UserOperations
    {
        private static UserOperations instance = null;

        public static UserOperations GetInstance()
        {
            if (instance == null)
                instance = new UserOperations();
            return instance;
        }

        public User CreateUser(string _name, string _surname, string _userName, string _password)
        {
            string randomSalt = GenerateSalt();
            byte[] hashedPass = GetHash(_password, randomSalt);
            string base64Pass = Convert.ToBase64String(hashedPass);

            User user = new User();
            user.Name = _name;
            user.Surname = _surname;
            user.Username = _userName;
            user.HashPassword = base64Pass;
            user.SaltPassword = randomSalt;



            return user;
        }

        public string GenerateSalt()
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            return Convert.ToBase64String(salt);
        }

        public byte[] GetHash(string _plainPassword, string _salt)
        {
            byte[] byteArr = Encoding.Unicode.GetBytes(String.Concat(_salt, _plainPassword));
            SHA256Managed sha256 = new SHA256Managed();
            byte[] hashedBytes = sha256.ComputeHash(byteArr);
            return hashedBytes;
        }

        public bool CompareHashedPassword(string _userInputPass, string _existingHashedPass, string _salt)
        {
            string userHashedPass = Convert.ToBase64String(GetHash(_userInputPass, _salt));
            return _existingHashedPass == userHashedPass;
        }

        public bool LoginAuthenticateUser(string _username, string _password)
        {
            using (var context = new DataContext())
            {
                var user = context.Users.Where(x => x.Username == _username).FirstOrDefault();
                if (user != null)
                {
                    var userSalt = user.SaltPassword;
                    var userPassword = user.HashPassword;
                    
                    return CompareHashedPassword(_password, userPassword, userSalt);
                }
                return false;
            }
        }

        //public bool CompareHashedPassword(string _reqPassword, string _userPassword, string _userSalt)
        //{
        //    return false;
        //}
    }
}
