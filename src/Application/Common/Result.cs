namespace Application.Common;

public class Result<T>
{
    public T? Data { get; protected set; }
    public Message Error { get; protected set; }
    public bool IsSuccess { get; protected set; }
    protected Result(T data)
    {
        Data = data;
        Error = Common.Message.Success;
        IsSuccess = true;
    }
    protected Result(Message error)
    {
        Data = default;
        Error = error;
        IsSuccess = false;
    }
    public static Result<T> Success(T data, Message message)
    {
        return new Result<T>(data);
    }
    public static Result<T> Success(Message message)
    {
        return new Result<T>(Message.Success);
    }
    public static Result<T> Fail(Message error)
    {
        return new Result<T>(error);
    }
}