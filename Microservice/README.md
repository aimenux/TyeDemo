# Microservice
```
Microservice with two services (frontend & backend)
```

> This sample is based on this [microsoft blog post](https://devblogs.microsoft.com/aspnet/introducing-project-tye/) about [Tye](https://github.com/dotnet/tye).

```
PS TyeDemo\Microservice> tye run
Loading Application Details...
Launching Tye Host...
[13:15:57 INF] Executing application from TyeDemo\Microservice\Microservice.sln
[13:15:57 INF] Dashboard running on http://127.0.0.1:8000
[13:15:57 INF] Building projects
[13:15:59 INF] Launching service backend_5c29e32a-b: TyeDemo\Microservice\Backend\bin\Debug\netcoreapp3.1\Backend.exe
[13:15:59 INF] Launching service frontend_7e5e1060-6: TyeDemo\Microservice\Frontend\bin\Debug\netcoreapp3.1\Frontend.exe
[13:15:59 INF] backend_5c29e32a-b running on process id 20468 bound to http://localhost:4355, https://localhost:4356
[13:15:59 INF] Replica backend_5c29e32a-b is moving to a ready state
[13:15:59 INF] frontend_7e5e1060-6 running on process id 16768 bound to http://localhost:4353, https://localhost:4354
[13:15:59 INF] Replica frontend_7e5e1060-6 is moving to a ready state
[13:15:59 INF] Selected process 20468.
[13:15:59 INF] Selected process 16768.
[13:15:59 INF] Listening for event pipe events for backend_5c29e32a-b on process id 20468
[13:15:59 INF] Listening for event pipe events for frontend_7e5e1060-6 on process id 16768
[13:24:19 INF] Tye Host is stopping...
[13:24:19 INF] Event pipe collection completed for frontend_7e5e1060-6 on process id 16768
[13:24:19 INF] Event pipe collection completed for backend_5c29e32a-b on process id 20468
[13:24:19 INF] backend_5c29e32a-b process exited with exit code -1
[13:24:19 INF] frontend_7e5e1060-6 process exited with exit code -1
```

**`Tools`** : vs19, net core 3.1, tye