using UnityEngine;

public class TestSystem : MonoBehaviour
{
    //[SerializeField] List<CardDataSO> cardData;

    void Start()
    {
        //CardSystem.Instance.Setup(cardData);
    }

    private void Update()
    {

    }

    //private void CreateCard()
    //{
    //    int randomNumber = Random.Range(0, cardData.Count);
    //    Card card = new(cardData[randomNumber]);
    //    CardView cardView = CardViewCreator.Instance.CreateCardView(card, transform.position, Quaternion.identity);
    //    StartCoroutine(handView.AddCard(cardView));
    //}
}
