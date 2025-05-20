using UnityEngine;

public class Card : MonoBehaviour
{
    private readonly CardDataSO data;
    public string Title => data.Title;
    public string Description => data.Description;
    public Sprite Image => data.Image;
    public int Mana { get; private set; }

    public Card(CardDataSO cardData)
    {
        data = cardData;
        Mana = cardData.Mana;
    }

    
}
