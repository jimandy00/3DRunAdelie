using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ����
        Vector3 dir = Vector3.down;

        // �̵�
        transform.position += speed * dir * Time.deltaTime;
    }
}
