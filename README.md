# Allow Modded Achievements mod for Warhammer 40K: Rogue Trader

Separate mod to allow achievements while modded.

If you use Toy Box checkbox you don't need it.    

If you install both this and Toy Box, this mod applies regardless of Toy Box checkbox state.

## Installation
1. Unpack archive directly into `%userprofile%\AppData\LocalLow\Owlcat Games\Warhammer 40000 Rogue Trader\UnityModManager\` WITHOUT creating additional archive named folder.
2. After running the game, navigate to UMM mod settings (press Ctrl-F10) and set settings as you need.

Resulting structure of already existing UnityModManager folder should be as follows
- `AllowModdedAchievements` (folder)
	- `AllowModdedAchievements.dll`
	- `Info.info`

## How to build (for developers only)
1. Set up RoguePath environment variable to point to game folder
2. Restore nuget packages
3. Clean Solution.
4. Build (note that on build output is automatically copied to installation path).
