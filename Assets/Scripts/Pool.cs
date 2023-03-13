using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable] 
public class PoolItem
{
    public GameObject prefab;
    public int amount;
    public bool expandable;
}

public class Pool : MonoBehaviour
{
    public List<PoolItem> items;

    public List<GameObject> pooledItems;

    public static Pool singleton;

    private void Awake()
    {
        if (singleton == null)
            singleton = this;
    }


    void Start()
    {
        pooledItems = new List<GameObject>();
        foreach (PoolItem item in items)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject bullet = Instantiate(item.prefab, new Vector3(0.5f, 0.5f, 0), 
                    LanzamientoFlecha1.Singleton.arco.gameObject.transform.rotation) as GameObject;
                bullet.SetActive(false);
                pooledItems.Add(bullet);
            }
        }
    }

    public GameObject Get(string tag)
    {
        for (int i = 0; i < pooledItems.Count; i++)
        {
            if (!pooledItems[i].activeInHierarchy && pooledItems[i].tag == tag)
            {
                return pooledItems[i];
            }
        }

        foreach (PoolItem item in items)
        {
            if (item.prefab.tag == tag && item.expandable)
            {
                GameObject obj = Instantiate(item.prefab);
                obj.SetActive(false);
                pooledItems.Add(obj);
                return obj;
            }
        }
        return null;
    }
}
