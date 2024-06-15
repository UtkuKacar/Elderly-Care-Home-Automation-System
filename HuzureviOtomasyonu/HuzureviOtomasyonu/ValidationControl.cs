using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuzureviOtomasyonu
{
    internal class ValidationControl
    {
        public static readonly int PASSWORD_MIN_CHAR = 8;
        public static readonly int USERNAME_MIN_CHAR = 3;

        /// <summary>
        /// Parametre olarak gelen parolanın geçerli olup olmadığını verir
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool PasswordCheck(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < PASSWORD_MIN_CHAR)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Parametre olarak gelen kullanıcı adının geçerli olup olmadığını verir
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool UsernameCheck(string username)
        {
            if (string.IsNullOrEmpty(username) || username.Length < USERNAME_MIN_CHAR)
            {
                return false;
            }

            return true;
        }
        
    }



}
