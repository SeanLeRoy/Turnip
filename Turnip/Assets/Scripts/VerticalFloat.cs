using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VerticalFloat : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveUp = true;

    public float startY = 0f;
    public float endY = 0f;

    void Update() {
        if (transform.position.y < startY) 
            moveUp = true;

        if (transform.position.y >= endY)
            moveUp = false;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }



   
}
