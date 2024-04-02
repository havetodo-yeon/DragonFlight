using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // 싱글톤
    public static SoundManager instance;    // 자기 자신을 변수로 만들고 어디서든 가져다가 사용할 수가 있다.

    AudioSource myAudio;    // AudioSource 컴포넌트를 변수로 담는다.

    public AudioClip soundExplosion;    // 재생할 소리를 변수로 담는다
    public AudioClip soundDie;  // 죽는 사운드

    private void Awake()
    {
        if(instance == null)    // instance가 비어있는지 검사합니다.
        {
            instance = this;    // 자기 참조 객체
        }
    }

    void Start()
    {
        myAudio = GetComponent<AudioSource>();  // AudioSource 컴포넌트 가져오기
    }

    public void PlayerSound()
    {
        myAudio.PlayOneShot(soundExplosion);
    }

    public void DieSound()
    {
        myAudio.PlayOneShot(soundDie);
    }



}
