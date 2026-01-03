# 🌐 .NET 3rd Party API Integrations

This repository demonstrates clean and practical integrations with external (3rd-party) APIs using **ASP.NET Core Web API**.  
The project focuses on real-world API consumption, proper layering, and clean service abstraction.

---

## 🚀 Implemented APIs

### ✅ Currency API
- Integrates with **Frankfurter Currency API**
- Supports currency conversion between different currencies
- Uses **HttpClientFactory** for safe and scalable HTTP calls

**Endpoint**
```http
GET /api/currency/convert?from=USD&to=TRY&amount=100
Sample Response

json
Kodu kopyala
{
  "result": 3150.45
}
✅ Weather API
Integrates with a public Weather API

Retrieves current weather data by city

Demonstrates DTO mapping and external response handling

Endpoint
GET /api/weather?city=Istanbul
🛠️ Technologies & Concepts
ASP.NET Core Web API

HttpClientFactory

Dependency Injection

DTO Pattern

Interface-based Service Design

Clean Project Structure

Swagger / OpenAPI

Third-Party API Integration

📂 Project Structure
css
Kodu kopyala
src
│
├── Currency.Api
│   ├── Controllers
│   ├── Services
│   ├── DTOs
│
├── Weather.Api
│   ├── Controllers
│   ├── Services
│   ├── DTOs
│
└── 3rdPartyApiIntegrations.sln
⚠️ Notes
appsettings.Development.json is intentionally ignored for security reasons

External API responses are mapped using DTOs

Error handling is kept minimal for clarity and learning purposes

🎯 Purpose of This Project
This project was created to:

Practice real-world 3rd party API integrations

Demonstrate clean backend architecture

Serve as a portfolio project for backend developer positions
