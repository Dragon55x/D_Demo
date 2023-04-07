using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace DG
{
    public class NetManager : ManagerBase<NetManager>
    {

        public override void Init()
        {
            //StartCoroutine(SendGetRequest());
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
                Debug.Log("Get:请求成功");
                Debug.Log("下载的数据：" + uwr.downloadedBytes);
            }
        }


        public override void Update()
        {

        }
    }
}

