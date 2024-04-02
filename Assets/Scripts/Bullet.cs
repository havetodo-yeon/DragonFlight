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
            // ���� ����Ʈ 2024-04-02
            GameObject go = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(go, 1);

            // �� ����� -> �� ü�� ��� 2024-04-02
            Destroy(collision.gameObject);

            // ���� 2024-04-02
            SoundManager.instance.DieSound();

            // ���� ȹ�� 2024-04-02
            GameManager.Instance.AddScore(100);


            // �̻��� �����
            Destroy(gameObject);
        }
    }


}
