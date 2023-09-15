# TIlemapPaletteSpriteSheetTool
Do you have the annoying issue where you drag your spritesheet into the tile palette and then it gets all messy? This tool can help you!

![alt text](https://github.com/SentientDragon5/TIlemapPaletteSpriteSheetTool/blob/main/Organized%20Import.png)

Note, in unity 2022, TextureImporter.spritesheet is deprecated, however it will work with warning.

If you have  a spritesheet like this:

![alt text](https://github.com/SentientDragon5/TIlemapPaletteSpriteSheetTool/blob/main/Spritesheet.png)

And when you drag it into a tile palette, it then looks like that:

![alt text](https://github.com/SentientDragon5/TIlemapPaletteSpriteSheetTool/blob/main/MessyImport.png)

Then make a new tile palette, drag the prefab into the scene (it won't work in prefab mode), then add this script to the tilemap (the child of the grid) and put in all the tiles, the parent spritesheet, the target tilemap (should be the one in the prefab), and all the tiles generated from the messy import above. Then click the 3 dots in the corner and click the Generate option. (contextmenu)

![alt text](https://github.com/SentientDragon5/TIlemapPaletteSpriteSheetTool/blob/main/How.png)


![alt text](https://github.com/SentientDragon5/TIlemapPaletteSpriteSheetTool/blob/main/Organized%20Import.png)
