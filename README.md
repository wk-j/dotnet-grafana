## Install

```bash
dotnet add src/MyWeb/MyWeb.csproj package App.Metrics.AspNetCore.Mvc
dotnet add src/MyWeb/MyWeb.csproj package App.Metrics.Formatters.Prometheus
```

## Start

```bash
docker-compose up --build
open http://localhost:9090
open http://localhost:3000
```

## API

```bash
2204
curl http://localhost:5000/metrics
curl http://localhost:5000/metrics-text
curl http://localhost:5000/env
curl http://localhost:5000/WeatherForecast
curl http://localhost:5000/api/error/raise

curl http://localhost/metrics
curl http://localhost/metrics-text
curl http://localhost/env

curl http://localhost/WeatherForecast

wrk -t12 -c400 -d60s http://127.0.0.1/WeatherForecast
wrk -t12 -c400 -d10s http://127.0.0.1/api/error/raise
```

## Resource

- https://medium.com/@aevitas/expose-asp-net-core-metrics-with-prometheus-15e3356415f4
- https://www.youtube.com/watch?v=sM7D8biBf4k
- https://hub.packtpub.com/app-metrics-analyze-http-traffic-errors-network-performance-net-core-app