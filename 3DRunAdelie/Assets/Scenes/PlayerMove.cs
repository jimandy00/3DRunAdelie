using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����� �̵�

public class PlayerMove : MonoBehaviour
{

    public float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �Է�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // ����
        Vector3 dir = new Vector3(h, v, 0);

        // �̵�
        transform.position += dir * speed * Time.deltaTime;
    }
}
