using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
 

    public float baseSpeed;
    public float moveSpeed;
    public float moveDownDistance = 1f;
    private float switchDirectionTime = 3.0f; // Time to wait before switching direction (2 seconds)
    private float timer = 0.0f; // Timer to track elapsed time

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= switchDirectionTime)
        {
            moveSpeed *= -1;
            timer = 0.0f;

            // Di chuy?n xu?ng sau khi ð?i hý?ng
            transform.Translate(Vector2.down * moveDownDistance);
        }

        transform.Translate(Vector2.right * baseSpeed * moveSpeed * Time.deltaTime);
    }


}
