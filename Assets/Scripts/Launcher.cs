using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject bullet;   // 미사일 프리팹 가져올 변수

    void Start()
    {
        // InvokeReapeating("함수 이름", 초기 지연 시간, 지연할 시간);
        InvokeRepeating("Shoot", 0.5f, 1f);
    }
    void Shoot()
    {
        // 미사일 프리팹, 런처 포지션, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);
        audioSource.Play();
    }

}
