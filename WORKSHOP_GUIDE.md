# WORKSHOP GUIDE

## Building a GTA-lite Demo in 1-2 Hours

### Objective
This guide will take you through the process of creating a basic GTA-lite demo, covering various aspects like setup, player and vehicle configurations, and additional features.

---

### Table of Contents
1. [Setup](#setup)
2. [Scene Creation](#scene-creation)
3. [Player Setup](#player-setup)
4. [Vehicle Setup](#vehicle-setup)
5. [Camera Setup](#camera-setup)
6. [Control Switching](#control-switching)
7. [Testing](#testing)
8. [Debugging](#debugging)
9. [Extension Ideas](#extension-ideas)

---

### Setup
1. **Install Dependencies**: 
   - Ensure you have the latest version of Unity installed.
   - Install necessary packages for physics and controls from the Unity Asset Store.
2. **Create a New Project**:
   - Open Unity, click on "New", and choose a 3D template.
   - Name your project and set the location on your drive.

### Scene Creation
1. **Create a Terrain**:
   - Right-click in the Hierarchy and select 3D Object -> Terrain.
   - Adjust the terrain size to your desired scale (e.g., 1000 x 1000).
2. **Add Environment Objects**:
   - Import models like buildings, trees, and vehicles as assets.
   - Use the terrain tools to paint textures and place objects on the terrain.

### Player Setup
1. **Create Player Object**:
   - Right-click in the Hierarchy and select 3D Object -> Capsule (for a basic player).
   - Add a Character Controller component.
2. **Add Player Script**:
   - Create a new C# script named `PlayerController` and attach it to the player object.
   - Implement basic movement logic.

### Vehicle Setup
1. **Create Vehicle Object**:
   - Import a vehicle model and drag it into the scene.
2. **Add Vehicle Controller**:
   - Create a script named `VehicleController` to handle vehicle movements and controls.

### Camera Setup
1. **Create a Camera Object**:
   - Setup a camera to follow the player. Use Cinemachine for smooth following.
2. **Configure Camera Settings**:
   - Adjust Field of View and position it behind the player.

### Control Switching
1. **Setup Control Schemes**:
   - Define input commands in the Unity Input Manager for player and vehicle controls.
2. **Write Control Switching Logic**:
   - Use the `PlayerController` script to switch between player and vehicle controls.

### Testing
1. **Play Mode**:
   - Enter Play Mode and test player movements and interactions with vehicles.
   - Check if controls switch correctly.

### Debugging
1. **Check Console**:
   - Use `Debug.Log()` to identify any issues in your scripts.
   - Create breakpoints if necessary.

### Extension Ideas
1. **Add NPCs**: Introduce Non-Playable Characters to populate the world.
2. **Implement Quests**: Allow the player to engage in missions or quests.
3. **Vehicle Customization**: Add features for modifying vehicles.

---

### Conclusion

Congratulations! You have successfully set up a GTA-lite demo. Feel free to experiment with additional features and enhance your game further.