# 📦 Backend — Projekt Zespołowy

Backend aplikacji wykonany w ramach projektu zespołowego.
Odpowiada za logikę biznesową, komunikację z bazą danych oraz udostępnianie API dla części frontendowej.

---

## 🧠 Zakres odpowiedzialności (Backend)

* implementacja logiki aplikacji
* projekt i obsługa bazy danych
* tworzenie REST API
* walidacja danych i obsługa błędów
* autoryzacja / uwierzytelnianie użytkowników *(jeśli dotyczy)*
* przetwarzanie i analiza danych *(np. logów — jeśli projekt to obejmuje)*
* integracja z frontendem

---

## 🏗️ Technologie

| Obszar                         | Technologia                               |
| ------------------------------ | ----------------------------------------- |
| Język                          | `C#`       |
| Framework                      | `Asp.net`    |
| Baza danych                    | `Ms Sql`                                  |
| API                            | REST                                      |

---

## 📁 Struktura projektu

```
Backend/
├── Controllers/ # Kontrolery API
├── Services/ # Logika biznesowa
├── Models/ # Modele danych
├── DTOs/ # Obiekty transferu danych
├── Mappers/ # Mapowanie DTO <-> Model
├── Validators/ # Walidacja danych
├── Data/ # DbContext, konfiguracja bazy
├── Migrations/ # Migracje EF
├── Utils/ # Pomocnicze klasy
├── Properties/
├── Program.cs
└── ProjektZespolówka.sln
```

---

## 🚀 Uruchomienie projektu lokalnie

### 1️⃣ Klonowanie repozytorium

```
git clone <repo-url>
cd Backend
```

### 2️⃣ Przywracanie zależności

```
dotnet restore
```

### 3️⃣ Konfiguracja zmiennych środowiskowych
Edytuj appsettings.json i appsettings.Development.json:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=<DB_SERVER>;Database=<DB_NAME>;User Id=<USER>;Password=<PASSWORD>;"
  },
  "JwtSettings": {
    "Secret": "your_secret_key",
    "ExpiryMinutes": 60
  }
}

---

### 4️⃣ Uruchomienie aplikacji

```
dotnet run
```

Backend będzie dostępny pod:

```
http://localhost:5000
```

---
## 🗄️ Baza danych

Projekt używa Entity Framework Core do zarządzania bazą danych.

*DbContext w folderze Data/

*Migracje w folderze Migrations/

*Modele danych w Models/

*DTO w DTOs/

---

## 🔐 Bezpieczeństwo

* Walidacja danych wejściowych

* Obsługa błędów HTTP

* Użycie zmiennych środowiskowych (appsettings.json lub .env w razie potrzeby)

* JWT / autoryzacja użytkowników

---

## 📄 Autor (Backend)

**Imię i nazwisko:** `Mateusz Gawlik`
**Rola:** Backend Developer
**Zakres prac:** implementacja API, integracja z bazą danych, logika aplikacji

---

## 📜 Licencja

Projekt edukacyjny — wykonany w ramach zajęć.
