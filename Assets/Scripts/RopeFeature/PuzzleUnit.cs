using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleUnit : MonoBehaviour
{
    //создаём переменную для компонента Rigitbody
    public Rigidbody rb;

    void Start()
    {
        //записываем прикрепленный к игровому объекту компонент Rigidbody в переменную
        rb = GetComponent<Rigidbody>();
    }

    public void PutInHisPlace()
    {
        //удаляем компонент с игрового объекта
        Destroy(rb);
    }
}

