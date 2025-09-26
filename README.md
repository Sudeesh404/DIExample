# DIExample

A minimal .NET console demo showing constructor dependency injection using Microsoft.Extensions.DependencyInjection.

Branch: `add-transient-di`

What changed
- `Program.cs` was updated to configure a DI container using `ServiceCollection` and register:
  - `IMessageService` implemented by `SmsService` with `AddTransient`.
  - `Notification` as a transient service so it can be resolved with constructor injection.
- Added NuGet package: `Microsoft.Extensions.DependencyInjection`.

How to build and run (PowerShell)

```powershell
cd 'C:\Users\Sushi\Desktop\DIExample'
dotnet build -c Debug
dotnet run -c Debug
```

Expected output

```
SMS sent: Hello Dependency Injection with AddTransient!
```

Switch the registered implementation
- To use `EmailService` instead of `SmsService`, open `Program.cs` and change the registration line:

```csharp
services.AddTransient<IMessageService, SmsService>();
```

to

```csharp
services.AddTransient<IMessageService, EmailService>();
```

Git / remote
- The change is on branch `add-transient-di`. If you need the branch on the remote, push it:

```powershell
cd 'C:\Users\Sushi\Desktop\DIExample'
git push -u origin add-transient-di
```

Notes
- Requires .NET SDK compatible with the project (this repository targets net9.0).
- This repository is intentionally tiny — consider adding tests or configuration-based selection if you want to extend it.
