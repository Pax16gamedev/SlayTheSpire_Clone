using DG.Tweening;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
    private bool flipped = false;
    private float rotationY = 180;
    private float animDuration = .25f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) Flip();
    }

    private void Flip()
    {
        flipped = !flipped;
        transform.DORotate(new Vector3(0, flipped ? 0 : rotationY, 0), animDuration);
    }
}
