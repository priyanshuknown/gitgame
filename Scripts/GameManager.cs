using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject car;
    public Transform[] spawnPoints;
    private bool isPlayerActive = true;

    void Start()
    {
        SpawnPlayer();
    }

    void Update()
    {
        HandleInput();
    }

    void SpawnPlayer()
    {
        // Logic to spawn player at a random spawn point
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(player, spawnPoints[spawnIndex].position, Quaternion.identity);
    }

    void HandleInput()
    {
        // Switch control between player and car
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SwitchControl();
        }

        // Additional input handling logic can be added here
    }

    void SwitchControl()
    {
        isPlayerActive = !isPlayerActive;
        
        if (isPlayerActive)
        {
            // Logic to enable player control
            player.SetActive(true);
            car.SetActive(false);
        }
        else
        {
            // Logic to enable car control
            player.SetActive(false);
            car.SetActive(true);
        }
    }
}