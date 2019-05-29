using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        int health = player.health;
        GameObject heart3 = GameObject.Find("Heart 3");
        GameObject heart2 = GameObject.Find("Heart 2");
        if (health < 3)
        {
            Destroy(heart3);
        } 
        if (health < 2)
        {
            Destroy(heart2);
        }
    }
}
