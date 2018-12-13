﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Script.BlockAndItem;

public abstract class Terrain
{
    public const int CEILING  = 300;//512
    public const int SEALEVEL = 256;

    protected int width;
    protected int maxHeight;
    protected int minFloor;

    protected Block[] blocks;

    public int Width
    {
        get{return width;}
    }
    public int MaxHeight
    {
        get{return maxHeight;}
    }
    public int MinFloor
    {
        get{return minFloor;}
    }
    public Block[] Blocks
    {
        get {return blocks; }
    }

    public Terrain( int width ,int maxHeight ,int minFloor = 256 )
    {
        this.width     = width;
        this.maxHeight = maxHeight;
        this.minFloor  = minFloor;
    }
}
