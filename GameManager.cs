using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;
    public bool manoman = true;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;


    [SerializeField]
    private GameObject piecepic = null;

    [SerializeField]
    private EdgeCollider2D border;

    public GameObject ballLauncher;

    //TODO
    //Using const data defined above "Instantiate" new pieces to fill the view with

    void MakePieces()
    {
        int i = 0;
        float currentX = -5.78f;
        float currentY = 4.8f;
        for (int j = 0; j < TOTAL_ROWS; j++)
        {
            Instantiate(piecePrefab, new Vector3(currentX, currentY, 0), Quaternion.identity);
            currentY = currentY - .45f;

            for (int k = 0; k < PIECE_COUNT_PER_ROW; k++)
            {
                Instantiate(piecePrefab, new Vector3(currentX, currentY, 0), Quaternion.identity);
                currentX = currentX + 1f;
            }
            currentX = -5.78f;
        }
        while (i < PIECE_COUNT_PER_ROW - 1)
        {
            Instantiate(piecePrefab, new Vector3(currentX + 1, 4.8f, 0), Quaternion.identity);
            i++;
            currentX = currentX + 1;
        }

    }
   


    [SerializeField]
    private Ball ballprefab;

    public bool isBallThereYet = false;


    private void Start()
    {
        MakePieces();
    }

    public void Update()
    {
    piecepic.SetActive(manoman);

           if (Input.GetKeyDown(KeyCode.Space) && !isBallThereYet)
        {
            
            isBallThereYet = true;
            initializeBall();
            manoman = false;
            //piecepic.SetActive(false);
            //Destroy(piecepic);
        }
    }

    void initializeBall()
    {
        Vector3 ballLauncherPos = ballLauncher.gameObject.transform.position;
        Vector3 ballPos = new Vector3(ballLauncherPos.x, ballLauncherPos.y + .25f, 0);
        Instantiate(ballprefab, ballLauncherPos, Quaternion.identity);
    }

}
