namespace DaresGacha.Dtos;

public class DareUpdateDto
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Level { get; set; }
    public bool Done { get; set; } = false;
}
