

using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : ObservableObject 
    {
        [ObservableProperty]
        string text;
    }
}
