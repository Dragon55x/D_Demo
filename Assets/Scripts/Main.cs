using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace DG
{
    public class Main : MonoBehaviour
    {
        public bool IsTest = false;

        LuaManager mLuaMgr;
        ResourceManager mResourceMgr;

        private void Awake()
        {   
            InitMgrs();
            StartGame();
        }

        void InitMgrs()
        {
            mLuaMgr = LuaManager.Instance;
            mResourceMgr = ResourceManager.Instance;

            mLuaMgr.Init();
            mResourceMgr.Init();
        }

        void StartGame()
        {
            mLuaMgr.LuaStart();
        }

        private void Update()
        {
            mLuaMgr.Update();
            mResourceMgr.Update();
        }

        private void LateUpdate()
        {
            mLuaMgr.LateUpdate();
            mResourceMgr.LateUpdate();
        }

        private void OnDestroy()
        {
            mLuaMgr.OnDestroy();
            mResourceMgr.OnDestroy();
        }
    }
}