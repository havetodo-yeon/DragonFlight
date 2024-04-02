using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;

    public GameObject explosion;

    public int attackSize = 1;

    void Update()
    {
        // y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // 화면 밖으로 나가면 안보일 경우 호출이 되는 함수
    private void OnBecameInvisible()
    {
        // 미사일 삭제
        Destroy(gameObject);
    }

    // 트리거 충돌   OnTriggerEnter
    // 콜리더 충돌   OnColliderEnter
    // enter   충돌 들어올 때 1번
    // stay    계속 충돌 범위 안에
    // exit    충돌 벗어날 때 1번
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 미사일과 적이 부딪혔다.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 폭발 이펙트 2024-04-02
            GameObject go = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(go, 1);

            // 적 지우기 -> 적 체력 깎기 2024-04-02
            Destroy(collision.gameObject);

            // 사운드 2024-04-02
            SoundManager.instance.DieSound();

            // 점수 획득 2024-04-02
            GameManager.Instance.AddScore(100);


            // 미사일 지우기
            Destroy(gameObject);
        }
    }


}
