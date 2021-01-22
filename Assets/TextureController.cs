using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TextureController
{
    public static Dictionary<string, Vector2[]> textureMap = new Dictionary<string, Vector2[]>();

    public static void Initialize(string texturePath, Texture texture)
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>(texturePath);
        Debug.Log("Textures loading...");

        foreach (Sprite s in sprites)
        {
            Vector2[] uvs = new Vector2[4];

            uvs[0] = new Vector2(s.rect.xMax / texture.width, s.rect.yMin / texture.height);
            uvs[1] = new Vector2(s.rect.xMax / texture.width, s.rect.yMax / texture.height);
            uvs[2] = new Vector2(s.rect.xMin / texture.width, s.rect.yMax / texture.height);
            uvs[3] = new Vector2(s.rect.xMin / texture.width, s.rect.yMin / texture.height);

            textureMap.Add(s.name, uvs);
            Debug.Log(s.name);
        }
        Debug.Log("Textures finished");
    }
}
