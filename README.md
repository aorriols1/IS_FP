# IS_FP

## Scenario
The purpose of this game consists on competing between two players to obtain the maximum amount of points by interacting with some game elements. Here are the key components:

### Boxes with Hands and Feet:

Utilized .png files for texture and design.
Terrain: Used the "Terrain Sample Asset Pack" from the Unity Asset Store to establish the terrain material of the plane.

City Park Simulation: Incorporated 3D assets from the "Low Poly Environment Park" package to create the experience of being in a city park.

Environmental Audio: Added a .wav file from Freesound to simulate birds singing and enhance the environment's audio experience.

## Scripts

### PressurePlateBox

The script manages the activation sequence of pressure plates.
The condition ```if (!activated && other.CompareTag("Player"))``` ensures that the activation code runs only if the pressure plate has not already been activated and the object colliding with it has the tag "Player".

```gameObject.SetActive(false);``` deactivates the GameObject this script is attached to, effectively "turning off" the current pressure plate.

```if (nextPressurePlate != null) { nextPressurePlate.SetActive(true); }``` checks if the ```nextPressurePlate``` variable has been assigned a ```GameObject```. If so, it sets that GameObject to active, "turning on" the next pressure plate.

```activated = true;``` updates the activated variable to true, ensuring that the pressure plate cannot be activated again.

### PlayerController (for 6, 7 or 8 plates)

The script manages player movement using Rigidbody physics.

It updates the UI to show the current score and a win message when the player collects enough items.

The ```OnTriggerEnter``` method handles collisions with objects tagged "Player1", deactivating them and updating the score.

### LoadingScenes

The script inherits from ```MonoBehaviour```, the base class for all scripts in Unity. This script waits for both players to touch a designated area before initiating a scene change after a delay.

Check which player has touched the collider:

```if (other.CompareTag("Player1")) { ... }:``` Sets ```player1Touched``` to true if the collider belongs to Player 1 and logs a debug message.

```else if (other.CompareTag("Player2")) { ... }:``` Sets ```player2Touched``` to true if the collider belongs to Player 2 and logs a debug message.

Start the coroutine if both players have touched the colliders:

```if (player1Touched && player2Touched) { StartCoroutine(ChangeSceneAfterDelay()); }:``` Initiates the scene change coroutine if both ```player1Touched``` and ```player2Touched``` are true.

The coroutine ```IEnumerator ChangeSceneAfterDelay()``` waits for the specified time before loading the new scene, logging messages at the start and after the wait period.

### GameManager

Method ```Awake()``` is called when the script instance is being loaded

Ensure a single instance of GameManager:
```if (instance == null) { ... } else { ... }:``` Checks if the instance is null. If it is, assigns this to instance and marks the GameObject to not be destroyed on scene load. If instance is not null, destroys the duplicate ```GameObject``` to maintain a single instance.

```DontDestroyOnLoad(gameObject);``` Prevents the ```GameObject``` from being destroyed when loading a new scene.


Method ```AddPoint(int playerNumber)``` adds a point to the specified player's score:

Add a point to Player 1:
```if (playerNumber == 1) { ... }:``` Increments ```player1Points``` and logs the updated points.
Add a point to Player 2:
```else if (playerNumber == 2) { ... }:``` Increments ```player2Points``` and logs the updated points.

Method ```SubtractPoint(int playerNumber)``` subtracts a point from the specified player's score:

Subtract a point from Player 1:
```if (playerNumber == 1) { ... }:``` Decrements player1Points and logs the updated points.
Subtract a point from Player 2:
```else if (playerNumber == 2) { ... }:``` Decrements player2Points and logs the updated points.

Method ```TransferPoint(int fromPlayer, int toPlayer)``` transfers a point from one player to the other, ensuring the source player has points to transfer:

Transfer a point from Player 1 to Player 2:
```if (fromPlayer == 1 && player1Points > 0) { ... }:``` Decrements player1Points, increments player2Points, and logs the updated points for both players.
Transfer a point from Player 2 to Player 1:
```else if (fromPlayer == 2 && player2Points > 0) { ... }:``` Decrements player2Points, increments player1Points, and logs the updated points for both players.

### Star

The script detects when a player collides with the star.

If the collider belongs to Player 1 or Player 2, it awards a point to the respective player by calling the ```AddPoint``` method on the ```GameManager``` instance.

After awarding the point, the star ```GameObject``` destroys itself to simulate being collected.

### Skull

The script detects when a player collides with the skull.

If the collider belongs to Player 1 or Player 2, it subtracts a point to the respective player by calling the ```SubtractPoint``` method on the ```GameManager``` instance.

After subtracting the point, the star ```GameObject``` destroys itself to simulate being collected.

### Thief

The script detects when a player collides with the thief.

If the collider belongs to Player 1 or Player 2, it subtracts a point from the one who touched and adds it to the respective player by calling the ```TransferPoint``` method on the ```GameManager``` instance.

After transfering the point, the star ```GameObject``` destroys itself to simulate being collected.

## Assets References

Terrain Sample Asset Pack https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808

Low Poly Environment Park https://assetstore.unity.com/packages/3d/environments/low-poly-environment-park-242702

Low-Poly Medieval Market https://assetstore.unity.com/packages/3d/environments/low-poly-medieval-market-262473

2D Character - Astronaut https://assetstore.unity.com/packages/2d/characters/2d-character-astronaut-182650

Boy sitting (Mixamo animation character) https://www.mixamo.com/#/?page=1&query=timmy&type=Character

Music from game title audio https://freesound.org/people/xtrgamr/sounds/244537/

Birds Singing Audio https://freesound.org/people/klankbeeld/sounds/624532/

Scifi Lava audio https://freesound.org/people/craigsmith/sounds/675729/

Space scene audio https://freesound.org/people/Jovica/sounds/110240/

Sea waves audio https://freesound.org/people/zavoronok/sounds/670689/

Text to Speech audio https://ttsmaker.com/
