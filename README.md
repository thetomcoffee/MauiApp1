# MauiApp1

Playing around with the starter .NET MAUI solution created by Visual Studio 2022.  

Using this as a guide: 
[.NET MAUI for Beginners](https://docs.microsoft.com/en-us/shows/dotnet-maui-for-beginners/)
and 
[Build your first app](https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app?pivots=devices-windows&tabs=vswin) 
which is part of
[.NET Multi-platform App UI documentation](https://docs.microsoft.com/en-us/dotnet/maui/)
This last link has comprehensive documentation on .NET MAUI.

Updated default app to show current date and time when button is clicked.  

 ... changing this app to be a:

# To Do Tasks App

Per this tutorial:
[Build .NET MAUI UI with XAML [4 of 8] | .NET MAUI for Beginners](https://docs.microsoft.com/en-us/shows/dotnet-maui-for-beginners/build-dotnet-maui-ui-with-xaml-4-of-8-dotnet-maui-for-beginners) 
Updating this app to be a To Do Tasks app. 

Per
[.NET MAUI Data Binding with MVVM & XAML [5 of 8] | .NET MAUI for Beginners](https://docs.microsoft.com/en-us/shows/dotnet-maui-for-beginners/dotnet-maui-data-binding-with-mvvm-xaml-5-of-8-dotnet-maui-for-beginners)
Setting up MVVM.  Added ViewModel folder, and MainViewModel.cs.  For convenience, MainPage.xaml matches associated view model MainViewModelcs.  
Finished setting up data binding, MVVM, Add and Delete function for To Do app. 

Continuing with 6 of 8:
[Navigating Between Pages in .NET MAUI [6 of 8] | .NET MAUI for Beginners](https://docs.microsoft.com/en-us/shows/dotnet-maui-for-beginners/navigating-between-pages-in-dotnet-maui-6-of-8-dotnet-maui-for-beginners)
Demonstrating navigation and data passing between pages/screens.  
Starting with URL shell-based navigation. 
In our Details page, we can pass info (e.g. string of task) to our Details page/screen using a query property (similar to a URL) which can string strings and complex data types, 
Dictionary of string, objects. 
Finished added Details page, passing text of task, and display, in Details page. 
Also added back button to Details Page, to go back to Main Page. 

7 of 8:
[Accessing Platform Features in .NET MAUI [7 of 8] | .NET MAUI for Beginners](https://learn.microsoft.com/en-us/shows/dotnet-maui-for-beginners/accessing-platform-features-in-dotnet-maui-7-of-8-dotnet-maui-for-beginners)

* side note, check out Microsoft.Maui.Accesibility (research how to make accessible mobile apps)
* see more in Microsoft.Maui.ApplicationModel (namespace with classes, methods to launch the browser) 
* Microsoft.Maui.ApplicationModel.Communication (has functionality for contact, emails, SMS, phone dialer)
In this next step, we're using Microsoft.Maui.Networking.Connectivity 
Side note, the debugger relies on Internet connectivity it order to debug your app, so the connectivity testing was done w/out debugging turned on.  

8 of 8 
[.NET MAUI Resources & Beginner Series Recap [8 of 8] | .NET MAUI for Beginners](https://learn.microsoft.com/en-us/shows/dotnet-maui-for-beginners/dotnet-maui-resources-beginner-series-recap-8-of-8-dotnet-maui-for-beginners)

Recap:
* .NET MAUI Overview, Archetecture.  One code base, multi outputs (deployments):  desktop (Windows and macOS) and mobile (Android & iOS) 
* used live preview and hot reload (seemed to have some issues regarding needed to restart the app entirely, even with hot reload.  Seemed like there was less of that so far with Flutter?  Research more. )
* Very new.  Some bugs in videos, like show "use ICommad" but note to scree to use "[RelayCommand]"
* [ObservableProperty] seemed to help cut down boiler plate code with CommunityToolkit.Mvvm by Microsoft. 
* Building UIs with XAML
* Data Binding using MVVM

More Info Links: 
* [Build mobile and desktop apps with .NET MAUI](https://learn.microsoft.com/en-us/training/paths/build-apps-with-dotnet-maui/?WT.mc_id=dotnet-29192-cxa%3FWT.mc_id%3Ddotnet-29192-cxa)
* [.NET Multi-platform App UI](https://dotnet.microsoft.com/en-us/apps/maui?WT.mc_id=dotnet-29192-cxa)
* Definitely check out: [Fully native or go hybrid with Blazor](https://docs.microsoft.com/aspnet/core/blazor/hybrid/tutorials/maui?WT.mc_id=dotnet-35129-website)
        summary:  Start building hybrid applications today with C# instead of JavaScript. Share your Blazor web components directly in .NET MAUI apps while having access to native device capabilities and packaging.

        By using .NET MAUI and Blazor together, you can reuse one set of web UI components across mobile, desktop, and web.
        [Build a .NET MAUI Blazor app](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?WT.mc_id=dotnet-35129-website&view=aspnetcore-6.0)


* [.NET Multi-platform App UI documentation](https://learn.microsoft.com/en-us/dotnet/maui/?WT.mc_id=dotnet-29192-cxa)
* [YouTube: Welcome to .NET MAUI! | .NET Conf: Focus on MAUI](https://www.youtube.com/watch?v=zp3Ja-jAjq4&list=PLdo4fOcmZ0oWePZU3W162NJ9vcXqgpMVc)
* [Twitter: James Montemagno
@JamesMontemagno
](https://twitter.com/jamesmontemagno)