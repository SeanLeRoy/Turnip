using UnityEngine;

class PowerUpJump : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        player.jumpMod = 2;
    }
}
