using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEmerald : Block
{

    public BlockEmerald()
        : base()
    {

    }

    public override string TextureName(Direction direction)
    {
        string textureName;

        textureName = "tile_stone_emerald";
        return textureName;
    }
}
