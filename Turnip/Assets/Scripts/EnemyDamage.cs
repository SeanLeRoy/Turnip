using UnityEngine;

class EnemyDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        Debug.Log(player.health);
        player.health = player.health - 1;
    }
}