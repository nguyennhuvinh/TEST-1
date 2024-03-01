using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var worldHeight = Camera.main.orthographicSize * 2f;
        var worlWitdh = worldHeight * Screen.width / Screen.height;

        transform.localScale = new Vector3(worlWitdh, worldHeight, 0f);
    }

  
    
}
