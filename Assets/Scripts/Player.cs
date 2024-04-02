using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 스피드
    public float moveSpeed = 3f;

    // 충돌 이펙트 2024-04-02
    public GameObject Collision;

    void Start()
    {
        
    }

    void Update()
    {
        // x축 값 설정 = vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            GameManager.Instance.MinusScore(10);
            GameObject go = Instantiate(Collision, transform.position, Quaternion.identity);
            Destroy(go, 1);
        }
    }



}
