using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// enemy �̵�
// 30% Ȯ���� �÷��̾� �������� ����
// ���ݿ� ������ ����

public class EnemyMove : MonoBehaviour
{
    Vector3 dir;

    public float speed = 7f;

    // ���� ȿ�� ����
    public GameObject explosionFactory;

    // ������ �����ϴ� method
    private void OnCollisionEnter(Collision collision)
    {
        // ���� ���忡�� ȿ�� ����
        GameObject explosion = Instantiate(explosionFactory);

        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);

        // ���� ������ ���� ����
        // Scene���� GameObjact ��������
        GameObject smObject = GameObject.Find("ScoreManager");
        // GameObjact�� �ִ� ������Ʈ ��������
        ScoreManager scoreManager = smObject.GetComponent<ScoreManager>();
        // �� �Ҵ�
        scoreManager.currentScore++;
        // ���� ǥ��
        scoreManager.currentScoreUI.text = "�������� : " + scoreManager.currentScore;

        // �ְ� ���� ǥ��
        if (scoreManager.currentScore > scoreManager.bestScore)
        {
            scoreManager.bestScore = scoreManager.currentScore;

            scoreManager.bestScoreUI.text = "�ְ����� : " + scoreManager.bestScore;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        int randValue = Random.Range(0, 10);

        // ���� 3���� ������ �÷��̾� ��������
        if (randValue < 3)
        {
            // target ã��
            GameObject player = GameObject.Find("Player");

            // ����
            dir = player.transform.position - transform.position;

            // ������ ũ�� 1�� ����
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // �̵�
        transform.position += speed * dir * Time.deltaTime;
    }
}
