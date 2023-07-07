using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Domain.Extensions
{
    public static class StringExtension
    {    // позволяет объед. элементы списка words в одну строку с пронумерован. элементами
        public static string Join(this List<string> words)
        {
            var sb = new StringBuilder(); // StringBuilder - создает и изменяет строки 

            for (int i = 0; i < words.Count; i++) // к каждому слову приписывается цыфра
            {
                sb.Append($"{i + 1}: {words[i]} "); // например 1. книга 2. тетрадь 
            }

            return sb.ToString(); // возвращает результат - строку.
        }
    }
}
