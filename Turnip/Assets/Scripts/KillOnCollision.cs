using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnCollision : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Parker" || collision.gameObject.name == "Turnip")
        {
            // TODO: Trigger Death Sequence, for now just reset position
            collision.gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }
}
