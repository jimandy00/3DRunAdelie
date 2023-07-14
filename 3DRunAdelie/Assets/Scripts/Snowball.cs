using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����캼
// ���� ������
// �ε����� �浹

public class Snowball : MonoBehaviour
{

    // �ӵ�
    public float speed = 10f;

    // �浹 ����
    private void OnCollisionEnter(Collision collision)
    {
        // ��� �װ�
        Destroy(collision.gameObject);

        // �� �װ�
        Destroy(gameObject);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        Vector3 dir = Vector3.up;

        // �̵�
        transform.position += dir * speed * Time.deltaTime;
    }
}
