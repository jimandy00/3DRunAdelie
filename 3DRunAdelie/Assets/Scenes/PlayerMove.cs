using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 사용자 이동

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
        // 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 방향
        Vector3 dir = new Vector3(h, v, 0);

        // 이동
        transform.position += dir * speed * Time.deltaTime;
    }
}
