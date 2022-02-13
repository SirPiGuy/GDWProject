using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooty : MonoBehaviour
{
    //SpaceTanks script
    private float startDelay = 0.5f;
    private float spawnInterval = 1.0f;
    private Vector3 bulletSpawnOffset = new Vector3(0, 1, 0); //Can't get bullet spawn offset to rotate with respect to the tank. For now they will spawn above the tanks instead of infront of their gun. Superior enemy tanks don't need gun to fire bullet.

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shooty", startDelay, spawnInterval); //Repeatedly call the function, starting at 0 seconds and repeating every 1.0s after that
    }

    // Update is called once per frame
    void Shooty()
    {
        //Spawns bullet from the position of the tank + the offset so it doesn't delete itself with it's own bullet.
        Instantiate(projectilePrefab, transform.position + bulletSpawnOffset, transform.rotation);
    }
}
