using StoreProject1.Domain.Enum;
using System;

namespace StoreProject1.Domain.Entity
{
    public class Cloth
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; } // описание 
        public string Model { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreate { get; set; } 
        public TypeCloth TypeCloth { get; set; }
        public byte[] Avatar { get; set; } // картинка товара в виде массива байтов, может иметь значение null
    }

}
