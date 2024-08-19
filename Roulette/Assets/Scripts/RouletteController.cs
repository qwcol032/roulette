using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{

    float rotSpeed = 0;  // ȸ�� �ӵ�   

    void Start()
    {
    }

    void Update()
    {
        // ���콺�� ������ ȸ�� �ӵ��� �����Ѵ�
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = Random.Range(10, 15);
        }

        if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed = 0 - Random.Range(10, 15);
        }

        // ȸ�� �ӵ���ŭ �귿�� ȸ�� ��Ų��
        transform.Rotate(0, 0, this.rotSpeed);

        // �귿�� ���ӽ�Ų��(�߰�)
        this.rotSpeed *= 0.99f;
    }
}
