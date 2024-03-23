
# .Net TodoList API




## Run Locally

Clone the project

```bash
  git clone https://github.com/U-sama/TodoList.git
```

Go to the project directory

```bash
  cd TodoList
```

Start the server

```bash
  docker-compose up
```


## API Reference

### Http
```
http://localhost:8080/api/Todos
```
### Https
```
https://localhost:8081/api/Todos
```

#### GET all Todos

```http
  GET /api/Todos
```

```
[
    {
        "id": 1,
        "name": "Do Home work",
        "isComplete": true
    },
    {
        "id": 2,
        "name": "Play Football",
        "isComplete": false
    },
    {
        "id": 3,
        "name": "Eat Breakfast",
        "isComplete": false
    }
]
```
#### GET todo

```http
  GET /api/Todos/2
```
```
{
    "id": 2,
    "name": "Play football",
    "isComplete": false
}
```

#### POST Todo

```http
  POST /api/Todos
```
##### Body
```
{
        "name": "Visit Relatives",
        "isComplete": true
}
```

```
{
    "id": 4,
    "name": "Visit Relatives",
    "isComplete": true
}
```
#### PUT Todo

```http
  PUT /api/Todos/4
```
##### Body
```
{
    "id": 4,
    "name": "Visit Uncle",
    "isComplete": true
}
```

#### DELETE Todo

```http
  DELETE /api/Todos/4
```
## Tech Stack

**Server:** .Net, Docker, docker-compose

**Database:** Postgres


