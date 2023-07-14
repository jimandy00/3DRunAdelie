using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 스노우볼
// 위로 움직임
// 부딪히면 충돌

public class Snowball : MonoBehaviour
{

    // 속도
    public float speed = 10f;

    // 충돌 시작
    private void OnCollisionEnter(Collision collision)
    {
        // 상대 죽고
        Destroy(collision.gameObject);

        // 나 죽고
        Destroy(gameObject);
    }



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
