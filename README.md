# HeyDanThomas.com

Website for HeyDanThomas (@DannyT)

## Prerequisities

### [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/)

Orchard Core runs on the .NET Core. Download the latest version from [https://www.microsoft.com/net/download/core](https://www.microsoft.com/net/download/core).

## Orchard Core Reference

This project is referencing a stable build of Orchard Core ([`1.4.0`](https://www.nuget.org/packages/OrchardCore.Application.Cms.Core.Targets/1.4.0)).

## Running Locally

### CLI

Run the command shown below and then navigate to `https://localhost:5001` in your browser of choice where you'll be preesented with the Orchard setup page.

    dotnet run --project src/HeyDanThomas.OrchardCore.Site

### Visual Studio

Open the solution in Visual Studio and run the `HeyDanThomas.OrchardCore.Site` project. This will open your default browser and you'll be presented with the Orchard setup page.

## Notes

This project was created using `1.3.0` of [our boilerplate template](https://github.com/EtchUK/heydanthomas.orchardcore.site).
