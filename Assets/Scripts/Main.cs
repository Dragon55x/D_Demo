using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DG
{
    public class Main : MonoBehaviour
    {
        private void Awake()
        {
            InitMgrs();
            StartGame();
        }

        void InitMgrs()
        {
            LuaManager.Init();
        }

        void StartGame()
        {
            LuaManager.LuaStart();
        }

        private void Update()
        {
            LuaManager.Update();
            ResourceManager.Update();
        }

        private void LateUpdate()
        {
            
        }

        private void OnDestroy()
        {
            
        }       
    }
}