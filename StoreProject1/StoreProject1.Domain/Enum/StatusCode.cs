namespace StoreProject1.Domain.Enum // создание перечисл. ошибок
{
    public enum StatusCode
    {
        UserNotFound = 0,
        UserAlreadyExists = 1, // пользователь уже существует

        ClothNotFound = 10,
        OrderNotFound = 20,

        OK = 200,
        InternalServerError = 500
    }
}
