using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] int amount = 3;

    private void OnEnable()
    {
        ActionSystem.SubscribeReaction<DrawCardGA>(DrawCardReaction, ReactionTiming.POST);
    }

    private void OnDisable()
    {
        ActionSystem.UnsubscribeReaction<DrawCardGA>(DrawCardReaction, ReactionTiming.POST);
    }

    private void DrawCardReaction(DrawCardGA drawCardGA)
    {
        DealDamageGA dealDamageGA = new(amount);
        ActionSystem.Instance.AddReaction(dealDamageGA);
    }
}
