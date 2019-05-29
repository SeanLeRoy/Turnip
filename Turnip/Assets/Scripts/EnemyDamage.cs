using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDamage : MonoBehaviour
{
    bool damageEnemy = false;
    double lastDamage = 0;
    private int enemyHealth = 1;
    public string enemyName;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        GameObject enemy = GameObject.Find(enemyName);

        if(enemyHealth == 0)
        {
            Destroy(enemy);
        }
        double currentTime = Time.fixedTime;

        if ((currentTime - lastDamage) > 1)
        {
            lastDamage = Time.fixedTime;
            if (damageEnemy)
            {
                // Debug.Log("damageEnemy");
                enemyHealth--;
            }
            else
            {
                // Debug.Log("damageParker");
                player.health--;
            }
            Debug.Log("parker health: " + player.health);
            Debug.Log("enemy health: " + enemyHealth);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            damageEnemy = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            damageEnemy = false;
        }
    }
}