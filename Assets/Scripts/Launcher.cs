using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;   // 미사일 프리팹 가져올 변수
    public static bool goShoot = true;

    void Start()
    {
        // InvokeReapeating("함수 이름", 초기 지연 시간, 지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        if(goShoot ==  false)
        {
            CancelInvoke("Shoot");
        }
        // 미사일 프리팹, 런처 포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);

        // 사운드 플레이 2024-04-02 
        SoundManager.instance.PlayerSound();
    }


}
