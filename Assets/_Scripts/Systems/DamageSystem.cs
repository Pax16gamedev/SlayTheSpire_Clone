using DG.Tweening;
using System.Collections;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Knife knife;

    private float tweenDuration = .25f;

    private void OnEnable()
    {
        ActionSystem.AttachPerformer<DealDamageGA>(DealDamagePerformer);
    }

    private void OnDisable()
    {
        ActionSystem.DetachPerformer<DealDamageGA>();
    }

    private IEnumerator DealDamagePerformer(DealDamageGA dealDamageGA)
    {
        int damageAmount = dealDamageGA.Amount;
        Vector2 knifeStart = knife.transform.position;
        Tween tween = knife.transform.DOMove(health.transform.position, tweenDuration);
        yield return tween.WaitForCompletion();
        knife.transform.DOMove(knifeStart, 0.5f);
        yield return health.ReduceHealth(damageAmount);
    }
}
