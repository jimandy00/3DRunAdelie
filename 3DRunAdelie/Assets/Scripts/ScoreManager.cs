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
    public int currentScore;

    // �ְ� ���� UI
    public Text bestScoreUI;

    // �ְ� ����
    public int bestScore;

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
