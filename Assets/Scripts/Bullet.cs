using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 0.45f;


    public GameObject explosionAnimation;
    public GameObject enemyDieSound;

    void Start()
    {
        
    }

    void Update()
    {
        // y�� �̵�
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    // ȭ�� ������ ������ �Ⱥ��� ��� ȣ���� �Ǵ� �Լ�
    private void OnBecameInvisible()
    {
        // �̻��� ����
        Destroy(gameObject);
    }

    // Ʈ���� �浹   OnTriggerEnter
    // �ݸ��� �浹   OnColliderEnter
    // enter   �浹 ���� �� 1��
    // stay    ��� �浹 ���� �ȿ�
    // exit    �浹 ��� �� 1��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // �̻��ϰ� ���� �ε�����.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject newExplosion = Instantiate(explosionAnimation, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            GameObject newEnemyDie = Instantiate(enemyDieSound, new Vector3(transform.position.x, transform.position.y, 0f), Quaternion.identity);
            // �� �����
            Destroy(collision.gameObject);

            // �̻��� �����
            Destroy(gameObject);

            Destroy(newExplosion, 1.5f);
            Destroy(newEnemyDie, 1.5f);
        }
    }


}
