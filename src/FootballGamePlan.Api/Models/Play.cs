namespace FootballGamePlan.Api.Models;

public class Play
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsPass { get; set; }
    public List<PlayResult> Results { get; set; } = new();
}
