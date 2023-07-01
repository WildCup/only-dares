namespace DaresGacha.Model;

public class Dare : Base
{
    public string Text { get; set; } = string.Empty;
    public int Level { get; set; } = 1; //max 5
    public bool Done { get; set; } = false;
    public int Skipped { get; set; } = 0;
    public bool IsDeleted { get; set; }
}
