using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    //TODO: create a structure to contain a collection of bullets
    public GameObject bullet;
    public int numInPool;
    public List<GameObject> objectPool;
    public static BulletPoolManager sharedInstnace;
    public BulletPoolManager newManager;
    void Awake()
    {
        sharedInstnace = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        objectPool = new List <GameObject>();
        //instantiate a number of objects into the list 
        for (int i =0; i<numInPool; i++)
        {
            GameObject objs = (GameObject)Instantiate(bullet);
            objs.SetActive(false);
            objectPool.Add(objs);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    //ask the pool for a bullet
    public GameObject GetBullet()
    {
        for (int i = 0; i< objectPool.Count; i++ )
        {
            if (!objectPool[i].activeInHierarchy)
            {
                return objectPool[i];
            }

        }
        return null;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
    }
}
