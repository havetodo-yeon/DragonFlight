using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도를 지정해 줍니다.
    public float moveSpeed = 1.3f;

    private void Start()
    {
        
    }

    void Update()
    {
        // 움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;

        // 움직임을 반영
        transform.Translate(0, -distanceY, 0);
    }

    // 화면 밖으로 나가면, 카메라에서 안보이면
    private void OnBecameInvisible()
    {
        Destroy(gameObject);    // 객체 삭제
    }
}
