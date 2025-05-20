using TMPro;
using UnityEngine;

public class CardView : MonoBehaviour
{
    [SerializeField] TMP_Text title;
    [SerializeField] TMP_Text description;
    [SerializeField] TMP_Text mana;
    [SerializeField] SpriteRenderer imageSR;
    [SerializeField] GameObject wrapper;

    private Vector3 dragStartPosition;
    private Quaternion dragStartRotation;

    public Card card { get; private set; }
    public void Setup(Card card)
    {
        this.card = card;
        title.text = card.Title;
        description.text = card.Description;
        mana.text = card.Mana.ToString();
        imageSR.sprite = card.Image;
    }

    #region HoverSystem
    private void OnMouseEnter()
    {
        if(!Interactions.Instance.PlayerCanHover()) return;
        wrapper.SetActive(false);
        Vector3 pos = new(transform.position.x, -2, 0);
        CardViewHoverSystem.Instance.Show(card, pos);
    }

    private void OnMouseExit()
    {
        if (!Interactions.Instance.PlayerCanHover()) return;
        CardViewHoverSystem.Instance.Hide();
        wrapper.SetActive(true);
    }
    #endregion

    #region DragAndDropSystem
    private void OnMouseDown()
    {
        if(!Interactions.Instance.PlayerCanInteract()) return;
        Interactions.Instance.PlayerIsDragging = true;
        wrapper.SetActive(true);
        CardViewHoverSystem.Instance.Hide();

        dragStartPosition = transform.position;
        dragStartRotation = transform.rotation;

        transform.position = MouseUtils.GetMousePositionInWorldSpace(-1);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void OnMouseDrag()
    {
        if (!Interactions.Instance.PlayerCanInteract()) return;
        transform.position = MouseUtils.GetMousePositionInWorldSpace(-1);
    }

    private void OnMouseUp()
    {
        if (!Interactions.Instance.PlayerCanInteract()) return;
        if (Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hit, 10f))
        {
            // Play card
        }
        else
        {
            transform.position = dragStartPosition;
            transform.rotation = dragStartRotation;
        }
        Interactions.Instance.PlayerIsDragging = false;
    }

    #endregion
}
