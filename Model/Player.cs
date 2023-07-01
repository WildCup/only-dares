namespace DaresGacha.Model;

public class Player : Base
{
    public string Name { get; set; } = string.Empty;
    public bool IsMale { get; set; }
    public int PartnerId { get; set; }
}
