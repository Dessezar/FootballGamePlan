namespace FootballGamePlan.Api;

public class PlayResult
{
    public int Id { get; set; }
    public int GamePlanId { get; set; }
    public GamePlan GamePlan { get; set; }
    public int PlayId { get; set; } 
    public Play Play { get; set; }
    public Coverage Coverage { get; set; }

}
