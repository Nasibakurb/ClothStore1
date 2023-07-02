using Microsoft.AspNetCore.Http;
using StoreProject1.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StoreProject1.Domain.ViewModel.Cloth
{
    public class ClothViewModel // для метода Create и т д
    {
        public long Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Введите название")]
        [MinLength(2, ErrorMessage = "Минимальная длина должна быть больше двух символов")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [MinLength(50, ErrorMessage = "Минимальная длина должна быть больше 50 символов")]
        public string Description { get; set; }

        [Display(Name = "Модель")]
        [Required(ErrorMessage = "Укажите модель")]
        [MinLength(2, ErrorMessage = "Минимальная длина должна быть больше двух символов")]
        public string Model { get; set; }

        [Display(Name = "Размер")]
        [Required(ErrorMessage = "Укажите размер")]
        public int Size { get; set; }

        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Укажите стоимость")]
        public decimal Price { get; set; }


        public string DateCreate { get; set; }

        [Display(Name = "Тип одежды")]
        [Required(ErrorMessage = "Выберите тип")]
        public string TypeCloth { get; set; } // тип не TypeCloth потому как когда пользователь будет вводить, он будет вводить строку 

        public IFormFile Avatar { get; set; } // для загрузки изобр. 

        public byte[] Image { get; set; } // после загр преобразует в бинарное формат.
        // бинарное представл. позволяет хранить и передавать изобр. в виде байтов для дб или передачи по сети. 
    }
}
