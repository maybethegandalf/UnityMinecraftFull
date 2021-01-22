using System.Collections;
using System;
using UnityEngine;

[Serializable]
public class BlockWood : Block
{
    public BlockWood()
        : base()
    {

    }

    public override string TextureName(Direction direction)
    {
        string textureName;
        switch (direction)
        {
            //00
            case Direction.up:
            case Direction.down:
                textureName = "tile_tree_down";
                return textureName;
        }

        //30
        textureName = "tile_tree_side";
        return textureName;
    }
}
