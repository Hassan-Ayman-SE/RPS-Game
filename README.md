# Rock, Paper, Scissors

## Overview

This is a console application that simulates the classic game of Rock, Paper, Scissors. It allows a player to compete against an AI opponent, with the option to enable a "Hard Mode" where the AI can predict the player's moves and gain an unfair advantage.

## Features

- Single-player mode against an AI opponent.
- AI makes random moves in normal mode.
- AI predicts player's moves in hard mode.
- Game continues until one player reaches 3 points.
- Displays the result of each round and updates the scores.
- Includes unit tests to verify game logic.

## How to Run

1. Compile the program using your preferred C# compiler.
2. Run the executable.

## Game Instructions

1. Enter your name when prompted.
2. Select the game mode:
   - **1** for Normal Mode
   - **2** for Hard Mode
3. Enter your move (rock, paper, or scissors) when prompted.
4. The game will display the AI's move and the result of each round.
5. The game ends when one player reaches 3 points, and the final scores are displayed.

## Unit Tests

Unit tests are provided to verify the following:

- The game correctly determines the winner of each round based on the players' moves.
- The game correctly updates the scores after each round.

To run the tests, use the Xunit testing framework.

## Stretch Goals

- **Hard Mode**: Allows the AI to predict the player's move, providing an unfair advantage to the AI. This mode is for demonstration purposes only.
