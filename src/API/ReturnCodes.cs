using Application.Common;

namespace API;

public static class ReturnCodes
{
    public static Dictionary<Message, int> Codes = new Dictionary<Message, int>
    {
        {Message.None, 200},
        {Message.Success, 200},
        {Message.Created, 201},
        {Message.UserAlreadyExists, 409},
        {Message.InvalidCredentials, 401},
        {Message.InvalidEmail, 400},
        {Message.InvalidPassword, 400},
        {Message.InternalServerError, 500}
    };
}