namespace MasterNet.Application.Core;

public class AppException
{
  public AppException(string message,int statusCode, string? details = null)
    {
        Message = message;
        StatusCode = statusCode;
        Details = details;
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }

  

    public string? Details {get;set;}
}