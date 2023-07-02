using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProject1.Domain.ViewModel.order
{
    public class OrderViewModel
    {
        public long Id { get; set; }

        public string ClothName { get; set; } 

        public string Model { get; set; }

        public int Size { get; set; }

        public string TypeCloth { get; set; }

        public byte[]? Image { get; set; } // картинка товара в виде массива байтов, может иметь значение null

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; } // отчество

        public string DateCreate { get; set; }
    }
}
