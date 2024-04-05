using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   // �̻��� ������ ������ ����
    public static bool goShoot = true;

    void Start()
    {
        // InvokeReapeating("�Լ� �̸�", �ʱ� ���� �ð�, ������ �ð�);
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        if(goShoot ==  false)
        {
            CancelInvoke("Shoot");
        }
        // �̻��� ������, ��ó ������, ���Ⱚ ����
        Instantiate(bullet, transform.position, Quaternion.identity);

        // ���� �÷��� 2024-04-02 
        SoundManager.instance.PlayerSound();
    }


}
