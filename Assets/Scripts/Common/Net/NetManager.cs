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
            else //����ɹ�
            {
                Debug.Log("Get:����ɹ�");
                Debug.Log("���ص����ݣ�" + uwr.downloadedBytes);
            }
        }


        public override void Update()
        {

        }
    }
}

