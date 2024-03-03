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

    GameOverScreen gameOverScreen;

    private void Start()
    {
        currentHealth = health;
        gameOverScreen = FindObjectOfType<GameOverScreen>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canCollide)
        {
            if (collision.CompareTag("Player"))
            {
                if (gameOverScreen != null)
                {
                    gameOverScreen.ShowGameOverScreen();
                }
                Time.timeScale = 0; // D

            }
            if (collision.CompareTag("Boundary"))
            {
                if (gameOverScreen != null)
                {
                    gameOverScreen.ShowGameOverScreen();
                }
                Time.timeScale = 0; // D
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