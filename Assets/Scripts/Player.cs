using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // ���ǵ�
    public float moveSpeed = 3f;

    void Start()
    {
        
    }

    void Update()
    {
        // x�� �� ���� = vector ���� * �ð� * ���ǵ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        // x�� �̵� ����
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
