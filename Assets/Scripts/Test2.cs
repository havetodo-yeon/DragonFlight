using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // �ڷᱸ��
    public List<GameObject> list = new List<GameObject>();

    public void SpawnEnemy()
    {
        // 0 ~ 1 �� �� �ϳ�
        int ran = Random.Range(0, list.Count);

        Instantiate(list[ran], list[ran].transform.position, Quaternion.identity);
    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2);
    }

    void Update()
    {
        
    }
}
