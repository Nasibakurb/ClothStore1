using System;
using System.Security.Cryptography;
using System.Text;

namespace StoreProject1.Domain.Helpers
{
    public static class HashPasswordHelper
    { 
        public static string HashPassowrd(string password) // хэширование пароля - зашифров.
        {
            using (var sha256 = SHA256.Create()) // экземпляр класса для хеширование алгоритм. SHA256
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password)); // приобр. в байтов. массив испол. кодир. UTF-8
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower(); // приобр. хэш значение в строку. где представ 16 символы.
                                                                               // преобою в нижний регистр.
                return hash;
            }
        }
    }
    }
