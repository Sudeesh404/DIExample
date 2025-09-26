**Dependency Injection Example in C#**

This is a simple C# Console Application that demonstrates the concept of Dependency Injection (DI).
The project shows how to decouple classes by injecting dependencies instead of creating them directly inside a class.

**📖 What is Dependency Injection?**

**Dependency Injection is a design pattern where a class receives its dependencies from the outside instead of creating them itself.**

Example in this project:

**Notification depends on IMessageService.**

We can inject either EmailService or SmsService without changing the Notification class.

**▶️ How to Run**
1. Clone the repository
  git clone https://github.com/your-username/DIExample.git

  cd DIExample
  
**3. Run the application**
   dotnet run
   
**✅ Example Output**
If EmailService is injected:
Email sent: Hello Dependency Injection!

**🔍 Debugging with Breakpoints**
You can add breakpoints in Visual Studio or VS Code to:

Pause execution.

Inspect which service (EmailService or SmsService) is injected.

Step through code line by line.

**📌 Key Concepts Learned**
Interfaces for abstraction (IMessageService).

Constructor Injection in Notification.

Loose coupling → easier testing and flexibility.
