using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectHelper : MonoBehaviour
{
    private Renderer[] effects;
    // Start is called before the first frame update
    void Start()
    {
        effects = this.transform.GetComponentsInChildren<Renderer>(true);
        for (int i = 0; i < effects.Length; i++)
        {
            effects[i].sortingOrder = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
