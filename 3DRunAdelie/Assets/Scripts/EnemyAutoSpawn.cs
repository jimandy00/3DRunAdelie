using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// enemy �ڵ� ����

// �ð��� �帣��
// �ش� ��ġ��
// ���� �����ϰ� (���� �ð�)
// �� ��ġ ���� or �Ʒ��� ��������.

public class EnemyAutoSpawn : MonoBehaviour
{

    // ���� �ð�
    float currentTime;

    // ���� �ð�
    float createTime;

    // �ּ� �ð�
    float minTime = 1f;

    // �ִ� �ð�
    float maxTime = 5f;

    float resetCreateTime()
    {
        return createTime = UnityEngine.Random.Range(minTime, maxTime + 1);
    }

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime + 1);
    }

    // �� ����
    public GameObject enemyFactory;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        // ������ �帣�ٰ�
        currentTime += Time.deltaTime;

        // ���� ���� �ð��� �Ǹ�
        if (currentTime > createTime)
        {
            // �� ���忡�� ���� ����
            GameObject enemy = Instantiate(enemyFactory);

            // ���� �� ��ġ�� �̵�
            enemy.transform.position = transform.position;

            // ����ð� 0���� �ʱ�ȭ
            currentTime = 0;

            // ���� ������ �� ���� �ð� �ٽ� ����
            createTime = resetCreateTime();
        }
    }
}
