using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// enemy 자동 스폰

// 시간이 흐르면
// 해당 위치에
// 적을 스폰하고 (랜덤 시간)
// 내 위치 추적 or 아래로 떨어진다.

public class EnemyAutoSpawn : MonoBehaviour
{

    // 현재 시간
    float currentTime;

    // 생성 시간
    float createTime;

    // 최소 시간
    float minTime = 1f;

    // 최대 시간
    float maxTime = 5f;

    float resetCreateTime()
    {
        return createTime = UnityEngine.Random.Range(minTime, maxTime + 1);
    }

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime + 1);
    }

    // 적 공장
    public GameObject enemyFactory;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        // 시작이 흐르다가
        currentTime += Time.deltaTime;

        // 만약 일정 시간이 되면
        if (currentTime > createTime)
        {
            // 적 공장에서 적을 생성
            GameObject enemy = Instantiate(enemyFactory);

            // 적을 내 위치로 이동
            enemy.transform.position = transform.position;

            // 현재시간 0으로 초기화
            currentTime = 0;

            // 적이 생성된 후 생성 시간 다시 설정
            createTime = resetCreateTime();
        }
    }
}
