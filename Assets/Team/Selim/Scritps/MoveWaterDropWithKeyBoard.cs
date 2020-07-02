using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWaterDropWithKeyBoard : MonoBehaviour
{
    [SerializeField]
    TailInterface _useTail;

   
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        _useTail.SetHorizontal(inputHorizontal);
        _useTail.SetVertical(inputVertical);
    }
}
