using UnityEngine;

public class SomeCardDropArea : MonoBehaviour, ICardDropArea
{
    public void OnCardDrop(Card card)
    {
        card.transform.position = transform.position;
        card.transform.rotation = Quaternion.identity;
        print("Card dropped");
    }
}
