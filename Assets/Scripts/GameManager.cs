using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // �̱���
    public static GameManager Instance;
    public Text scoreText;  // ������ ǥ���ϴ� ��ü �����Ϳ��� �޾ƿ���
    public Text startText;  // ���� ���� �� 3, 2, 1

    int score = 0;  // ���� ����

    private void Awake()
    {
        if (Instance == null)    // null üũ
        {
            Instance = this;    // �ڱ� �ڽ� �ν��Ͻ��ؼ� ����
        }
    }

    public void AddScore(int num)   // ������ �߰����ִ� �Լ�
    { 
        score += num;
        scoreText.text = "Score : " + score;    // �ؽ�Ʈ�� �ݿ�
    }

    // �ڷ�ƾ ���� ������ �� ī���ٿ�
    void Start()
    {
        StartCoroutine("StartGame");
    }

    IEnumerator StartGame()
    {
        int i = 3;

        while(i > 0)
        {
            startText.text = i.ToString();
            yield return new WaitForSeconds(1);

            i--;

            if(i == 0)
            {
                startText.gameObject.SetActive(false);
            }

        }
    }

}
