using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleUnit : MonoBehaviour
{
    //������ ���������� ��� ���������� Rigitbody
    public Rigidbody rb;

    void Start()
    {
        //���������� ������������� � �������� ������� ��������� Rigidbody � ����������
        rb = GetComponent<Rigidbody>();
    }

    public void PutInHisPlace()
    {
        //������� ��������� � �������� �������
        Destroy(rb);
    }
}

