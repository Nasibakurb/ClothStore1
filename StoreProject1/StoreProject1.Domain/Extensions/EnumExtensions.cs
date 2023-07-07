using StoreProject1.Domain.Enum;
using StoreProject1.Domain.ViewModel.Cloth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Domain.Extensions
{
    public static class EnumExtensions
    {  // получает информ. о поле перечисл., а затем проверяет на налич атрибута DisplayAttribute и возвращ. значение.
        public static string GetDisplayName(this System.Enum enumValue)
        {
            return enumValue.GetType() // получ. тип объекта перечился (например admin )
                 .GetMember(enumValue.ToString()) // получает информ о обьекте
                 .First() // получает первый элемент из коллекции
                 .GetCustomAttribute<DisplayAttribute>() // получает атрибут котор. может примен. 
                 ?.GetName() ?? "Неопределенный"; // есть атрибут отсутств. возвращ null 
        }
    }
}
