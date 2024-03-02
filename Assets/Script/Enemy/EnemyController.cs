using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyController : MonoBehaviour
{
    public int health = 5;
    private int currentHealth;
    private bool canCollide = false;
  
    private void Start()
    {
        currentHealth = health;

 
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canCollide)
        {
            if (collision.CompareTag("Player"))
            {
                Time.timeScale = 0;
            }
            if (collision.CompareTag("Boundary"))
            {
                Time.timeScale = 0;
            }

            Bullet bullet = collision.GetComponent<Bullet>();
            if (bullet != null)
            {
                TakeDamage(bullet.damage);
                bullet.gameObject.SetActive(false);
            }
        }
    }

    public void EnableCollision()
    {
        canCollide = true;
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            ScoreManager.Instance.AddScore(1);
            AudioManager.instance.PlaySoundDeath();
            Destroy(gameObject);
        }
    }

}