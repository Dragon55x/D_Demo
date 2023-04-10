using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class TestManControl : MonoBehaviour
{
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.overrideSorting = true;
        canvas.sortingOrder = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
