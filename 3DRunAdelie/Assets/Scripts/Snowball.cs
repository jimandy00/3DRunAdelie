using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����캼 ������
public class Snowball : MonoBehaviour
{

    // �ӵ�
    public float speed = 10f;

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
