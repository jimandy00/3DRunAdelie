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
    public int currentScore;

    // 최고 점수 UI
    public Text bestScoreUI;

    // 최고 점수
    public int bestScore;

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
