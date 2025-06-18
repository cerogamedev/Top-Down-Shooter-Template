# 🧠 TopDownShooterTemplate - Unity Starter Project

<p align="center">
</p>

> ⚙️ A modular and extendable **Top-Down Shooter** template made with Unity. Built with modern architecture practices for easy expansion, testing, and performance.  
> Ideal for fast prototyping, personal projects, or as a hiring showcase. Designed and developed by **Cherri**, a passionate game developer based in Türkiye 🇹🇷.

---

## 🚀 Features

### 🕹️ Player Mechanics
- **WASD movement** with Unity’s new Input System
- **Mouse-aiming** and smooth rotation
- **Modular weapon system** with fire rate, damage, and custom behavior
- **Object pooling** for bullets (performance friendly)
- **XP & Level system** that scales over time

### 👾 Enemies & AI
- **FSM-based AI** (Chase → Attack)
- **Rigidbody2D navigation**
- **Trigger-based combat interactions**
- **XP drop on death** with auto-follow orbs

### 🎯 Combat System
- **ScriptableObject-based upgrades** (FireRate, Damage, MaxHealth)
- **Upgrade panel** on level-up with 3 random choices
- **Gameplay pause/resume** on upgrade screen

### 🖥️ UI
- Dynamic **health and XP bars**
- **Upgrade selection panel** with icons and text
- Easy to extend with new options

---

## 📂 Project Structure

```plaintext
Assets/
├── Scripts/
│   ├── Player/         → PlayerController, WeaponHandler
│   ├── Enemy/          → EnemyController, AI
│   ├── Combat/         → Bullet, BulletPool
│   ├── XPSystem/       → XPOrb, PlayerStats
│   ├── UI/             → XPBar, HealthBar, Upgrade Panel
│   └── UpgradeSystem/  → UpgradeManager, UpgradeData, UpgradeButton
├── Prefabs/
├── ScriptableObjects/
├── Scenes/
├── Art/
└── Resources/
```

---

## 🔧 Technologies Used

| Tool              | Purpose                          |
|------------------|----------------------------------|
| **Unity 2022+**  | Game engine                      |
| **C#**           | Core scripting                   |
| **Input System** | Modern player input              |
| **ScriptableObject** | Upgrade data modularity     |
| **Rigidbody2D**  | Physics-based movement           |

---

## 🎮 How to Play

- **Move:** `W`, `A`, `S`, `D`
- **Aim:** Mouse
- **Shoot:** Left Mouse Button
- **Level Up:** Collect XP from enemies
- **Choose Upgrade:** Click one of three options

---

## 📦 How to Use

1. Clone the repository  
   ```bash
   git clone https://github.com/yourusername/Top-Down-Shooter-Template.git
   ```

2. Open with **Unity 2022 or later**

3. Run the `BasicControllScene` from the `Scenes` folder

---

## 🧪 Future Additions (Roadmap)

- [ ] Multiple enemy types (ranged, boss, kamikaze)
- [ ] Procedural level generation
- [ ] Permanent upgrade system (meta progression)
- [ ] Sound effects and audio manager
- [ ] WebGL Export

---

## 🧑‍💻 About the Developer

> **Hi! I’m Cherri**, a trans woman game developer from Türkiye. Due to harsh job discrimination, I have turned to game development and Patreon support to survive and grow.  
> I love building **mechanically satisfying systems** and crafting **gameplay-first experiences**. Every project I publish is 100% my own work — made with passion and precision.  
>
> 🎮 [Play more of my games on Itch.io]((https://cerobaby.itch.io/))  
> ❤️ [Support me on Patreon]((https://www.patreon.com/c/cerenbeybi))

---

## ⭐ Why You Should Star This Project

✅ Clean & modular codebase  
✅ Ready to fork & build upon  
✅ Game dev portfolio ready  
✅ Recruiter-friendly presentation

---

## 📄 License

This project is licensed under the MIT License — free to use in personal and commercial projects.

---

## 🔗 Related

- [Unity Input System Docs](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/index.html)  
- [Object Pooling in Unity](https://learn.unity.com/tutorial/introduction-to-object-pooling)  
- [ScriptableObjects Explained](https://www.youtube.com/watch?v=6YQUu5Lqsbk)
