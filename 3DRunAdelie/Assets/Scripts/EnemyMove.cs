using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
