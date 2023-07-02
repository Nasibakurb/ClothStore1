using StoreProject1.Domain.Enum;
using System.Reflection.Metadata;

namespace StoreProject1.Domain.Response
{
    // базовая модель ответа для возврата результата операций
    public class BaseResponse<T>: IBaseResponse<T>
    {
        public string Description { get; set; } // описание или сообщение об ошибки
        public StatusCode StatusCode { get; set; } // код ошибки (например 404)
        public T Data { get; set; } // записывается результат запроса
    }

    public interface IBaseResponse<T> 
    { // свойства только для чтения
        string Description { get; }
        T Data { get;}
        StatusCode StatusCode { get; }
    }
}
