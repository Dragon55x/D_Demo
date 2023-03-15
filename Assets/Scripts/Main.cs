using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DG
{
    public class Main : MonoBehaviour
    {
        List<ManagerBase> ManagerList;


        private void Awake()
        {
            InitMgrs();
            StartGame();
        }

        void InitMgrs()
        {
            ManagerList = new List<ManagerBase>();
        }

        void StartGame()
        {
            LuaMgr.LuaStart();
        }

        private void Update()
        {
            foreach(ManagerBase mgr in ManagerList)
            {
                mgr.Update();
            }
        }

        private void LateUpdate()
        {
            foreach (ManagerBase mgr in ManagerList)
            {
                mgr.LateUpdate();
            }
        }

        private void OnDestroy()
        {
            foreach (ManagerBase mgr in ManagerList)
            {
                mgr.OnDestroy();
            }
        }

        LuaManager luaMgr;
        LuaManager LuaMgr
        {
            get
            {
                if (luaMgr == null)
                {
                    luaMgr = LuaManager.Create(this);
                    luaMgr.Init();
                    ManagerList.Add(luaMgr);
                }
                return luaMgr;
            }
        }

        ResourceManager resourceManager;
        ResourceManager ResourceManager
        {
            get
            {
                if (resourceManager == null)
                {
                    resourceManager = ResourceManager.Create(this);
                    ManagerList.Add(luaMgr);
                }
                return resourceManager;
            }
        }
    }
}