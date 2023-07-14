using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �÷��̾ ��ư�� ������ ����캼 �߻�

public class FireSnowball : MonoBehaviour
{

    // ����캼 ����
    public GameObject snowballFactory;

    // �ѱ�
    public GameObject firePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���� Fire1 ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // ���忡�� ����캼�� �����
            GameObject snowball = Instantiate(snowballFactory);

            // ������� ����� ���� �ѱ��� ��ġ���Ѷ�
            snowball.transform.position = firePosition.transform.position;
        }
    }
}
