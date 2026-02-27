using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;

    private bool gameOver;
    GameObject player;

    //public PlayerController player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
        player = GameObject.Find("Player"); 
    }

    void Spawn()
    {
        //if (player.isGameOver == true)
        //{
        //    return;
        //}
        gameOver = player.GetComponent<PlayerController>().isGameOver;
        if (gameOver == true)
        {
            return;
        }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
