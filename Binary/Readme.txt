Binary
by MaxHwoy
v2.5.5

------------------------------------------------------------------------------------------------------------
Description:

Binary is a tool for editing Need for Speed binary files (.BIN, .BUN, .LZC).

Currently supported games are:
- Need for Speed: Underground 1
- Need for Speed: Underground 2
- Need for Speed: Most Wanted (2005)
- Need for Speed: Carbon
- Need for Speed: Prostreet

Upcoming supports:
- Need for Speed: Undercover
- Need for Speed: Hot Pursuit 2 (NO!!!)
! Please don't ask support for other games. They may or may not be added over time.

This tool is capable of, and not limited to, editing the following files:
- Global files (GlobalA & GlobalB, and so on)
- Frontend files (FrontA, FrontB, and so on)
- InGame files (InGameA, InGameB, and so on)
- Texture files (Textures.bin)
- MiniMap files (Mini_Map_X.bin)
- Vinyl files (Vinyls.bin)
- NIS files (textures only)

The tool has two standard usage types: User and Modder. User type is pretty straight-forward and requires 
from app's user to only select launcher endscript and game directory. Modder type contains user interface 
and sub editors for editing files and advanced usage, but requires password that can be found in the 
my discord server (see below).

! Do not remove .dll libraries from the app's directory! They are important for the app to function properly.

------------------------------------------------------------------------------------------------------------
Installation and basic usage:

! Before installation, make sure that you have installed .NET Core Desktop Runtime 3.1 (x86) or higher.
! Remember that you have to installe x86 one, not x64, or else it will not work:

https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-desktop-3.1.6-windows-x86-installer



Endscript -> file with .end extension that contains script lines and is used by Binary to make changes to Global files.

Now you can use Binary to install any endscript mod for it. Just follow these steps:

1) Copy the files anywhere on your PC.
2) Run "Binary.exe" as administrator.
3) Select left big red icon with 3 users as the icon.
4) Select main installation .end script provided by the mod you wish to install.
5) Select game directory you wish to install mod for.
6) After installing the mod confirm saving changes.
7) If you wish, you could run the game right away.

------------------------------------------------------------------------------------------------------------

You can freely access "Modder" side of the tool and use all of its capabilities. Remember that all documentation 
is kept on the tool's official Discord server, which you can join any time and get support from any modders:

https://discord.gg/xy5TjTa

------------------------------------------------------------------------------------------------------------

Changelog: (+ Addition, ! Change, - Deletion)
v2.5.5 (Stream Dangerous)
+ Added Stream file support (works via commands below) | FOR EXPERTS ONLY, WIP AND DOES NOT GUARANTEE FINAL FILES WORKING.
+ Added 'unpack_stream' command | FOR EXPERTS ONLY, WIP AND DOES NOT GUARANTEE FINAL FILES WORKING.
+ Added 'pack_stream' command | FOR EXPERTS ONLY, WIP AND DOES NOT GUARANTEE FINAL FILES WORKING.

v2.5.0
! Significantly improved memory management related to files containing textures, such as vinyls files.
! Endscript commands now can have whitespace and tabs around them for formatting purposes.
+ Multiple of the car part attributes was dehashed: SPEECHCOLOUR, KITNOTNUMBER01-20, etc.
! Fixed RIGHT_SIDE_WINDOW naming to RIGHT_SIDE_MIRROR.
! Fixed exporting and importing of GCareerRaces, including endscript commands applying to them.
! Fixed readonly file issues with move command. 

v2.4.0
+ Added support for Need for Speed: Underground 1.
+ Added support for MostWanted minimap files.
+ Added Custom car part attribute for all modules.
+ Added Find and Replace for all properties and nodes in CarPartsEditor.
+ Added 'add_or_update_string' command.
+ Added 'add_or_replace_texture' command.
+ Added option to load new launcher when it was created.
! Bound values in Collisions are now unpacked to floats when editing.
! Fixed BinFile entry in Raider.
! Car parts in Carbon and Prostreet modules now have extra properties shown.
! PresetRides CollectionNames are now automatically uppercased.
! Fixed generation of in_career commands where a property is being set empty.
! Raider now supports entering strings without "0x" prefix.

v2.2.0
+ Added 'unlock_memory' command.
+ Added 'stop_errors' command.
+ Added 'speedreflect' command.
+ Improved endscript handling, now you can nest if/checkbox/combobox statement in any files.
+ Added VectorVinyl support for Carbon and Prostreet modules.
+ Added VectorVinyl editor.
+ Added SpeedReflect.asi - script that unlocks several features of the game, including attaching custom
  .bin files, unlocking vector vinyl tables, and more features in other games. Use 'speedreflect' command
  to move it.
! Now when adding texture in Texture Editor CollectionName will automatically be written down to "Set 
  CollectionName prompt" based on file's name.
- Removed password for "Modder" side of the tool.
! Made several fixes to GCareer collections in Underground2 module, mainly: GCareerRace, WorldShop, WorldChallenge.
+ Added highlight of strings changed in string editor.
+ Added node index displayed at the bottom status bar.

v2.1.0
! Total rebuild of the tool using new libraries.

v1.0.5
+ Added decals to PresetRides in MW support.
! Fixed stock brakelights bug in U2 support.

v1.0.4
+ Added new user setting: Suppress ADCI Errors.
+ Added Tool Tips for each of user settings (just hover over any of them to see what they do).
+ Added "switch" command (for documentation and usage look in UMC discord server).
+ Added AcidEffects for NFS: Underground 2 support.
! Made several fixes related to tree view and nodes.
! "Set Username" option was renamed to "Set Modder Name". Usage stays same.

v1.0.1
! Fixed bug when trying to update values in collection subnodes.

v1.0.0
+ Release version.

------------------------------------------------------------------------------------------------------------

Credits:

Coded by:
- MaxHwoy

Biggest thanks to:
- 379Felipe for testing and resources.
- nlgzrgn for testing and resources.
- heyitsleo for great help.

Great thanks to the tester team:
- 379Felipe
- ARCHIE
- Aceofsquares3
- Avalanche
- CheapAssVideos
- Elven
- GhostRider
- NFSBOI
- rx
- konigsseg
- elaymm4
- Lexal
- Miles Dipperion
- Miner
- MrAdam
- nlgzrgn
- RaTT
- Red_Fire
- RedCarDriver
- rnz
- trackmaniamatt
- Neon
- Zyr3X

------------------------------------------------------------------------------------------------------------

©2020 MaxHwoy, all rights reserved. Do not distribute/modify this package without proper permission.