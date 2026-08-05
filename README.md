# 🌸 Cemre Sümer — Portfolio

> Personal portfolio website built with HTML, CSS, and Vanilla JavaScript.

![HTML5](https://img.shields.io/badge/HTML5-E34F26?style=flat-square&logo=html5&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=flat-square&logo=css3&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-ES6-F7DF1E?style=flat-square&logo=javascript&logoColor=black)
![License](https://img.shields.io/badge/license-MIT-pink?style=flat-square)

---

# ✨ Features

- 🌸 Elegant princess-pink themed UI
- ✨ Smooth scroll reveal animations
- 📂 Projects loaded dynamically from JSON
- 📝 Blog posts loaded dynamically from JSON
- 👩‍💻 CV section with education, experience, certifications and skills
- 📊 Animated statistics counters
- 📱 Fully responsive design
- 🎯 Active navigation highlighting while scrolling
- 💖 Floating sparkle particle effects

---

# 🛠️ Tech Stack

| Layer | Technology |
|--------|------------|
| Frontend | HTML5 |
| Styling | CSS3 |
| Programming | Vanilla JavaScript (ES6+) |
| Data | JSON |
| Data Loading | Fetch API |
| Animations | CSS Animations + Intersection Observer |
| Hosting | GitHub Pages |

---

# 📂 Data Source

This portfolio does **not** use a backend or database.

All content is stored in JSON files and loaded dynamically by JavaScript using the Fetch API.

```
wwwroot/
└── data/
    ├── projects.json
    └── blog.json
```

### Example (`projects.json`)

```json
[
  {
    "id": 1,
    "title": "Coffee Date Wheel",
    "description": "Interactive spin wheel app for planning coffee dates.",
    "technologies": "HTML5, CSS3, JavaScript",
    "githubUrl": "https://github.com/cemresumerr/CoffeeDateWheel",
    "liveUrl": "https://coffeedatewheel-production.up.railway.app"
  }
]
```

### Loading Data

```javascript
const response = await fetch("data/projects.json");
const projects = await response.json();
```

---

# 🚀 Getting Started

Clone the repository

```bash
git clone https://github.com/cemresumerr/MyPortfolio.git
```

Open the project folder

```bash
cd MyPortfolio
```

Run using a local server (recommended)

Examples:

- VS Code + Live Server
- Visual Studio
- Any static web server

Or simply open `index.html` in your browser.

---

# 📁 Project Structure

```
MyPortfolio/
│
├── index.html
├── css/
│   └── style.css
│
├── js/
│   ├── script.js
│   ├── projects.js
│   └── blog.js
│
├── data/
│   ├── projects.json
│   └── blog.json
│
├── images/
│
└── README.md
```

> *(Folder names may vary depending on your project structure.)*

---

# 🎨 Design Highlights

- 🌸 Princess pink aesthetic
- ✨ Soft glassmorphism effects
- 📜 Smooth scrolling
- 💫 Scroll-triggered animations
- 📈 Animated counters
- 🏷️ Animated skill badges
- 📱 Mobile-first responsive layout
- 💖 Floating sparkle effects

---

# 🌍 Live Demo

👉 https://cemresumer.is-a.dev

---

# 📬 Contact

- **GitHub:** https://github.com/cemresumerr
- **LinkedIn:** https://linkedin.com/in/cemresumer
- **Email:** cemresumerr8@gmail.com

---

<p align="center">
✨ Made with ❤️ by <strong>Cemre Sümer</strong>
</p>
