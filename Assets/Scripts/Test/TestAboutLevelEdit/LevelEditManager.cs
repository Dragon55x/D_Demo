using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditManager : MonoBehaviour
{
    Transform _setLevelNode;
    Transform _operateNode;

    List<Puzzle> puzzles = new List<Puzzle>();

    public class Puzzle
    {
        // 关卡号
        public int Index;
        // 关卡限时
        public int Time;
        // 车辆倾斜角度
        public int Rotate;
        // 关卡车辆列表
        public List<CarData> Cars;
        // 搁板列表
        public List<ShelfLayer> Layers;
    }

    void Awake()
    {
        _setLevelNode = GameObject.Find("UI_Root/UICanvas/SetLevel").transform;
        _operateNode = GameObject.Find("UI_Root/UICanvas/Operate").transform;

        InitLevelConfig();
        OpenSetLevel(true);
    }

    void InitLevelConfig() {
        
    }

    public void OpenSetLevel(bool isOpen)
    {
        Debug.Log("OpenSetLevel");
        _setLevelNode.gameObject.SetActive(isOpen);

        if (_setLevelNode.gameObject.activeSelf)
        {
            _operateNode.gameObject.SetActive(false);
        }
    }

    public void OpenOperate(bool isOpen)
    {
        _operateNode.gameObject.SetActive(isOpen);

        if (_operateNode.gameObject.activeSelf)
        {
            _setLevelNode.gameObject.SetActive(false);
        }
    }

    public void SaveLevelConfig()
    {

    }
}


