using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Boss : MonoBehaviour
{
    public GameObject attackPoint;
    public GameObject BossBullet;

    public GameObject bossDying;

    public float moveSpeed = 1.0f;

    public int bossHealth = 150;

    public bool bossStart = false;

    private void Start()
    {
        BossSpawn();
        StartCoroutine("Spawn");
        GameManager.Instance.bossSlider.value = bossHealth;
    }

    public void BossSpawn()
    {
        SpawnManager2.spawnCheck = false;
        // SpawnManager2.spawnTime = 5;
    }

    IEnumerator Spawn()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        while(transform.position.y > 3.0f)
        {
            float distanceY = moveSpeed * Time.deltaTime;
            transform.Translate(0, -distanceY, 0);
            yield return new WaitForSeconds(Time.deltaTime);
        }
        GameManager.Instance.EventText("Start!");

        StartCoroutine(BossAttack());
/*        Transform child = transform.Find("Effect");
        if (child != null)
        {
            Destroy(child.gameObject); // 자식 오브젝트 파괴
        }
*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 보스가 부딪혔다.
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // 적 체력 깎기
            bossHealth -= 10;
            GameManager.Instance.bossSlider.value -= 10;
            Destroy(collision.gameObject);

            if(bossHealth <= 0)
            {
                Instantiate(bossDying);
                Destroy(gameObject);
                GameManager.Instance.bossHealth.SetActive(false);
                // GameManager.Instance.EventText("Clear><!");
                GameManager.Instance.AddScore(1000);
                GameManager.Instance.GameOver();
            }
        }
    }

    IEnumerator BossAttack()
    {
        GameManager.Instance.bossHealth.SetActive(true);
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        while (true)
        {
            /*            int i = Random.Range(0, 3);
                        switch (i)
                        {
                            case 0:
                                GameObject clone = Instantiate(BossBullet, attackPoint.transform.position, Quaternion.identity);
                                break;
                            case 1:
                                Debug.Log("BossAttack 2");
                                break;
                            default:
                                Debug.Log("Continue");
                                break;
                        }*/
            GameObject clone = Instantiate(BossBullet, attackPoint.transform.position, Quaternion.identity);

            yield return new WaitForSeconds(0.8f);
        }
    }



}
