using UnityEngine;

class PowerUpInvincible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        player.invincible = true;
    }
}
