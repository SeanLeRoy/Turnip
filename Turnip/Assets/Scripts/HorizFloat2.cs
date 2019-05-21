using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HorizFloat2 : MonoBehaviour
{
    float dirX, moveSpeed = 3f;
    bool moveOver = true;

    void Update()
    {
        if (transform.position.x < 110f)
            moveOver = true;

        if (transform.position.x >= 115f)
            moveOver = false;

        if (moveOver)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }




}
