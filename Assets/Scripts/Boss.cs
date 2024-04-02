using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boss : MonoBehaviour
{
    GameManager gameManager;
    public float moveSpeed = 1.0f;

    public int bossHealth = 150;

    public bool bossStart = false;

    private void Start()
    {
        BossSpawn();
        StartCoroutine("Spawn");
    }

    public void BossSpawn()
    {
        SpawnManager2.spawnCheck = false;
        Debug.Log("hello");
        // SpawnManager2.spawnTime = 5;
    }


    IEnumerator Spawn()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        while(transform.position.y > 3.0f)
        {
            yield return new WaitForSeconds(Time.deltaTime);
            float distanceY = moveSpeed * Time.deltaTime;
            transform.Translate(0, -distanceY, 0);
        }
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        GameManager.Instance.EventText("Start!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 보스가 부딪혔다.
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // 적 체력 깎기
            bossHealth -= 10;
            Destroy(collision.gameObject);

            if(bossHealth <= 0)
            {
                Destroy(gameObject);
                // GameManager.Instance.EventText("Clear><!");
                GameManager.Instance.AddScore(1000);
            }
        }
    }



}
