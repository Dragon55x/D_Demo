using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DG
{
    public class ResourceManager : ManagerBase
    {
        static ResourceManager instance;
        ResourceManager() { }
        public static ResourceManager Create(object caller)
        {
            Debug.Assert(caller.GetType() != typeof(Main), "Only Main can call this method once!");
            instance = new ResourceManager();
            return instance;
        }


        // Update is called once per frame
        public override void Update()
        {

        }
    }
}
