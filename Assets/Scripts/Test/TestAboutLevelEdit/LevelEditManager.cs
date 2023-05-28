using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class LevelEditManager : MonoBehaviour
{
    Transform _uiRoot;
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
        _uiRoot = GameObject.Find("UI_Root").transform;
        _setLevelNode = _uiRoot.Find("UICanvas/SetLevel").transform;
        _operateNode = _uiRoot.Find("UICanvas/Operate").transform;

        InitLevelConfig();
        OpenSetLevel(true);

        Test();
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

    private void Test()
    {
        Button _openAssetBtn = _uiRoot.Find("UICanvas/Open_Asset_Btn").GetComponent<Button>();
        _openAssetBtn.onClick.AddListener(() =>
        {
            AssetDatabase.OpenAsset(AssetDatabase.LoadMainAssetAtPath("Assets/Prefab/UI_Root.prefab"));
        });
    }
}


