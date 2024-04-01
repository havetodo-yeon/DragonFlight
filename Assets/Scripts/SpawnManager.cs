using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool enableSpawn = false;
    public List<GameObject> enemy = new List<GameObject>();

    // 적 생성하는 함수
    public void SpawnEnemy()
    {
        // float randomX = Random.Range(-2f, 2f);  // 적이 나타날 x좌표 랜덤으로 생성
        if(enableSpawn)
        {
            // 적을 생성한다.randomX 랜덤한 x값
            for(int i = 0; i < enemy.Count; i++)
            {
                Instantiate(enemy[1], new Vector3((float)(-2 + i), transform.position.y, 0f), Quaternion.identity);
            }
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2f);
    }

    /*    public GameObject enemyPrefab;
        private void Start()
        {
            StartCoroutine("EnemyCome");
        }

        IEnumerator EnemyCome()
        {
            float spawnTime = 2f;
            while (true)
            {
                yield return new WaitForSeconds(spawnTime);
                GameObject enemyClone = Instantiate(enemyPrefab, new Vector3(Random.Range(-2f, 2f), 4, 0), Quaternion.identity);
            }
        }
    */
}
