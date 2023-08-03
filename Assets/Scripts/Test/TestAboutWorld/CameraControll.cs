using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    //跟随的目标
    public Transform target;

    //方向向量
    private Vector3 dir;
    private void Start()
    {
        //计算摄像机指向玩家的方向偏移量
        dir = target.position - transform.position;
    }
    private void Update()
    {
        //时时刻刻计算摄像机的跟随位置
        Vector3 bastPos = target.position - dir;
        transform.position = bastPos;
    }
}
