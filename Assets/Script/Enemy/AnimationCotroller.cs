using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCotroller : MonoBehaviour
{
    public EnemyController[] enemies;
    public Bullet[] bullets;
    public EnemyMove enemyMove;
    private void Start()
    {
        EnemyMove enemyMove = GetComponent<EnemyMove>();
        StartCoroutine(AnimationCoroutine());
    }

    IEnumerator AnimationCoroutine()
    {
        // Ch?y animation
        if (enemyMove != null)
        {
            enemyMove.moveSpeed = 0f;
        }

        foreach (Bullet bullet in bullets)
        {
            bullet.SetCanCollideWithEnemy(false);
        }
        // Ch? cho animation k?t th�c
        yield return new WaitForSeconds(11f);

        enemyMove.moveSpeed = 1f;


        // K�ch ho?t va ch?m cho �?n v� enemy
        foreach (EnemyController enemy in enemies)
        {
            enemy.EnableCollision();
            
        }

        foreach (Bullet bullet in bullets)
        {
            bullet.SetCanCollideWithEnemy(true);
        }
    }
}
