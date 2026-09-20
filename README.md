# TaskFlow

A small ASP.NET Core Web API built while learning practical .NET backend development.

## 1 — Create Task Vertical Slice

The first milestone implements the **Create Task** use case from HTTP request to in-memory storage.

### Flow

```text
POST /tasks
     │
     ▼
TaskController
     │
     ▼
TaskService
     │
     ▼
ITaskRepository
     │
     ▼
InMemoryTaskRepository
     │
     ▼
List<TaskItem>