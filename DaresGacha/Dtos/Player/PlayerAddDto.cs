namespace DaresGacha.Dtos.Player;

public class PlayerAddDto
{
    public string Name { get; set; } = string.Empty;
    public bool IsMale { get; set; }
    public int? PartnerId { get; set; }
}
