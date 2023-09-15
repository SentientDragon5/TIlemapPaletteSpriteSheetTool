using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor.Tilemaps;
using UnityEditor.U2D.Aseprite;

public class SpriteSheetPaletteGenerator : MonoBehaviour
{
    public Texture2D spriteSheet;
    public Tilemap tilemap;
    public TileBase[] tiles;
    public int ppu;
    [ContextMenu("Generate")]
    public void GenerateTilePalette()
    {
        TextureImporter importer = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(spriteSheet)) as TextureImporter;
        SpriteMetaData[] metaData = importer.spritesheet;

        for (int i = 0; i < metaData.Length; i++)
        {
            Vector2 pos = metaData[i].rect.position / ppu;
            tilemap.SetTile(tilemap.WorldToCell(pos), tiles[i]);
        }

    }
}
