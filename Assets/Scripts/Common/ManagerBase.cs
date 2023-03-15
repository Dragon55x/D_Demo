using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DG
{
    public class ManagerBase
    {
        public virtual void Init() { }

        public virtual void Update() { }

        public virtual void LateUpdate() { }

        public virtual void OnDestroy() { }

    }
}