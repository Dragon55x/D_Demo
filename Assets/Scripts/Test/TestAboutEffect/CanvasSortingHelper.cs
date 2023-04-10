using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasSortingHelper : MonoBehaviour
{
    public Canvas canvas;
    public int SortingOrder  = 0;
    // Start is called before the first frame update
    void Start()
    {
        canvas.overrideSorting = true;
        canvas.sortingOrder = 4;
        SortingOrder = canvas.sortingOrder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
