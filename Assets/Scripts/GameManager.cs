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
    public Text MeterText;  // 미터기

    public Text bossEvent;  // 보스 알림

    public int score = 0;  // 점수 관리
    int m = 0;  // 미터기

    public GameObject bossHealth;
    public Slider bossSlider;

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

    public void MinusScore(int num)   // 점수를 감소해주는 함수
    { 
        score -= num;
        scoreText.text = "Score : " + score;    // 텍스트에 반영
    }

    // 코루틴 통해 시작할 때 카운드다운
    void Start()
    {
        StartCoroutine("StartGame");
        StartCoroutine("MeterCheck");
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

    public GameObject boss;

    public void BossSpawn()
    {
        EventText("Boss!");
        Instantiate(boss, boss.transform.position, Quaternion.identity);
    }


    IEnumerator MeterCheck()
    {
        while(m >= 0)
        {
            MeterText.text = m.ToString() + " M";
            yield return new WaitForSeconds(1f);
            m++;
            if(m == 7f)
            {
                BossSpawn();
            }
        }
    }

    public void EventText(string text)
    {
        bossEvent.text = text;

        StartCoroutine("EventAlarm");

        bossEvent.color = new Color(1, 1, 0, 1);
    }

    IEnumerator EventAlarm()
    {
        float startAlpha = 1;
        while (startAlpha > 0.0f)
        {
            startAlpha -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            bossEvent.color = new Color(1, 1, 0, startAlpha);
        }
    }

    public Image image;

    IEnumerator Fade()
    {
        float startAlpha = 0;
        while (startAlpha < 0.8f)
        {
            startAlpha += 0.01f;
            yield return new WaitForSeconds(0.01f);
            image.color = new Color(0, 0, 0, startAlpha);
        }
    }
    public void GameOver()
    {
        StartCoroutine("Fade");
        bossEvent.text = "Clear!!!";
        bossEvent.color = new Color(1, 1, 1, 1);
        StopCoroutine("MeterCheck");
        Launcher.goShoot = false;
        Invoke("Score", 2);
    }

    public void Score()
    {
        bossEvent.text = "";
        MeterText.alignment = TextAnchor.LowerCenter;
        MeterText.fontSize = 100;
        scoreText.alignment = TextAnchor.MiddleCenter;
        scoreText.fontSize = 120;
        scoreText.color = new Color(1, 1, 1, 1);
    }

    public void GetHurt(GameObject gameObject)
    {
        StartCoroutine(BeingRed(gameObject));
    }
    IEnumerator BeingRed(GameObject gameObject)
    {
        float startAlpha = 0;
        SpriteRenderer objectColor = gameObject.GetComponent<SpriteRenderer>();
        objectColor.color = new Color(1, 0, 0, 1);
        while (startAlpha < 1.0f)
        {
            startAlpha += 0.08f;
            yield return new WaitForSeconds(0.01f);
            if (objectColor == null) // objectColor가 null인지 체크
                yield break; // null이면 코루틴 종료
            objectColor.color = new Color(1, startAlpha, startAlpha, 1);
        }
    }



}

