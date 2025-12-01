using FootballGamePlan.Api.Models;

namespace FootballGamePlan.Api;

public class CreatePlayResultDto
{
    public int GamePlanId { get; set; }
    public int PlayId { get; set; }
    public Coverage Coverage { get; set; }
    public PassFailReason PassFailReason { get; set; }
    public bool IsPass { get; set; }
    public int YardsGained { get; set; }

}
