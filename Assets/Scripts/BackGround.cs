using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // 스크롤이 되는 백그라운드 
    public float scrollSpeed = 1f;
    private Material myMaterial;

    private void Start()
    {
        // 머터리얼 가져오기
        myMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        // Offset 머터리엘에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;

        // 새롭게 Offset 바꿔주기
        // y 부분 값을 속도에 프레임 보정해ㅓ 더해줍니다.
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        // 머터리얼에 오프셋에 값을 넣어준다.
        myMaterial.mainTextureOffset = newOffset;

    }

}
