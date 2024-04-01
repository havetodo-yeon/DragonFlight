using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject bullet;   // �̻��� ������ ������ ����

    void Start()
    {
        // InvokeReapeating("�Լ� �̸�", �ʱ� ���� �ð�, ������ �ð�);
        InvokeRepeating("Shoot", 0.5f, 1f);
    }
    void Shoot()
    {
        // �̻��� ������, ��ó ������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);
        audioSource.Play();
    }

}
