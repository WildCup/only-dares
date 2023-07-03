namespace DaresGacha.Dtos.Dare;

public class DareGetDto
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Level { get; set; }
    public bool Done { get; set; } = false;
    public bool IsDeleted { get; set; }
}
