using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSource : MonoBehaviour
{
    [SerializeField] private int damageAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<EnemyHelth>())
        {
            EnemyHelth enemyHealth = other.gameObject.GetComponent<EnemyHelth>();
            enemyHealth.TakeDamage(damageAmount);
        }
    }
}
