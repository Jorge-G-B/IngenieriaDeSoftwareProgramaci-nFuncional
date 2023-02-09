namespace LABFINGENIERIADESOFTWAREII

open System

type WeatherForecast =
    { Fecha: DateTime
      TemperaturaC: int
      Estado: string 
      Probabilidad: string}

    member this.TemperatureF =
        32.0 + (float this.TemperaturaC / 0.5556)
