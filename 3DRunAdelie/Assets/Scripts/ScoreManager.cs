using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// 에너미를 죽이면
// 점수가 올라가고
// 점수를 화면에 표시

public class ScoreManager : MonoBehaviour
{
    // 현재 점수 UI
    public Text currentScoreUI;

    // 현재 점수
    private int currentScore;

    // 최고 점수 UI
    public Text bestScoreUI;

    // 최고 점수
    private int bestScore;

    // currentScore에 값 넣고 화면에 표시
    public void setScore(int value)
    {
        // 값 할당
        currentScore = value;
        // 점수 표시
        currentScoreUI.text = "현재점수 : " + currentScore;

        // 최고 점수 표시
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreUI.text = "최고점수 : " + bestScore;

            // 서버에 저장
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }

    public int getScore()
    {
        return currentScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        // 목표 최고점수를 불러와서 화면에 출력
        // 1. 최고 점수 불러와서 bestScore에 대입
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        // 2. 최고 점수 화면에 표시
        bestScoreUI.text = "최고점수 : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
