using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // ��ũ���� �Ǵ� ��׶��� 
    public float scrollSpeed = 1f;
    private Material myMaterial;

    private void Start()
    {
        // ���͸��� ��������
        myMaterial = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        // Offset ���͸������� ��������
        Vector2 newOffset = myMaterial.mainTextureOffset;

        // ���Ӱ� Offset �ٲ��ֱ�
        // y �κ� ���� �ӵ��� ������ �����ؤ� �����ݴϴ�.
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        // ���͸��� �����¿� ���� �־��ش�.
        myMaterial.mainTextureOffset = newOffset;

    }

}
