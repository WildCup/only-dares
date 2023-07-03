namespace DaresGacha.Dtos.Player;

public class PlayerUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsMale { get; set; }
    public int? PartnerId { get; set; }
}
