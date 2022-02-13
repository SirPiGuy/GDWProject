using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //SpaceTanks Script
    public float horizontalInput; //dertermines which direction the player is moving (left/right)
    public float forwardInput; //Which direction the vehicle is moving (taken directly from inputs, forward/backwards)
    public float speed = 10.0f; //controls how fast the player moves
    public float turnSpeed = 90.0f;
    public float xRange = 9.0f; //controls how far the player can move on the x-axis
    public float zRange = 5.0f; //controls how far the player can move on the z-axis

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Causes the vehicle to move forward/backwards along the Z-Axis, per player input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Causes the vehicle to turn
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        //Sets limits on how far the player can move in the scene.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //If the player presses Space, they will shoot a bullet
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation); //Launch projectile from the player
        }

    }

}
