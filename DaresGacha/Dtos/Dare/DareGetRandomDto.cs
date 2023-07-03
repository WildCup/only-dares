namespace DaresGacha.Dtos.Dare;

public class DareGetRandomDto
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int Level { get; set; }
    public double[] Difficulty { get; set; } = { };
}
