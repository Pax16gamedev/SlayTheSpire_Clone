using UnityEngine;

public class IncreaseStatsGA : GameAction
{
    public Minion Target;
    public int AttackIncreaseAmount;
    public int HealthIncreaseAmount;

    public IncreaseStatsGA(Minion target, int attackIncreaseAmount, int healthIncreaseAmount)
    {
        Target = target;
        AttackIncreaseAmount = attackIncreaseAmount;
        HealthIncreaseAmount = healthIncreaseAmount;
    }
}
