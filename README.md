# Model Binding in Syncfusion Blazor Checkbox and Radio Button Components

## Overview

This sample demonstrates how to bind application model values to Syncfusion [Blazor Checkbox](https://www.syncfusion.com/blazor-components/blazor-checkbox) and [Blazor Radio Button](https://www.syncfusion.com/blazor-components/blazor-radio-button) components within a Blazor WebAssembly application. The implementation shows how component state can be synchronized with business models while also responding to user interaction through native events.

Model binding simplifies form development by keeping UI values and application data synchronized. This sample provides a reference implementation for handling checkbox and radio button selections in typical data-entry scenarios.

## Key Features

- Demonstrates native event handling with Blazor Checkbox and Radio Button components using the `@onchange` event.
- Uses the `Checked` property in `SfCheckBox` to display and update checkbox state through the `ValueChanged` method.
- Uses the `Checked`, `Value`, `Label`, and `Name` properties in `SfRadioButton` components to manage gender selection and group radio buttons.
- Updates UI values dynamically through the `OnSelect` event handler and displays the currently selected radio button value.
- Demonstrates two-way model binding using the `@bind-Checked` directive with Syncfusion Checkbox and Radio Button components.
- Integrates Syncfusion input components within a Blazor `EditForm` for form-based data entry scenarios.
- Uses Data Annotations validation with `DataAnnotationsValidator` and `ValidationMessage` components.
- Validates mandatory agreement acceptance using the `[Range(typeof(bool), "true", "true")]` attribute.
- Validates radio button selection through model-bound properties and Data Annotation rules.
- Uses `SfButton` with HTML submit attributes to trigger form submission.
- Includes a hosted Blazor WebAssembly example that consumes server-side data through `HttpClient`.
- Demonstrates API consumption using `Http.GetFromJsonAsync<WeatherForecast[]>()` to retrieve weather forecast data.
- Displays server-generated weather information in a tabular layout using the shared `WeatherForecast` model.
- Uses a shared project to define common data models consumed by both the Client and Server applications.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet) compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `BindCheckBoxAndRadioButton.sln`

3. Restore NuGet packages.
4. Build the solution.
5. If required, set the hosted server project as the startup project.
6. Press `Ctrl+F5` to run the application.

**Visual Studio Code**

1. Open the repository folder.

2. Navigate to the repository root.

```bash
dotnet restore
dotnet run
```

3. Open the local URL displayed in the console after the application starts.

## Project Structure

`Client/Pages/Index.razor` - Main sample page demonstrating Syncfusion Checkbox and Radio Button native event handling, model binding, two-way binding with `@bind-Checked`, and EditForm validation using Data Annotations.

`Client/Pages/FetchData.razor` - Demonstrates calling the server API using `HttpClient`, retrieving weather forecast data, and rendering the results in a table.

`Server/Controllers/WeatherForecastController.cs` - ASP.NET Core API controller that generates and returns weather forecast data to the Blazor WebAssembly client.

`Shared/WeatherForecast.cs` - Shared data model containing weather forecast properties (`Date`, `TemperatureC`, `Summary`, and calculated `TemperatureF`) used by both Client and Server projects.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- Official documentation:
  - Checkbox model binding: https://blazor.syncfusion.com/documentation/check-box/how-to/checkbox-model-binding
  - Radio Button model binding: https://blazor.syncfusion.com/documentation/radio-button/how-to/radio-button-model-binding

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.