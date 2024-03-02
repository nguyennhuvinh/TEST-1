using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    private List<GameObject> pooledObject = new List<GameObject>();
    private int amoutToPool = 20;

    [SerializeField] private GameObject bulletPreFab;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        for(int i =0; i < amoutToPool; i++)
        {
            GameObject obj = Instantiate(bulletPreFab);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
       
    }

    public GameObject GetPooledObject()
    {
        for(int i =0; i< pooledObject.Count; i++)
        {
            if (!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }

        return null;
    }
}
