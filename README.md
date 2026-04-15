# Asteroids Game – Unity Project (Level 2)
## Overview

This project is a 2D Asteroids-style game developed in Unity. It includes core gameplay mechanics, physics interactions, UI, and additional features from Meta Quests.
## Core Features (Level 2: Asteroids)

### Gate 1 – Thrust & Drift (10 XP)

* Tank controls:
  * A / D → Rotate
  * W → Thrust
* Rigidbody2D with linear drag for smooth drifting.

### Gate 2 – Screen Wrapping (10 XP)

* Implemented using `Camera.main.WorldToViewportPoint`.
* Objects wrap from one side of the screen to the other.

### Gate 3 – Prefab Blasters (10 XP)

* Bullets instantiated using prefabs.
* Bullets destroy themselves after 2 seconds.

## Expansions

### Splitting Asteroids (+20 XP)

* Large asteroids split into two smaller asteroids.
* Smaller asteroids inherit movement and behavior.

### Gravity Well (+25 XP)

* Black hole pulls the player using `AddForce`.
* Trigger-based detection using `OnTriggerStay2D`.

## Meta Quests

### Audio Manager (+15 XP)

* Centralized system for sound effects.
* Includes shooting and game over sounds.

### Particle Effects (+15 XP)

* Explosion effect using Unity Particle System.
* Triggered when asteroids break.

### Main Menu (+10 XP)

* Separate menu scene.
* Start button loads game scene.
* Exit button closes application.

---

## Gameplay Flow

* Game starts at Main Menu.
* Start button loads gameplay.
* Player moves, shoots, and destroys asteroids.
* Press ESC to return to Main Menu.
* Win: all asteroids destroyed.
* Lose: player collides with asteroid.
---
## Total XP

* Asteroids Base: 30 XP
* Splitting Asteroids: 20 XP
* Gravity Well: 25 XP
* Particle Effects: 15 XP
* Audio Manager: 15 XP
* Main Menu: 10 XP

Total: 115 XP

---

## How to Run
1. Open project in Unity
2. Ensure scenes added in Build Settings:
   * MainMenu (index 0)
   * SampleScene
3. Build for Windows
4. Run the generated .exe file
