using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameManager alive;

    public GameManager showy;


    private void Start()
    {
        GameObject g = GameObject.Find("GameManager");
        alive = g.GetComponent<GameManager>();

        GameObject m = GameObject.Find("GameManager");
            showy = m.GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle


        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            alive.isBallThereYet = false;
            

            alive.manoman = true;
        }
    }
}
