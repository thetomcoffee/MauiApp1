﻿

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiApp1.ViewModel
{
    public partial class MainViewModel : ObservableObject 
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }
        a
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);

            //add our item
            Text = string.Empty;


        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
                Items.Remove(s);
        }

    }
}
