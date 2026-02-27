using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    private bool gameOver;
    private GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        gameOver = player.GetComponent<PlayerController>().isGameOver;
        if (gameOver == true)
        {
            return;
        }

        transform.Translate(speed * Time.deltaTime * Vector3.left);
    }
}
