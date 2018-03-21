# Code.Fun.Do

An Augmented Reality App built from Unity3D without using the standard AR Packages.
Shoot the spaceships that randomly spawn around you and shoot them to get more points.
Every level gets tougher and you get a higher score for a shot!
Fail to hit a spaceship and lose 20 HP.
Can You Beat the HighScore?

Major Parts of the project:

Goto Scripts folder to see all the C# scripts used.
# Scripts:
## Game.cs
The basic functionality like scoring system, spawn rate every level,randomly spawning the spaceships and checking if the level is complete!
## Enemy.cs
The script on the spaceships that controls the parameters like speed of approach toward the user, playing collision sounds,etc.
## webcam.cs
Controls projecting the camera feed on a plane to give an AR effect.
## Health.cs
Deals with in-game heath options and controls the heath bar.
## Shoot.cs
Deals with the physics of shooting a bullet at the current orientation of the phone.
## Music.cs
Deals with the background music.
Other scripts control the various in-game UI elements.
AudioSources are attached to various gameObjects to deal with various sounds!
# Assets:
## TextMesh Pro for crisp text
https://assetstore.unity.com/packages/essentials/beta-projects/textmesh-pro-84126
## Sci-fi vehicle models
https://assetstore.unity.com/packages/3d/characters/robots/scifi-enemies-and-vehicles-15159
## Bosca Ceoil for making some game sound effects
https://boscaceoil.net/
## Deep in space background music
https://assetstore.unity.com/packages/audio/music/electronic/deep-in-space-88071
