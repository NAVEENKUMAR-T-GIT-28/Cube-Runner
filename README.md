# 🎮 Cube Runner

A fast-paced **3D Endless Runner Game** built with **Unity 6** and **C#**, where players control a cube, dodge obstacles, survive as long as possible, and achieve the highest score.

![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![C#](https://img.shields.io/badge/C%23-Game%20Development-purple?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![Status](https://img.shields.io/badge/Status-Completed-success)

---

## 📖 Overview

Cube Runner is a beginner-to-intermediate Unity game project focused on learning and implementing core game development concepts.

The player continuously moves forward through an endless obstacle course while avoiding collisions. The game includes a complete gameplay loop with:

- Start Screen
- Endless Running Mechanics
- Obstacle Collision System
- Score Tracking
- Game Over Screen
- Restart Functionality
- Camera Follow System

---

## ✨ Features

### 🎯 Gameplay
- Continuous forward movement
- Smooth lane-based horizontal movement
- Endless runner mechanics
- Collision-based game over system

### 🏆 Scoring System
- Real-time score updates
- Distance-based score calculation
- Final score display on game over

### 🎨 User Interface
- Tap to Start screen
- Live score display
- Game Over panel
- Restart button
- Quit button

### 🎥 Camera System
- Smooth camera follow
- Fixed runner perspective
- Dynamic player tracking

### ⚙️ Game Management
- Scene reloading
- Pause/Resume functionality
- Game state management

---

## 🛠️ Tech Stack

| Technology | Purpose |
|------------|----------|
| Unity 6 | Game Engine |
| C# | Game Logic |
| Rigidbody Physics | Player Movement |
| TextMesh Pro | UI Text Rendering |
| Scene Management | Restart System |
| Prefabs | Reusable Obstacles |
| Unity UI | Menus & Score Display |

---

## 📂 Project Structure

```text
Assets
│
├── Animations
├── Materials
├── Physics Material
├── Prefabs
├── Scenes
├── Scripts
│   ├── PlayerScript.cs
│   ├── PlayerCollision.cs
│   ├── FollowPlayer.cs
│   ├── Score.cs
│   └── GameController.cs
│
├── Settings
└── TextMesh Pro
```

---

## 🎮 Controls

| Key | Action |
|------|---------|
| A / Left Arrow | Move Left |
| D / Right Arrow | Move Right |
| Mouse Click | Start Game |
| Restart Button | Restart Level |
| Quit Button | Exit Game |

---

## 🧠 Concepts Implemented

### Player Movement
- Rigidbody velocity movement
- Horizontal lane switching
- Position clamping

### Physics
- Rigidbody-based movement
- Collision detection
- Physics materials

### UI System
- TextMesh Pro integration
- Dynamic score updates
- Interactive buttons

### Game Flow
- Start Menu
- Gameplay
- Game Over State
- Restart System

### Scene Management
- Scene reloading
- Time scaling
- State transitions

---

## 🚧 Challenges Faced

- Implementing smooth forward movement
- Restricting player movement within boundaries
- Handling collision detection reliably
- Managing game states with Time.timeScale
- Creating reusable obstacle prefabs
- Designing responsive UI screens

---

## 📚 What I Learned

- Unity Game Development Workflow
- C# Scripting in Unity
- Rigidbody Physics
- Collision & Trigger Systems
- Prefab Creation
- Scene Management
- UI Development with TextMesh Pro
- Game State Management
- Camera Follow Mechanics

---

## 🚀 Getting Started

### Clone Repository

```bash
git clone https://github.com/NAVEENKUMAR-T-GIT-28/Cube-Runner.git
```

### Open Project

1. Open Unity Hub
2. Click **Add Project**
3. Select the cloned folder
4. Open with **Unity 6**

### Run

```text
Open Scene → GameScene
Press Play ▶
```

---

## 📸 Screenshots

### Gameplay

Add gameplay screenshots here:

```text
Assets/Images/gameplay.png
```

### Game Over Screen

Add game over screenshots here:

```text
Assets/Images/gameover.png
```

---

## 🔮 Future Improvements

- Multiple Levels
- Power-Ups
- High Score Saving
- Mobile Controls
- Sound Effects
- Background Music
- Particle Effects
- Difficulty Scaling
- Leaderboard System

---

## 👨‍💻 Developer

**NAVEENKUMAR T**

- GitHub: https://github.com/NAVEENKUMAR-T-GIT-28
- Portfolio: Add your portfolio link here

---

## ⭐ Support

If you found this project useful, consider giving it a **Star ⭐** on GitHub.

---

## 📄 License

This project is developed for educational and portfolio purposes.