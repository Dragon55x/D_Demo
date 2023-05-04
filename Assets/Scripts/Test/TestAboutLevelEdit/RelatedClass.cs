using System;
using UnityEngine;

public class RelatedClass
{
        
}

public class CarData
{
    public int Type;
    public int Num;

    public CarData(int type, int num)
    {
        this.Type = type;
        this.Num = num;
    }

    public override string ToString()
    {
        return $"[{this.Type}, {this.Num}]";
    }
}

public class ShelfLayer
{
    public int Width;
    public Vector3 Pos;
    public Vector3 Rotate;
    public int Type;
    public int LimitCar;

    public ShelfLayer(int width, Vector3 pos, Vector3 rotate, int type = 1, int limit = -1)
    {
        this.Width = width;
        this.Pos = pos;
        this.Rotate = rotate;
        this.Type = type;
        this.LimitCar = limit;
    }
}


