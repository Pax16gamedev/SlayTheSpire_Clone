using System.Collections;
using UnityEngine;

public class StatSystem : MonoBehaviour
{
    private void OnEnable()
    {
        ActionSystem.AttachPerformer<IncreaseStatsGA>(IncreasePerformer);
    }

    private void OnDisable()
    {
        ActionSystem.DetachPerformer<IncreaseStatsGA>();
    }

    private IEnumerator IncreasePerformer(IncreaseStatsGA increaseStatsGA)
    {
        int attack = increaseStatsGA.AttackIncreaseAmount;
        int health = increaseStatsGA.HealthIncreaseAmount;
        yield return increaseStatsGA.Target.IncreaseAttackAndHealth(attack, health);
    }
}
