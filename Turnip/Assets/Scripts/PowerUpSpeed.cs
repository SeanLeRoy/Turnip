using UnityEngine;

class PowerUpSpeed : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        player.speedMod = 2;
        GameObject chest = GameObject.Find("chest");
        Destroy(chest);
        // play chest sound effect here
    }
}
