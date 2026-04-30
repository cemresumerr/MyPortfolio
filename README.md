# 🌸 Cemre Sümer — Portfolio

> Personal portfolio website built with .NET Core Web API + Vanilla JS frontend.

![.NET](https://img.shields.io/badge/.NET%208-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-blue?style=flat-square)
![License](https://img.shields.io/badge/license-MIT-pink?style=flat-square)

---

## ✨ Features

- **Princess pink themed UI** with scroll reveal animations, sparkle particles, and ambient glow effects
- **Projects section** — dynamically loaded from API with staggered card animations
- **Blog section** — blog posts with slide-in animations from alternating directions
- **CV section** — education, experience, certifications, leadership, and animated skill bars
- **Stats counter** — numbers count up when scrolled into view
- **Responsive design** — works on desktop, tablet, and mobile
- **Active nav tracking** — navbar highlights current section as you scroll

---

## 🛠️ Tech Stack

| Layer | Technology |
|-------|-----------|
| Backend | ASP.NET Core 8 Web API |
| Frontend | Vanilla HTML / CSS / JS |
| Data | JSON files (no database needed) |
| Animations | Intersection Observer API + CSS transitions |
| Typography | Cormorant Garamond + Quicksand (Google Fonts) |

---

## 📡 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/projects` | Returns all projects |
| `GET` | `/api/projects/{id}` | Returns a specific project |
| `GET` | `/api/blog` | Returns all blog posts |
| `GET` | `/api/blog/{id}` | Returns a specific blog post |

### Example Response — `/api/projects`

```json
[
  {
    "id": 1,
    "title": "Coffee Date Wheel",
    "description": "Interactive spin wheel app for planning coffee dates.",
    "technologies": ".NET 8, Web API, HTML5 Canvas, CSS3, JavaScript",
    "gitHubUrl": "https://github.com/cemresumerr/CoffeeDateWheel",
    "liveUrl": "https://coffeedatewheel-production.up.railway.app"
  }
]
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Run Locally

```bash
git clone https://github.com/cemresumerr/MyPortfolio.git
cd MyPortfolio
dotnet run
```

Open `https://localhost:5001` in your browser.

---

## 📁 Project Structure

```
MyPortfolio/
├── Controllers/
│   ├── ProjectsController.cs     # Projects API
│   └── BlogController.cs         # Blog API
├── Models/
│   ├── Project.cs
│   └── BlogPost.cs
├── Data/
│   └── JsonDataService.cs        # Reads from JSON files
├── wwwroot/
│   ├── index.html                # Frontend with animations
│   └── data/
│       ├── projects.json         # Project data
│       └── blog.json             # Blog post data
├── Program.cs
├── Dockerfile
└── README.md
```

---

## 🐳 Docker

```bash
docker build -t cemre-portfolio .
docker run -p 8080:8080 cemre-portfolio
```

---

## 🎨 Design Highlights

- **Color palette:** Princess pink, rose gold, lavender
- **Scroll animations:** Fade-in from bottom, left, right + scale-in for skill tags
- **Skill bars:** Animated fill on scroll with staggered delays
- **Counter animation:** Stats count up when visible
- **Floating particles:** Sparkle emojis drifting across the background
- **Navbar:** Shrinks on scroll + active section highlighting

---

## 📬 Contact

- **GitHub:** [github.com/cemresumerr](https://github.com/cemresumerr)
- **LinkedIn:** [linkedin.com/in/cemresumer](https://linkedin.com/in/cemresumer)
- **Email:** cemresumerr8@gmail.com

---

<p align="center">✨ made with ♥ by Cemre Sümer — 2026</p>
