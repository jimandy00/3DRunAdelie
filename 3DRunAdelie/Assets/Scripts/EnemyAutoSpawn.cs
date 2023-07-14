using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// enemy �ڵ� ����

// �ð��� �帣��
// �ش� ��ġ��
// ���� �����ϰ�
// �� ��ġ ���� or �Ʒ��� ��������.

public class EnemyAutoSpawn : MonoBehaviour
{

    // ���� �ð�
    float currentTime;

    // ���� �ð�
    public float createTime = 1;

    // �� ����
    public GameObject enemyFactory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        }
    }
}
