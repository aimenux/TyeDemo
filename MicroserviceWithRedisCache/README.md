# MicroserviceWithRedisCache
```
Microservice with two services (frontend & backend) & redis cache
```

> This sample is based on this [microsoft blog post](https://devblogs.microsoft.com/aspnet/introducing-project-tye/) about [Tye](https://github.com/dotnet/tye).

PS TyeDemo\MicroserviceWithRedisCache> tye run
Loading Application Details...
Launching Tye Host...

[22:29:45 INF] Executing application from TyeDemo\MicroserviceWithRedisCache\tye.yaml
[22:29:46 INF] Dashboard running on http://127.0.0.1:8000
[22:29:47 INF] Running docker command pull redis
[22:29:47 INF] redis: Using default tag: latest
[22:29:48 INF] redis: latest: Pulling from library/redis
[22:29:49 INF] redis: d121f8d1c412: Pulling fs layer
[22:29:49 INF] redis: 2f9874741855: Pulling fs layer
[22:29:49 INF] redis: d92da09ebfd4: Pulling fs layer
[22:29:49 INF] redis: bdfa64b72752: Pulling fs layer
[22:29:49 INF] redis: e748e6f663b9: Pulling fs layer
[22:29:49 INF] redis: eb1c8b66e2a1: Pulling fs layer
[22:29:49 INF] redis: e748e6f663b9: Waiting
[22:29:49 INF] redis: eb1c8b66e2a1: Waiting
[22:29:49 INF] redis: bdfa64b72752: Waiting
[22:29:49 INF] redis: 2f9874741855: Verifying Checksum
[22:29:49 INF] redis: 2f9874741855: Download complete
[22:29:50 INF] redis: d92da09ebfd4: Verifying Checksum
[22:29:51 INF] redis: e748e6f663b9: Verifying Checksum
[22:29:51 INF] redis: e748e6f663b9: Download complete
[22:29:51 INF] redis: eb1c8b66e2a1: Verifying Checksum
[22:29:51 INF] redis: eb1c8b66e2a1: Download complete
[22:29:51 INF] redis: bdfa64b72752: Verifying Checksum
[22:29:51 INF] redis: bdfa64b72752: Download complete
[22:29:53 INF] redis: d121f8d1c412: Verifying Checksum
[22:29:53 INF] redis: d121f8d1c412: Download complete
[22:29:55 INF] redis: d121f8d1c412: Pull complete
[22:29:55 INF] redis: 2f9874741855: Pull complete
[22:29:55 INF] redis: d92da09ebfd4: Pull complete
[22:29:55 INF] redis: bdfa64b72752: Pull complete
[22:29:55 INF] redis: e748e6f663b9: Pull complete
[22:29:55 INF] redis: eb1c8b66e2a1: Pull complete
[22:29:55 INF] redis: Digest: sha256:1cfb205a988a9dae5f025c57b92e9643ec0e7ccff6e66bc639d8a5f95bba928c
[22:29:55 INF] redis: Status: Downloaded newer image for redis:latest
[22:29:55 INF] redis: docker.io/library/redis:latest
[22:29:55 INF] Creating docker network tye_network_9044bd25-7
[22:29:55 INF] Running docker command network create --driver bridge tye_network_9044bd25-7
[22:29:56 INF] Running image redis for redis_48b9aad2-1
[22:29:56 INF] Running image redis for redis-cli_da1b9f67-8
[22:29:56 INF] Running image mcr.microsoft.com/dotnet/core/sdk:3.1 for frontend-proxy_cc9ef163-a
[22:29:56 INF] Running image mcr.microsoft.com/dotnet/core/sdk:3.1 for backend-proxy_ac909be4-b
[22:29:56 INF] Building projects
[22:29:58 INF] Running container redis_48b9aad2-1 with ID 30f8621f48f2
[22:29:58 INF] Running docker command network connect tye_network_9044bd25-7 redis_48b9aad2-1 --alias redis
[22:29:58 INF] Running container redis-cli_da1b9f67-8 with ID 759dcd7ebeb4
[22:29:58 INF] Running docker command network connect tye_network_9044bd25-7 redis-cli_da1b9f67-8 --alias redis-cli
[22:29:59 INF] Replica redis_48b9aad2-1 is moving to a ready state
[22:29:59 INF] Collecting docker logs for redis_48b9aad2-1.
[22:29:59 INF] Replica redis-cli_da1b9f67-8 is moving to a ready state
[22:29:59 INF] Collecting docker logs for redis-cli_da1b9f67-8.
[22:30:03 INF] Launching service frontend_3a7ee735-3: TyeDemo\MicroserviceWithRedisCache\Frontend\bin\Debug\netcoreapp3.1\Frontend.exe
[22:30:03 INF] Launching service backend_8d0f7529-8: TyeDemo\MicroserviceWithRedisCache\Backend\bin\Debug\netcoreapp3.1\Backend.exe
[22:30:03 INF] frontend_3a7ee735-3 running on process id 18828 bound to http://localhost:7113, https://localhost:7114
[22:30:03 INF] Replica frontend_3a7ee735-3 is moving to a ready state
[22:30:03 INF] backend_8d0f7529-8 running on process id 11760 bound to http://localhost:7115, https://localhost:7116
[22:30:03 INF] Replica backend_8d0f7529-8 is moving to a ready state
[22:30:04 INF] Selected process 18828.
[22:30:04 INF] Listening for event pipe events for frontend_3a7ee735-3 on process id 18828
[22:30:04 INF] Selected process 11760.
[22:30:04 INF] Listening for event pipe events for backend_8d0f7529-8 on process id 11760
[22:30:31 INF] Running container frontend-proxy_cc9ef163-a with ID 77243f4bccf6
[22:30:31 INF] Running docker command network connect tye_network_9044bd25-7 frontend-proxy_cc9ef163-a --alias frontend
[22:30:31 INF] Running container backend-proxy_ac909be4-b with ID 1faa9d73a4a0
[22:30:31 INF] Running docker command network connect tye_network_9044bd25-7 backend-proxy_ac909be4-b --alias backend
[22:30:32 INF] Collecting docker logs for backend-proxy_ac909be4-b.
[22:30:32 INF] Collecting docker logs for frontend-proxy_cc9ef163-a.

**`Tools`** : vs19, net core 3.1, redis, tye