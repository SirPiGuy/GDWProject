using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //SpaceTanks Script
    //Controls how fast the Bullets will move
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bullet will consistently move forward at a steady speed.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
