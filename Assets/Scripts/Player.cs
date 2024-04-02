using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���ǵ�
    public float moveSpeed = 3f;

    // �浹 ����Ʈ 2024-04-02
    public GameObject Collision;

    void Start()
    {
        
    }

    void Update()
    {
        // x�� �� ���� = vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // x�� �̵� ����
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
