using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    // 자료구조
    public List<GameObject> list = new List<GameObject>();

    public static bool spawnCheck = true;
    public static int spawnTime = 1;


    public void SpawnEnemy()
    {
        if (spawnCheck)
        {
            // 0 ~ 1 둘 중 하나
            int ran = Random.Range(0, list.Count);

            Instantiate(list[ran], list[ran].transform.position, Quaternion.identity);
        }
        else
        {
            CancelInvoke("SpawnEnemy");
        }
    }


    void Start()
    {
        spawnCheck = true;
        Invoke("InvokeSpawn", 3.2f);
    }

    void InvokeSpawn()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, 2);
    }
}
