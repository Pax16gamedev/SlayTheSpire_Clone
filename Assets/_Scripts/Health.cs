using System.Collections;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health;

    public IEnumerator ReduceHealth(int amount)
    {
        health -= amount;
        yield return null;
    }
}
