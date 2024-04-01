using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].name);
        }
    }

    void Update()
    {
        
    }
}
