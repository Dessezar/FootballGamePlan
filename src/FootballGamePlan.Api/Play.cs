namespace FootballGamePlan.Api;

public class Play
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsPass { get; set; }
    public List<PlayResult> Result { get; set; } = new();
}
