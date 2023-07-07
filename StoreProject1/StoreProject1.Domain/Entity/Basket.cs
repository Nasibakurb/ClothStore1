using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Domain.Entity
{
    public class Basket // корзина
    {
        public long Id { get; set; }

        public User User { get; set; }

        public long UserId { get; set; }

        public List<Order> Orders { get; set; } // заказы
    }
}
