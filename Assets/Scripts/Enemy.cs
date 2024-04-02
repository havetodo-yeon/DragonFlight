using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ��� ������ �ݴϴ�.
    public static float moveSpeed = 1.3f;

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
