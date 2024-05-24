# IS_FP

## Scenario
The initial structure of our project consists of various materials, 3D assets, and audio files. The purpose of this first version is to test the arrangement and appearance of colors, and thus it may differ from the final version. Here are the key components:

### Boxes with Hands and Feet:

Utilized .png files for texture and design.
Terrain: Used the "Terrain Sample Asset Pack" from the Unity Asset Store to establish the terrain material of the plane.

City Park Simulation: Incorporated 3D assets from the "Low Poly Environment Park" package to create the experience of being in a city park.

Environmental Audio: Added a .wav file from Freesound to simulate birds singing and enhance the environment's audio experience.

Assets References

Terrain Sample Asset Pack https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808

Low Poly Environment Park https://assetstore.unity.com/packages/3d/environments/low-poly-environment-park-242702

Birds Singing Audio https://freesound.org/people/klankbeeld/sounds/624532/

## Scripts

### PressurePlateBox

The script manages the activation sequence of pressure plates.
The condition ```if (!activated && other.CompareTag("Player"))``` ensures that the activation code runs only if the pressure plate has not already been activated and the object colliding with it has the tag "Player".

```gameObject.SetActive(false);``` deactivates the GameObject this script is attached to, effectively "turning off" the current pressure plate.

```if (nextPressurePlate != null) { nextPressurePlate.SetActive(true); }``` checks if the nextPressurePlate variable has been assigned a GameObject. If so, it sets that GameObject to active, "turning on" the next pressure plate.

```activated = true;``` updates the activated variable to true, ensuring that the pressure plate cannot be activated again.

### Player1Controller

The script manages player movement using Rigidbody physics.

It updates the UI to show the current score and a win message when the player collects enough items.

The ```OnTriggerEnter``` method handles collisions with objects tagged "Player1", deactivating them and updating the score.

### LoadingScenes

The script inherits from ```MonoBehaviour```, the base class for all scripts in Unity. This script waits for both players to touch a designated area before initiating a scene change after a delay.

Check which player has touched the collider:

```if (other.CompareTag("Player1")) { ... }:``` Sets player1Touched to true if the collider belongs to Player 1 and logs a debug message.

```else if (other.CompareTag("Player2")) { ... }:``` Sets player2Touched to true if the collider belongs to Player 2 and logs a debug message.

Start the coroutine if both players have touched the colliders:

```if (player1Touched && player2Touched) { StartCoroutine(ChangeSceneAfterDelay()); }:``` Initiates the scene change coroutine if both player1Touched and player2Touched are true.

The coroutine waits for the specified time before loading the new scene, logging messages at the start and after the wait period.

