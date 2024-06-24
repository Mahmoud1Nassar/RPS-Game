# RPS-Game
## Introduction

This project is a simple console-based Rock-Paper-Scissors game written in C#. The game allows a player to play against the computer.
## Features

- Player vs Computer gameplay
- Random computer moves
- Keeps track of scores and rounds

## How to Play

1. The game will prompt you to enter your name.
2. You will then choose between "rock", "paper", or "scissor".
3. The computer will randomly select its move.
4. The game will determine the winner of each round and update the scores accordingly.
5. The game consists of 3 rounds, and the player with the highest score at the end wins.

### Classes

- **Player**: Contains methods related to player actions and data.
  - `computerMove()`: Generates a random move for the computer.
  - `RPSPlayer()`: Prompts the player to input their move.
  - `playerData()`: Prompts the player to enter their name.

- **RPSGame**: Contains the main game logic.
  - `PlayerVSComputer()`: Implements the Player vs Computer gameplay, including scoring and round management.

- **Program**: The entry point of the application.
  - `Main(string[] args)`: Starts the game by calling `PlayerVSComputer()`.

### Unit Tests

Unit tests are implemented using xUnit. The tests cover the following methods:
- `Player.computerMove()`: Ensures the computer's move is valid.
- `Player.playerData()`: Simulates player name input.
- `Player.RPSPlayer()`: Simulates player move input.