using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DG
{
    public class ManagerBase<T> where T : new()
    {
        static T instacne;
        public static T Instance
        {
            get
            {
                if(instacne == null)
                {
                    instacne = new T();
                }
                return instacne;
            }
        }

        public virtual void Init() { }

        public virtual void Update() { }

        public virtual void LateUpdate() { }

        public virtual void OnDestroy() { }

    }
}