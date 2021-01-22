using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockStone : Block
{

    public BlockStone()
        : base()
    {

    }

    public override string TextureName(Direction direction)
    {
        string textureName;

        textureName = "tile_stone";
        return textureName;
    }
}
