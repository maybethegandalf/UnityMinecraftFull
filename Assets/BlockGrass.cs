using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class BlockGrass : Block
{

    public BlockGrass()
        : base()
    {
        useChunksForTexture = true;
    }

    public override string TextureName(Direction direction, Chunk chunk, int x, int y, int z)
    {
        string textureName;

        if(chunk.GetBlock(x, y , z) == new BlockGrass())
        {
            Debug.Log("yeeee");
            textureName = "tile_dirt";
            return textureName;

        }

        switch (direction)
        {
            //00
            case Direction.up:
                textureName = "tile_grass_up";
                return textureName;
            //10
            case Direction.down:
                textureName = "tile_dirt";
                return textureName;
        }

        //30
        textureName = "tile_grass_side";
        return textureName;
    }
}