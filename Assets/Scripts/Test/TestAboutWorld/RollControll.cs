using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollControll : MonoBehaviour
{
    [Header("移动速度")]
    public float movespeed = 5f;
    [Header("转身速度")]
    public float turnspeed = 0.5f;

    private float hor;
    private float ver;

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        //前后移动
        transform.position += ver * transform.forward * Time.deltaTime * movespeed;
        //左右转身
        transform.eulerAngles += hor * Vector3.up * turnspeed;
    }
}
