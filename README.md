![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/gusroitman/BlazorSyncDash?logoColor=red)
![.Net](https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white)
![Blazor](https://img.shields.io/badge/blazor-%235C2D91.svg?logo=blazor&logoColor=white)
### Hello! I´m Gustavo :wave: 

### I made some Dashboard layouts examples using Blazor and Syncfusion library. 

### You need to follow this steps to install the library :
#### First we need to install this nuget packages
```
    <PackageReference Include="Syncfusion.Blazor.Charts" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.CircularGauge" Version="20.4.0.42" />
    <PackageReference Include="Syncfusion.Blazor.Diagram" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Kanban" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Layouts" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Cards" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.LinearGauge" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Maps" Version="20.4.0.42" />
    <PackageReference Include="Syncfusion.Blazor.Navigations" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Grid" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.Themes" Version="20.4.0.41" />
    <PackageReference Include="Syncfusion.Blazor.DropDowns" Version="20.4.0.41" />
```

#### You will also need a valid License Key. Check the requeriments at Syncfusion.

#### Open ~/_Imports.razor file and import the Syncfusion.Blazor namespace.
```
@using Syncfusion.Blazor
```

#### For .NET 6 and .NET 7 app, open the ~/Program.cs file and register the Syncfusion Blazor Service.

```
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor; // <--- add this

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSyncfusionBlazor(); // <--- add this

var app = builder.Build();
....
```

#### Add Style sheet at ~/Pages/_Layout.cshtml for .NET 6.
```
@using Syncfusion.Blazor
```
<head>
    ...
    <link href="_content/Syncfusion.Blazor.Themes/bootstrap5.css" rel="stylesheet" />
    <!--Refer theme style sheet as below if you are using Syncfusion.Blazor Single NuGet-->
    <!--<link href="_content/Syncfusion.Blazor/styles/bootstrap5.css" rel="stylesheet" />-->
</head>
```

#### Add Script reference in ~/Pages/_Layout.cshtml for .NET 6.

```
<head>
    ...
    <link href="_content/Syncfusion.Blazor.Themes/bootstrap5.css" rel="stylesheet" />
    <script src="_content/Syncfusion.Blazor.Core/scripts/syncfusion-blazor.min.js" type="text/javascript"></script>
    <!--Use below script reference if you are using Syncfusion.Blazor Single NuGet-->
    <!--<script  src="_content/Syncfusion.Blazor/scripts/syncfusion-blazor.min.js"  type="text/javascript"></script>-->
</head>
```
---

#### Some screenshots :

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img1.png)

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img2.png)

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img3.png)

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img4.png)

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img5.png)

![This is an image](https://github.com/gusroitman/BlazorSyncDash/blob/master/wwwroot/images/img6.png)


If you have any questions feel free to ask. :right_anger_bubble:
