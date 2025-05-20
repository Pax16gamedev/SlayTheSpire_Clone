using System.Collections;
using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    private void OnEnable()
    {
        ActionSystem.AttachPerformer<EnemyTurnGA>(EnemyTurnPerformer);
    }

    private void OnDisable()
    {
        ActionSystem.DetachPerformer<EnemyTurnGA>();
    }


    private IEnumerator EnemyTurnPerformer(EnemyTurnGA enemyTurnGA)
    {
        print("Enemy Turn");
        yield return new WaitForSeconds(2);
        print("End Enemy Turn");
    }
}
