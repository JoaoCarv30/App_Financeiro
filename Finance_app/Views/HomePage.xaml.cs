using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finance_app.ViewModels;

namespace Finance_app.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }

    private void OnDrinkClicked(object? sender, EventArgs e)
    {
        DisplayAlert("Icone", "Cliquei no ícone de bebida", "OK");
    }
}