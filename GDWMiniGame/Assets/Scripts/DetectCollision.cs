using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    //SpaceTanks script

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
            Destroy(gameObject); //Deletes the object that got hit...
            Destroy(other.gameObject); //...and the object that did the hitting
            //TODO: Make it so when the tanks are destroyed the player gets a score of +10 points.
    }
}
