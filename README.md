# TIlemapPaletteSpriteSheetTool
Do you have the annoying issue where you drag your spritesheet into the tile palette and then it gets all messy? This tool can help you!

Note, in unity 2022, TextureImporter.spritesheet is deprecated, however it will work with warning.

If you have  a spritesheet like this:
image sprite sheet

And when you drag it into a tile palette, it then looks like that:
image messy

Then make a new tile palette, drag the prefab into the scene (it won't work in prefab mode), then add this script to the tilemap (the child of the grid) and put in all the tiles, the parent spritesheet, the target tilemap (should be the one in the prefab), and all the tiles generated from the messy import above. Then click the 3 dots in the corner and click the Generate option. (contextmenu)
image organized
