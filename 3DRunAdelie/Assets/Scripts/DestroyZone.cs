using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Destroy zone에 물체가 감지되면 물체를 삭제

public class DestroyZone : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
