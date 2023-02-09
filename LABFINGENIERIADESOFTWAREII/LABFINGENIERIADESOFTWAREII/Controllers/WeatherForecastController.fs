namespace LABFINGENIERIADESOFTWAREII.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open LABFINGENIERIADESOFTWAREII

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController (logger : ILogger<WeatherForecastController>) =
    inherit ControllerBase()

    let chance = 
        [|
        25
        10
        7
        18
        20
        5
        15
        0
        |]

    let summaries =
        [|
            "Soleado"
            "Nublado"
            "Lluvioso"
            "Tormentoso"
            "Con niebla"
        |]
        
    [<HttpGet>]
    member _.Get() =
        let rng = System.Random()
        [|
            for index in 0..7 ->
                { Fecha = DateTime.Now.AddDays(float index)
                  TemperaturaC = rng.Next(-20,30)
                  Estado = summaries.[rng.Next(summaries.Length)]
                  Probabilidad = $"%d{chance[index]}"
                  }
        |]
