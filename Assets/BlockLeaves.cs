using System.Collections;
using System;
using UnityEngine;

[Serializable]
public class BlockLeaves : Block
{
    public BlockLeaves()
        : base()
    {

    }

    public override string TextureName(Direction direction)
    {
        string textureName;

        textureName = "tile_leaves";
        return textureName;
    }

    public override bool IsSolid(Direction direction)
    {
        return false;
    }
}
