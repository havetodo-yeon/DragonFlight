using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 스피드
    public float moveSpeed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        // x축 값 설정 = vector 방향 * 시간 * 스피드
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);
/*        if(transform.position.x >= -2.5 && transform.position.x <= 2.5)
        {
        }
        if(transform.position.x < -2.5)
        {
            transform.position = new Vector3(-2.5f, transform.position.y, 0);
        }
        else if(transform.position.x > 2.5)
        {
            transform.position = new Vector3(2.5f, transform.position.y, 0);
        }
*/


    }
}
