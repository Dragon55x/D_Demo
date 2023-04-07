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
            
            TestFunc();
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

        void TestFunc()
        {
            StartCoroutine(SendGetRequest());
        }

        IEnumerator SendGetRequest()
        {
            UnityWebRequest uwr = UnityWebRequest.Get("http://www.baidu.com");
            yield return uwr.SendWebRequest();
            if (uwr.isHttpError || uwr.isNetworkError)
            {
                Debug.Log(uwr.error);
            }
            else //请求成功
            {
                Debug.Log(uwr.result);
                Debug.Log("Get:请求成功");
                Debug.Log("下载的数据：" + uwr.downloadedBytes);
            }
        }
    }
}