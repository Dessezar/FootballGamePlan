namespace FootballGamePlan.Api;

public class GamePlan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<PlayResult> Results { get; set; } = new();
    public List<Play> Plays { get; set; } = new();
}
