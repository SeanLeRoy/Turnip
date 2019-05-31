using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDamage : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyDamage enemyDamage = new EnemyDamage();
        enemyDamage.hearts(1);
    }
}
