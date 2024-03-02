using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private bool canCollideWithEnemy = false;
    private Rigidbody2D rb;
    [SerializeField] private float speed = 10f;
    public int damage = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") &&  canCollideWithEnemy)
        {
            gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Boundary"))
        {
            gameObject.SetActive(false);
        }

    }

    public void SetCanCollideWithEnemy(bool value)
    {
        canCollideWithEnemy = value;
    }

}
