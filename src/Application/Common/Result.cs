namespace Application.Common;

public class Result<T>
{
    public T? Data { get; protected set; }
    public string? Message { get; protected set; }
    public bool IsSuccess { get; protected set; }
    protected Result(T data)
    {
        Data = data;
        Message = string.Empty;
        IsSuccess = true;
    }
    protected Result(string message)
    {
        Data = default;
        Message = message;
        IsSuccess = false;
    }
    public static Result<T> Success(T data)
    {
        return new Result<T>(data);
    }
    public static Result<T> Fail(string message)
    {
        return new Result<T>(message);
    }
}