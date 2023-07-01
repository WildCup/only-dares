
namespace DaresGacha.Model;

public class ServiceResponse<T>
{
    public T? Data { get; set; }
    public bool Success { get; set; } = true;
    public string Exception { get; set; } = string.Empty;
}
