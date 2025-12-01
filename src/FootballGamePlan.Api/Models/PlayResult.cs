namespace FootballGamePlan.Api.Models;

public class PlayResult
{
    public int Id { get; set; }
    public int GamePlanId { get; set; }
    public GamePlan GamePlan { get; set; }
    public int PlayId { get; set; } 
    public Play Play { get; set; }
    public Coverage Coverage { get; set; }
    public bool IsPass { get; set; }
    public PassFailReason PassFailReason { get; set; }
    public int YardsGained { get; set; }

}
