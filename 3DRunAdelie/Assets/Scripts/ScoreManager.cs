using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// ���ʹ̸� ���̸�
// ������ �ö󰡰�
// ������ ȭ�鿡 ǥ��

public class ScoreManager : MonoBehaviour
{
    // ���� ���� UI
    public Text currentScoreUI;

    // ���� ����
    private int currentScore;

    // �ְ� ���� UI
    public Text bestScoreUI;

    // �ְ� ����
    private int bestScore;

    // currentScore�� �� �ְ� ȭ�鿡 ǥ��
    public void setScore(int value)
    {
        // �� �Ҵ�
        currentScore = value;
        // ���� ǥ��
        currentScoreUI.text = "�������� : " + currentScore;

        // �ְ� ���� ǥ��
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreUI.text = "�ְ����� : " + bestScore;

            // ������ ����
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
        // ��ǥ �ְ������� �ҷ��ͼ� ȭ�鿡 ���
        // 1. �ְ� ���� �ҷ��ͼ� bestScore�� ����
        bestScore = PlayerPrefs.GetInt("Best Score", 0);
        // 2. �ְ� ���� ȭ�鿡 ǥ��
        bestScoreUI.text = "�ְ����� : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
