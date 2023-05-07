using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieHealth : MonoBehaviour
{
    public float maxHealth = 100;

    private float healthRn;

    public Slider healthBar;
    public GameObject parentObject;
    // Start is called before the first frame update
    void Start()
    {
        healthRn = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = healthRn;
    }

    public void TakeDamage(float damage)
    {
        healthRn -= damage;
        healthBar.value = healthRn;

        if (healthRn <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //More HEre
        Destroy(parentObject);
        Destroy(healthBar.gameObject);
        Destroy(gameObject);
    }
}