using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletPos;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 0.5f)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = ObjectPool.instance.GetPooledObject();
        
        if(bullet != null)
        {
            bullet.transform.position = bulletPos.position;
            AudioManager.instance.PlaySoundShoot();
            bullet.SetActive(true);
        }
    }

   
}
