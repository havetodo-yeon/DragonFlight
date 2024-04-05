using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 1.3f;
    public float score = 0;
    public float health = 10;

/*    // �� ü�� ���� 2024-04-02
    public GameObject Instance;
    public int enemyHealth = 1;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = gameObject;
        }
    }
*/
    void Update()
    {
        // �������� ������ �����
        float distanceY = moveSpeed * Time.deltaTime;

        // �������� �ݿ�
        transform.Translate(0, -distanceY, 0);
    }

    // ȭ�� ������ ������, ī�޶󿡼� �Ⱥ��̸�
    private void OnBecameInvisible()
    {
        Destroy(gameObject);    // ��ü ����
    }

}
