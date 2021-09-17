using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField]
    private float speed = 1.0f;

    private Vector3 currentDirection = Vector3.zero;

    private void Awake()
    {
        currentDirection = new Vector3(Random(), Random(), 0).normalized;
    }


    [SerializeField]
    private Rigidbody2D rigidBody = null;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one
    //Ball should only move once its been launched

    private void Update()
    {
        transform.Translate(currentDirection * Time.deltaTime * speed);
    }

    private void FixedUpdate()
    {
        var newDelta = currentDirection * Time.deltaTime * speed;
        rigidBody.MovePosition(transform.position + newDelta);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentDirection = Vector2.Reflect(currentDirection, collision.contacts[0].normal);
    }

    private int Random()
    {
        return UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle


        if (collision.CompareTag("Piece"))
        {
            Destroy(collision.gameObject);
            currentDirection = new Vector3(Random(), Random(), 0);



        }
    }
}
