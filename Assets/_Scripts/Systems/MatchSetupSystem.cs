using System.Collections.Generic;
using UnityEngine;

public class MatchSetupSystem : MonoBehaviour
{
    [SerializeField] List<CardDataSO> deckData;

    private void Start()
    {
        CardSystem.Instance.Setup(deckData);
        DrawCardGA drawCardGA = new(5);
        ActionSystem.Instance.Perform(drawCardGA);
    }
}
