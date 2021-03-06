﻿using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyDamage : MonoBehaviour
{
    bool damageEnemy = false;
    double lastDamage = 0;
    private int enemyHealth = 1;
    public int parkerHealth = 3;
    public string enemyName;

    private AudioClip enemyHitSound;
    private AudioClip playerHitSound;
    private AudioSource audioSource;

    private void Awake()
    {
        parkerHealth = 4;

        // find and load audio files
        audioSource = gameObject.AddComponent<AudioSource>();
        enemyHitSound = Resources.Load<AudioClip>("Assets/Props/Game Music/DamageGiven.mp3");
        playerHitSound = Resources.Load<AudioClip>("Assets/Props/Game Music/DamageTaken.mp3");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerMovement player = GameObject.Find("Parker").GetComponent<PlayerMovement>();
        GameObject enemy = GameObject.Find(enemyName);

        if (enemyHealth == 0)
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
                audioSource.PlayOneShot(enemyHitSound);
            }
            else
            {
                player.takeDamage();
                audioSource.PlayOneShot(playerHitSound);
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
}
