using StoreProject1.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Domain.Entity
{
    public class User
    {
        public long Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; } // роль

        public Profile Profile { get; set; } // профиль

        public Basket Basket { get; set; } // корзина
    }
}
