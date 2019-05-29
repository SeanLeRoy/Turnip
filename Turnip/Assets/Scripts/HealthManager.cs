using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    PlayerMovement player;

    private void Start()
    {
        player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        player.health = 3;
    }
    // Update is called once per frame
    void Update()
    {
        int health = player.health;
        if (health < 3)
        {
            GameObject heart3 = GameObject.Find("Heart 3");
            Destroy(heart3);
        }
        if (health < 2)
        {
            GameObject heart2 = GameObject.Find("Heart 2");
            Destroy(heart2);
        }
        
    }
}
