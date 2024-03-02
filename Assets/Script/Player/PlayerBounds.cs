using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{
    private Vector3 Bounds;
    private float minX,maxX, minY, maxY;
    

    private void Start()
    {
        Bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0f));

        minX = -Bounds.x + 1.3f;
        maxX = Bounds.x - 1.3f;

        minY = -Bounds.y + 1f;
        maxY = Bounds.y - 1f;
        
    }

    private void Update()
    {
        Vector3 temp = transform.position;

        if (temp.x < minX)
        {
            temp.x = minX;
        }else if (temp.x > maxX)
        {
            temp.x = maxX;
        }

        if (temp.y < minY)
        {
            temp.y = minY;
        }
        else if (temp.y > maxY)
        {
            temp.y = maxY;
        }

        transform.position = temp;
    }


}
