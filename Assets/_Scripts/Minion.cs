using System.Collections;
using UnityEngine;

public class Minion : MonoBehaviour
{
    [SerializeField] int attack;
    [SerializeField] int health;

    private void OnEnable()
    {
        ActionSystem.SubscribeReaction<DealDamageGA>(DealDamageReaction, ReactionTiming.POST);
    }

    private void OnDisable()
    {
        ActionSystem.UnsubscribeReaction<DealDamageGA>(DealDamageReaction, ReactionTiming.POST);
    }

    private void DealDamageReaction(DealDamageGA dealDamageGA)
    {
        IncreaseStatsGA increaseStatsGA = new(this, dealDamageGA.Amount, dealDamageGA.Amount);
        ActionSystem.Instance.AddReaction(increaseStatsGA);
    }

    public IEnumerator IncreaseAttackAndHealth(int attack, int health)
    {
        this.attack += attack;
        this.health += health;
        //attackText.text = this.attack.ToString();
        yield return null;
    }
}
