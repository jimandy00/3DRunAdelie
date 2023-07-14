using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// enemy 이동
// 30% 확률로 플레이어 방향으로 돌격

public class EnemyMove : MonoBehaviour
{
    Vector3 dir;

    public float speed = 7f;
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
