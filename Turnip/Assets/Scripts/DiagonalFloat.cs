using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DiagonalFloat : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveOver = true;

    void Update()
    {
        if (transform.position.x < 100f)
            moveOver = true;

        if (transform.position.x >= 104f)
            moveOver = false;

        if (moveOver)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y - moveSpeed * Time.deltaTime);
    }




}
