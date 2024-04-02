using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 움직일 속도를 지정해 줍니다.
    public static float moveSpeed = 1.3f;

/*    // 적 체력 설정 2024-04-02
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
