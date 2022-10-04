namespace BadgeContract;
public sealed record BadgeDto(string name, int vesting, double multiplier, int rewardLimit, double referrerRewardMultiplier, int dailyTasks, int rank)
{
    
}
