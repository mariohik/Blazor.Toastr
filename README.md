# Blazor.Notifications
Implementation of the [Toastr Notifications](http://codeseven.github.io/toastr/) in C# for [Blazor](https://github.com/aspnet/Blazor) via Interop

![Blazor.Toastr](https://imgur.com/b1kgkay)


> ⚠️ Warning: This project is build on top of an experimental framework. There is a high propability that there will be breaking changes from version to version.  


## Installation

```
> dotnet add package Blazor.Toastr

OR

PM> Install-Package Blazor.Toastr
```
Nuget package & Release notes can be found [here](https://www.nuget.org/packages/Blazor.Toastr).

## Usage

### Add jQuery to index.html

```html
<script src="js/jquery-3.3.1.min.js"></script>
```

### Add INotificationService via DI

```csharp
var serviceProvider = new BrowserServiceProvider(services =>
{
    services.AddToastr();
});

OR 

var serviceProvider = new BrowserServiceProvider(services =>
{
    services.AddToastr(new ToastrOptions { closeButton = true, hideDuration = 3000 });
});
```

### Inject into component/pages
```csharp
@using Blazor.Toastr
@inject IToastrService Toastr
```

### Add OnClick Action
```csharp
void AnyMethod() {
  Toastr.Show(Enums.ToastrType.Success, "This is a success message", "Title");
}
```