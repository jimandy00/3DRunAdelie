using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// enemy 이동
// 30% 확률로 플레이어 방향으로 돌격
// 공격에 닿으면 폭발

public class EnemyMove : MonoBehaviour
{
    Vector3 dir;

    public float speed = 7f;

    // 폭발 효과 공장
    public GameObject explosionFactory;

    // 닿으면 폭발하는 method
    private void OnCollisionEnter(Collision collision)
    {
        // 폭발 공장에서 효과 제작
        GameObject explosion = Instantiate(explosionFactory);

        explosion.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);

        // 적이 죽으면 점수 증가
        // Scene에서 GameObjact 가져오기
        GameObject smObject = GameObject.Find("ScoreManager");
        // GameObjact에 있는 컴포넌트 가져오기
        ScoreManager scoreManager = smObject.GetComponent<ScoreManager>();
        // 값 할당
        scoreManager.currentScore++;
        // 점수 표시
        scoreManager.currentScoreUI.text = "현재점수 : " + scoreManager.currentScore;

        // 최고 점수 표시
        if (scoreManager.currentScore > scoreManager.bestScore)
        {
            scoreManager.bestScore = scoreManager.currentScore;

            scoreManager.bestScoreUI.text = "최고점수 : " + scoreManager.bestScore;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        int randValue = Random.Range(0, 10);

        // 만약 3보다 작으면 플레이어 방향으로
        if (randValue < 3)
        {
            // target 찾기
            GameObject player = GameObject.Find("Player");

            // 방향
            dir = player.transform.position - transform.position;

            // 방향의 크기 1로 만듦
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
        // 이동
        transform.position += speed * dir * Time.deltaTime;
    }
}
