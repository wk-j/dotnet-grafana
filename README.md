## Grafana

```
dotnet add src/MyWeb/MyWeb.csproj package prometheus-net
dotnet add src/MyWeb/MyWeb.csproj package prometheus-net.AspNetCore

docker-compose up --build

curl http://localhost:5000/WeatherForecast
open http://localhost:5000/metrics
```

## Prometheus

- http://localhost:9090

## Resource

- https://medium.com/@aevitas/expose-asp-net-core-metrics-with-prometheus-15e3356415f4
- https://www.youtube.com/watch?v=sM7D8biBf4k