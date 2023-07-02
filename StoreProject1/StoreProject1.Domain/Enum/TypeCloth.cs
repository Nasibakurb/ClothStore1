using System.ComponentModel.DataAnnotations;


namespace StoreProject1.Domain.Enum
{
    public enum TypeCloth
    {
        [Display(Name = "Зимняя одежда")]
        WinterClothes = 0,
        [Display(Name = "Летняя одежда")]
        SummerClothes = 1,
        [Display(Name = "Демисезонная одежда")]
        DemiseasonClothing = 2
    }
}
