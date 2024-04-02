using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글톤
    public static GameManager Instance;
    public Text scoreText;  // 점수를 표시하는 객체 에디터에서 받아오기
    public Text startText;  // 게임 시작 전 3, 2, 1

    int score = 0;  // 점수 관리

    private void Awake()
    {
        if (Instance == null)    // null 체크
        {
            Instance = this;    // 자기 자신 인스턴스해서 저장
        }
    }

    public void AddScore(int num)   // 점수를 추가해주는 함수
    { 
        score += num;
        scoreText.text = "Score : " + score;    // 텍스트에 반영
    }

    // 코루틴 통해 시작할 때 카운드다운
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
