 using System;
 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class Bullet : MonoBehaviour
 {
     public float speed = 10f; // speed of the bullet
     public float lifetime = 2f; // time before bullet destroys itself
     public float damage = 10;
      
     void Start()
     {
         // move z
         GetComponent<Rigidbody>().velocity = transform.forward * speed;
         // destroy the bullet after its lifetime expires
        Destroy(gameObject, lifetime);
     }

    private void OnTriggerEnter(Collider collision)
     {
         
         Debug.Log("Rammer bullet zombie");
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Debug.Log("Ja bullet ramte zombie");
             ZombieHealth zombieHealth = collision.gameObject.GetComponent<ZombieHealth>();
            if (zombieHealth != null)
             {
                 zombieHealth.TakeDamage(damage);
                 zombieHealth.healthBar.gameObject.SetActive(true);
             }
         }
     }
 }