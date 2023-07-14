using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 플레이어가 버튼을 누르면 스노우볼 발사

public class FireSnowball : MonoBehaviour
{

    // 스노우볼 공장
    public GameObject snowballFactory;

    // 총구
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 만약 Fire1 버튼이 눌리면
        if (Input.GetButtonDown("Fire1"))
        {
            // 공장에서 스노우볼을 만들고
            GameObject snowball = Instantiate(snowballFactory);

            // 만들어진 스노우 볼을 총구로 위치시켜라
            snowball.transform.position = firePosition.transform.position;
        }
    }
}
