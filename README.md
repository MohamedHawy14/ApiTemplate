# 🚀 ASP.NET Core 8 API Template with N-Tier Architecture

تمبلت قوية وجاهزة لأي مشروع Backend مبنية باستخدام  
**ASP.NET Core 8** بـ **N-Tier Architecture**، نظيفة، قابلة للتوسع، وسهلة إعادة الاستخدام سواء في مشاريع التخرج، الـ Freelance أو حتى الـ Production الحقيقي.

---

## 📁 Project Structure

```
ApiTemplate/
│
├── API                  --> Controllers + AppSettings
├── DataAccess           --> DbContext, Models, Migrations, Repository, UnitOfWork
├── Services             --> DTOs, Interfaces, Business Logic, SignalR Hubs (optional)
└── Utilities            --> Shared Logic, Static Helpers, Image Handler
```

---

## 🔐 Built-in Authentication System

التمبلت فيها الأساسيات اللي أي Backend بيبدأ بيها:

- ✅ **Register**
- ✅ **Confirm Email**
- ✅ **Login** (Access Token + Refresh Token)
- ✅ **Forgot Password**
- ✅ **Reset Password**

🔹 بيتم إرسال الإيميلات باستخدام **MailKit**  
🔹 الأكواد (OTP) بتتخزن في **Redis** لأداء أسرع

---

## 🔧 Features

- ✅ Clean Architecture
- ✅ Full Dependency Injection
- ✅ Ready Authentication System
- ✅ Modular N-Tier Design
- ✅ Redis Integration (OTP)
- ✅ MailKit Integration
- ✅ Image Upload & Path Storage (DB)
- ✅ Ready for Real-Time with SignalR
- ✅ Repository + UnitOfWork Patterns
- ✅ Separated Concerns for Scalability

---

## 🧠 Tech Stack

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Redis
- MailKit
- SignalR (optional)
- JWT + Refresh Tokens

---

## 🛠️ Getting Started

### 1. ✅ Clone the Project

```bash
git clone https://github.com/MohamedHawy14/ApiTemplate.git
```

---

### 2. 📂 Open in Visual Studio

- افتح ملف `ApiTemplate.sln` باستخدام **Visual Studio 2022** أو أعلى

---

### 3. 🚀 Set Startup Project

- كليك يمين على مشروع `API`
- اختار: `Set as Startup Project`

---

### 4. ⚙️ Configure Your Connection String

- افتح `appsettings.json` في مشروع `API`
- عدل الـ `"DefaultConnection"` على حسب الـ SQL Server عندك

---

### 5. 🧱 Apply Migrations

- افتح **Package Manager Console**
- شغّل:

```bash
Update-Database
```

---

### 6. ▶️ Run & Test

- شغّل المشروع من Visual Studio
- جرب الـ Endpoints باستخدام **Swagger** أو **Postman**

---

## 📦 What You Get Out of the Box

- ✅ Modular Architecture
- ✅ Built-in Auth (Register/Login/Reset Password)
- ✅ Redis for OTP
- ✅ MailKit Email Sender
- ✅ Image Upload Service
- ✅ Clean Code & Best Practices
- ✅ Plug-n-Play Ready

---

## 💡 Suitable For:

- 🎓 Graduation Projects
- 🚀 MVPs و Prototypes
- 🧑‍💻 Freelance Work
- 🏢 Real Production APIs
- 👨‍👩‍👧‍👦 Small to Mid-size Teams

---

## 🤝 Contribute

- حابب تطور أو تزود Feature جديدة؟  
  Pull Requests مرحّب بيها 👏

---

## 📬 Need Help?

لو عندك استفسار أو عايز توجيه في أي خطوة:  
كلّمني على [LinkedIn](https://www.linkedin.com/in/mohamed-saad-bb0119242) أو افتح Issue على GitHub ✌️

---

**Built with ❤️ by Mohamed Saad**  
🔗 GitHub: [MohamedHawy14](https://github.com/MohamedHawy14/ApiTemplate.git)  
🔗 LinkedIn: [mohamed-saad-bb0119242](https://www.linkedin.com/in/mohamed-saad-bb0119242)
