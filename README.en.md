# Koyuki Pong

This is a simple game project developed using the Godot engine, containing two mini-games: **Pong** and **Dino**.

## Project Structure

- **scenes/**: Stores game scene files (e.g., `main_menu.tscn`, `node_2d.tscn`, `dino.tscn`).
- **scripts/**: Stores C# script files used to implement game logic.
- **audio/**: Stores sound effects and background music.
- **images/**: Stores image resources required for the game.
- **project.godot**: Godot project configuration file.

## Game Introduction

### Pong  
A classic two-player battle pong game where players control paddles to hit a ball back and forth.

### Dino  
A simple runner game where the player controls a character to jump and avoid obstacles.

## Script Description

- `MainMenu.cs`: Main menu logic, providing buttons to navigate to the Pong and Dino games.
- `Node2d.cs`: Main logic for the Pong game, including score management and game flow control.
- `Koyuki.cs` and `KoyukiBall.cs`: Implement the character and ball physics behavior in the Pong game.
- `Dino.cs`: Core logic for the Dino game, including obstacle generation and collision detection.
- `DinoGameOver.cs`: Logic for the game over screen in the Dino game.

## How to Run

1. Install the [Godot engine](https://godotengine.org/) (it is recommended to use a version compatible with the project).
2. Open Godot and load the project by selecting the `project.godot` file.
3. Click the run button to start the game.

## Contribution Guide

Contributions of code or resources are welcome! Please follow these steps:
1. Fork this repository.
2. Create a new branch (`git checkout -b feature/new-feature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push your branch (`git push origin feature/new-feature`).
5. Submit a Pull Request.

## License

This project is licensed under the MIT License. For more details, please refer to the LICENSE file.