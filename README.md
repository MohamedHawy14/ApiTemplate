```markdown
# 🚀 ASP.NET Core 8 API Template with N-Tier Architecture

تمبلت قوية وجاهزة لأي مشروع Backend مبنية باستخدام  
**ASP.NET Core 8** بـ **N-Tier Architecture**، نظيفة، قابلة للتوسع، وقابلة لإعادة الاستخدام في مشاريع التخرج، الـ Freelance، أو حتى الـ Production الحقيقي.

---

## 📂 Project Structure

```
SolutionName/
│
├── API                  --> Controllers & appsettings only
├── DataAccess           --> DbContext, Models, Migrations, Repository & UnitOfWork
├── Services             --> DTOs, Interfaces, Business Logic, SignalR Hubs
└── Utilities            --> Shared Logic, Static Helpers, Image Handler
```

---

## 🔐 Built-in Authentication

التمبلت جواه Basic Auth System جاهز وبيحتوي على أهم الـ Endpoints لأي تطبيق:

- ✅ Register
- ✅ Confirm Email
- ✅ Login (Access & Refresh Tokens)
- ✅ Forget Password
- ✅ Reset Password

> ✅ **Email Sending** using **MailKit**  
> 🔐 **OTP** stored in **Redis** for high performance

---

## ⚙️ Features

- ✅ Clean Code Architecture
- ✅ N-Tier Modular Design
- ✅ Full Dependency Injection
- ✅ Scalable & Maintainable
- ✅ Basic Auth Implementation
- ✅ Redis Integration for OTP
- ✅ MailKit Integration
- ✅ Image Handling with path stored in DB
- ✅ Ready for Real-time (SignalR Hubs)

---

## 🧠 Tech Stack

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Redis
- MailKit
- SignalR (optional, prepared)
- JWT & Refresh Tokens

---

## 💻 How to Run Locally

1. **Clone the Repo**  
   افتح التيرمنال أو Git Bash واكتب:
   ```bash
   git clone https://github.com/YourUsername/YourRepoName.git
   ```

2. **Open the Solution**  
   - افتح Visual Studio 2022 أو أعلى
   - افتح ملف `.sln`

3. **Set API as Startup Project**  
   - Right-click على مشروع `API`
   - اختار `Set as Startup Project`

4. **Configure Database Connection**  
   - افتح `appsettings.json` في مشروع `API`
   - عدل الـ Connection String حسب جهازك

5. **Apply Migrations**
   - افتح Package Manager Console
   - شغل الأوامر دي:
     ```bash
     Update-Database
     ```

6. **Run the Project**
   - شغل الـ API من Visual Studio
   - جرب الـ Endpoints باستخدام Postman أو Swagger

---

## 🧪 Ready for Development

ممكن تبدأ تشتغل على Features جديدة بسهولة:

- ضيف Business Logic في `Services`
- ضيف API Endpoints في `API/Controllers`
- تعامل مع البيانات من خلال الـ `UnitOfWork`
- شارك Data Transfer Objects بين الـ Layers

---

## 📌 Suitable For

- مشاريع التخرج
- أي مشروع Backend جديد
- تطوير Freelance سريع
- MVPs و Prototypes
- Teams بيدورا على Structure نظيف

---

## 📬 Need Help?

لو عندك أي استفسار أو محتاج مساعدة في استخدام التمبلت، ابعتلي على LinkedIn أو افتح Issue هنا في الريبو ✌️

---

## ⭐ Contribute

- Pull Requests are welcome.
- حابب تطور أو تزود Features؟ شارك عادي.

---

**Built with ❤️ by Mohamed Saad – [LinkedIn](https://www.linkedin.com/in/mohamed-saad-bb0119242)**
```
