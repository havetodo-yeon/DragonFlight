using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ������ �ӵ��� ������ �ݴϴ�.
    public float moveSpeed = 1.3f;

    private void Start()
    {
        
    }

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
