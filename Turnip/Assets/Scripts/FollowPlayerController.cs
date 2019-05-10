using UnityEngine;
using System.Collections;

public class FollowPlayerController : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public bool onlyXAxis = false;


    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    public bool shouldAlsoFlip = false;
    public CharacterController2D controller2d; // Indepedent controller that determines when to flip
    public float flipDistance;


    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        Vector3 newPosition = player.transform.position + offset;

        if (onlyXAxis) {
            newPosition.y = transform.position.y;
        }

        if (shouldAlsoFlip) {
            if (!controller2d.facingRight)
            {
                newPosition = new Vector3(newPosition.x - flipDistance * 2, newPosition.y, newPosition.z);
            }
        }
        transform.position = newPosition;
    }
}