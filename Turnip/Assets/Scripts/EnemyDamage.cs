using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDamage : MonoBehaviour
{
    bool damageEnemy = false;
    double lastDamage = 0;
    private int enemyHealth = 1;
    public int parkerHealth = 3;
    public string enemyName;

    private void Awake()
    {
        parkerHealth = 4;
    }

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
                enemyHealth--;
            }
            else
            {
                parkerHealth--;
                hearts();
            }
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

    private void hearts()
    {
        GameObject heart3 = GameObject.Find("Heart 3");
        GameObject heart2 = GameObject.Find("Heart 2");
        GameObject heart1 = GameObject.Find("Heart 1");
        if (heart3 != null && parkerHealth < 3)
        {
            Destroy(heart3);
        }
        if (heart2 != null && parkerHealth < 2)
        {
            Destroy(heart2);
        }
        if (heart1 != null && parkerHealth < 1)
        {
            Destroy(heart1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }

    public void hearts(int damage)
    {
        parkerHealth--;
        Debug.Log(parkerHealth);
        this.hearts();
    }
}