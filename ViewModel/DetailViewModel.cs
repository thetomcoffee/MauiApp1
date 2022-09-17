

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        //public DetailViewModel(string passed_text)
        //{
        //    this.Text = passed_text;
        //}

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
