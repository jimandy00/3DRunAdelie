using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 스노우볼 움직임
public class Snowball : MonoBehaviour
{

    // 속도
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 방향
        Vector3 dir = Vector3.up;

        // 이동
        transform.position += dir * speed * Time.deltaTime;
    }
}
