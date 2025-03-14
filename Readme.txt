```md
# C# Windows Application  

This is a simple C# Windows application developed using **Visual Studio 2019 Community Edition**.  
It is useful for beginners to understand basic concepts like form navigation and `DialogResult` handling.  

---

## DialogResult  

This application demonstrates how to use a form's `DialogResult` property.  

### Application Flow:  
- The application consists of three forms: **Splash Screen, Login, and Dashboard**.  
- In `Program.cs`, an instance of `FormSplashScreen` is created, which appears for **5 seconds**.  
- After that, `FormLogin` starts execution and handles actions for **Login** and **Exit** buttons.  
- On **successful login**, `FormDashboard` is displayed.  
- On **Exit** click, the application terminates.  

---

## Forms Overview  

### **Splash Form**  
This form displays a welcome or splash message about the application.  

### **Login Form**  
- Contains **textboxes** for **User ID** and **Password**.  
- Two buttons: **Login** and **Exit**.  
- On clicking **Login**, it checks the User ID and Password using database logic.  
- The `DialogResult` property is set based on the result:  
  - `DialogResult.OK` for **valid** login details.  
  - `DialogResult.Cancel` for **invalid** login details.  

### **FormDashboard**  
- Contains a **heading** and a **menu**.  
- Clicking the **Exit** menu closes the application.  

---

## 📢 Apply For  

### 🎓 Online C# Project Workshop for College Students  
[Join Now](https://wa.me/p/8685551258164102/919765975757)  

### 📌 Free Project Guidance for College Students  
[Get Guidance](https://wa.me/p/7965729696887851/919765975757)  

### 🚀 Free Online Internship  
[Apply Now](https://wa.me/p/8277870308947674/919765975757)  



