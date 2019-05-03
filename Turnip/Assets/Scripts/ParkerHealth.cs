using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ParkerHealth : MonoBehaviour
{
    public int startingHealth = 10;                            // The amount of health Parker starts the level with.
    public int currentHealth;                                   // The current health Parker has.
    public Slider healthManager;                                 // Reference to the UI's health bar.


    void Awake()
    {
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    void Update()
    {
        
    }


    public void TakeHit(int damage)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= damage;

        // Set the health bar's value to the current health.
        healthManager.value = currentHealth;

    }
}