using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HorizontalFloat : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveOver = true;

    public float startX = 0f;
    public float endX = 0f;


    void Update()
    {
        if (transform.position.x < startX)
            moveOver = true;

        if (transform.position.x >= endX)
            moveOver = false;

        if (moveOver)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }




}
