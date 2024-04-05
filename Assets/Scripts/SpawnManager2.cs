using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    // 자료구조
    public List<GameObject> DragonLevel = new List<GameObject>();

    public static bool spawnCheck = true;
    public static int spawnTime = 1;

    public float ss = -2;
    public float es = 2;

    IEnumerator SpawnDragon()
    {
        while (spawnCheck)
        {
            yield return new WaitForSeconds(2f);
            for(int i = 0; i < 3; i++)
            {
                int x = (int)Random.Range(ss, es);
                Vector2 v = new Vector2(x, transform.position.y);
                Instantiate(DragonLevel[Random.Range(0, 3)], v, Quaternion.identity);
            }
        }
    }



/*    public void SpawnEnemy()
    {
        if (spawnCheck)
        {
            // 0 ~ 1 둘 중 하나
            int ran = Random.Range(0, DragonLevel.Count);

            Instantiate(DragonLevel[ran], DragonLevel[ran].transform.position, Quaternion.identity);
        }
        else
        {
            CancelInvoke("SpawnEnemy");
        }
    }
*/

    void Start()
    {
        spawnCheck = true;
        StartCoroutine(SpawnDragon());
    }

/*    void InvokeSpawn()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, 2);
    }
*/
}
