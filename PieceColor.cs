using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {

        int number = Random.Range(0, 7);
        if (number == 0)
        {
            spriteRenderer.sprite = blueColor;
        } else if (number == 1)
        {
            spriteRenderer.sprite = redColor;
        } else if (number == 2)
        {
            spriteRenderer.sprite = greenColor;
        } else if (number == 3)
        {
            spriteRenderer.sprite = purpleColor;
        } else if (number == 4)
        {
            spriteRenderer.sprite = goldColor;
        } else if (number == 5)
        {
            spriteRenderer.sprite = greyColor;
        } else if (number == 6)
        {
            spriteRenderer.sprite = brownColor;
        } 
        //TODO
        // set spriteRenderer.sprite to a random sprite that is present above

        //spriteRenderer.sprite = ???;
    }
}
