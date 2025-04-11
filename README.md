### ✍️ **Part I – Multiple Choice Questions (20 questions)**  
Each question is worth 0.5 points. Total: **10 points**

---

#### 🐳 **Docker**

1. What is Docker?  
   - A) A relational database  
   - B) A web server  
   - **<mark>C) A container platform for creating and managing environments</mark>**
   - D) A frontend framework  

2. Which command builds a Docker image from a Dockerfile?  
   - A) `docker pull`  
   - **<mark>B) `docker build`</mark>**    
   - C) `docker start`
   - D) `docker run`

3. What is `docker-compose` used for?  
   - A) Compressing files  
   - B) Creating multiple Docker images  
   - **<mark>C) Orchestrating multiple containers</mark>**  
   - D) Backing up volumes  

4. What does the command `docker ps` do?  
   - A) Create containers  
   - B) List images  
   - **<mark>C) Show running containers</mark>**  
   - D) Stop all containers  

---

#### 🌿 **Git / GitHub**

5. What does `git clone` do?  
   - A) Create a new repository  
   - **<mark>B) Download a copy of a remote repository</mark>**  
   - C) Delete a local repo  
   - D) Update a remote repo  

6. What is a “commit” in Git?  
   - A) Send files to GitHub  
   - B) Merge two branches  
   - **<mark>C) Save changes locally in Git</mark>**  
   - D) Delete modified files  

7. Which command pushes changes to GitHub?  
   - **<mark>A) `git push`</mark>**  
   - B) `git pull`  
   - C) `git add`  
   - D) `git commit`  

8. What is the purpose of a `.gitignore` file?  
   - A) Ignore repositories  
   - **<mark>B) Ignore files/folders from being committed</mark>**  
   - C) Protect branches  
   - D) Manage GitHub access  

---

#### ⚙️ **.NET Core**

9. Which command creates a new Web API project in .NET Core?  
   - A) `dotnet build api`  
   - **<mark>B) `dotnet new webapi`</mark>**  
   - C) `dotnet run api`  
   - D) `dotnet create api`  

10. Which file configures services and middleware in .NET Core?  
   - A) `Startup.cs`  
   - **<mark>B) `Program.cs`</mark>**  
   - C) `App.cs`  
   - D) `Main.cs`  

11. Which package enables CORS in a .NET API?  
   - A) `Microsoft.AspNetCore.Routing`  
   - **<mark>B) `Microsoft.AspNetCore.Cors`</mark>**  
   - C) `Microsoft.AspNetCore.Mvc.NewtonsoftJson`  
   - D) `System.Net.Http`  

12. What does the `[HttpGet]` attribute do in a Controller?  
   - A) Send data  
   - B) Update a resource  
   - **<mark>C) Handle a GET request</mark>**  
   - D) Delete data  

---

#### ⚛️ **Frontend Frameworks**

13. In Angular, what is a *component*?  
   - A) An external module  
   - B) A backend service  
   - **<mark>C) A part of the UI</mark>**  
   - D) A build script  

14. In React, what is `useState`?  
   - A) A type of component  
   - **<mark>B) A hook to manage state</mark>**  
   - C) A hook for API requests  
   - D) A type of props  

15. What does VueJS use to loop through items?  
   - A) `*each`  
   - **<mark>B) `v-for`</mark>**  
   - C) `loop`  
   - D) `ng-for`  

16. In Svelte, how do you declare a reactive variable?  
   - A) `@reactive`  
   - B) `this.reactive`  
   - **<mark>C) `$:`</mark>**  
   - D) `var:`  

---

#### 💡 **General Concepts**

17. What is CRUD?  
   - A) A type of database  
   - B) A security pattern  
   - **<mark>C) Create, Read, Update, Delete</mark>**  
   - D) A REST API format  

18. How do you install dependencies in Angular?  
   - A) `ng add`  
   - B) `ng install`  
   - **<mark>C) `npm install`</mark>**  
   - D) `ng dependencies`  

19. What is the purpose of `package.json`?  
   - A) Save logs  
   - B) Configure production builds  
   - **<mark>C) Manage project dependencies</mark>**  
   - D) Create containers  

20. How do you start services using Docker Compose?  
   - A) `docker-compose run`  
   - B) `docker-compose build`  
   - C) `docker-compose start`  
   - **<mark>D) `docker-compose up`</mark>**  

---
### 💻 **Part II – Final Project (10 points)**

#### 🔧 Project: **Task Manager (CRUD Application)**

---

### ✅ Requirements

#### 📦 Backend (ASP.NET Core API):
- Create a `.NET Core WebAPI` project
- Build CRUD operations for "Task" entity:
  - ID
  - Title
  - Description
  - Completed (boolean)
- Use Entity Framework with SQLite
- Enable CORS
- Push code to a public GitHub repository

#### 🌐 Frontend App:
Use a frontend framework based on the **last digit of the student ID**:
| Last Digit | Framework |
|------------|-----------|
| 0, 2, 4    | Angular   |
| 1, 3, 5    | React     |
| 6, 9       | VueJS     |
| 7, 8       | Svelte    |

Must implement:
- Fetching tasks from the API
- Listing, creating, updating, deleting tasks
- Simple UI (Bootstrap, Tailwind or Material allowed)

#### 🐳 Docker Setup:
- Create `Dockerfile` for **backend** and **frontend**
- Create `docker-compose.yml` to simulate production
- Must run using `docker-compose up`

---

### 📁 Expected GitHub Repo Structure

```
/final-project
├── backend/
│   ├── Dockerfile
│   └── src/
│       └── TodoApi/
├── frontend/
│   ├── Dockerfile
│   └── src/
│       └── app/
├── docker-compose.yml
├── README.md
```

---

## 📄 **Extra Requirement – Project README**

The `README.md` file in the GitHub repository **must contain this final exam** (both parts I and II).

- Students must **highlight their selected answers** in the multiple-choice questions by surrounding the chosen option with `**` (markdown bold).
  
  ### Example:
  ```markdown
  1. What is Docker?  
     - A) A relational database  
     - **B) A container platform for creating and managing environments**  
     - C) A web server  
     - D) A frontend framework  
  ```
  
  ---
