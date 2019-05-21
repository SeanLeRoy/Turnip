using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VerticalFloat : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveUp = true;

    void Update() {
        if (transform.position.y < 2.5f) 
            moveUp = true;

        if (transform.position.y >= 6f)
            moveUp = false;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }



   
}
