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